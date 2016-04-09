using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSGO_Config_Installer {

    public partial class Form1 : Form {

        public class ConfigFile {
            public string fileName;
            public string fileContent;
            public string fileExtension;
        }

        private List<ConfigFile> _cfgFiles;

        public Form1() {
            InitializeComponent();

            _cfgFiles = new List<ConfigFile>();

            if (tbSteamDir.Text == "") {
                tbSteamDir.Text = "Enter your steam directory";
                tbSteamDir.ForeColor = Color.Gray;
            }
            else {
                tbSteamDir.ForeColor = Color.Black;
            }
        }

        private void btnBrowseSteamDir_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "Choose the root steam folder, e.g C:\\Program Files (x86)\\Steam";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK) {
                tbSteamDir.Text = fbd.SelectedPath;
            }
        }

        private void btnAutoFindSteamDir_Click(object sender, EventArgs e) {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives) {
                try {
                    string[] files = System.IO.Directory.GetDirectories(drive.Name);

                    foreach (var file in files) {

                        if (isCorrectSteamFolder(file)) {
                            tbSteamDir.Text = file;
                        }

                        try {
                            string[] files2 = System.IO.Directory.GetDirectories(file);

                            foreach (var file2 in files2) {
                                if (isCorrectSteamFolder(file2)) {
                                    tbSteamDir.Text = file2;
                                }

                            }
                        }
                        catch (Exception ioe) {
                        }
                    }
                }
                catch (Exception) { }
            }
        }

        private bool isCorrectSteamFolder(string file) {
            if (file.Contains("Steam")) {
                string[] files = System.IO.Directory.GetFiles(file);

                foreach (var fileit in files) {
                    if (fileit.Contains("Steam.exe")) {
                        return true;
                    }
                }

            }

            return false;
        }

        private void tbSteamDir_Enter(object sender, EventArgs e) {
            if (tbSteamDir.Text == "Enter your steam directory") {
                tbSteamDir.Clear();
                tbSteamDir.ForeColor = Color.Gray;
            }
            else {
                tbSteamDir.ForeColor = Color.Black;
            }
        }

        private void tbSteamDir_Leave(object sender, EventArgs e) {
            if (tbSteamDir.Text == "") {
                tbSteamDir.Text = "Enter your steam directory";
                tbSteamDir.ForeColor = Color.Gray;
            }
            else {
                tbSteamDir.ForeColor = Color.Black;
            }
        }

        private void tbSteamDir_TextChanged(object sender, EventArgs e) {
            if (tbSteamDir.Text == "Enter your steam directory") {
                tbSteamDir.ForeColor = Color.Gray;
            }
            else {
                tbSteamDir.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ListViewItem lvi = new ListViewItem("crap");

            lvi.ImageIndex = 0;

            listFiles.Items.Add(lvi);
            listFiles.LargeImageList = imageList1;
        }

        private void listFiles_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listFiles_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (var file in files) {
                int extensionIndex = file.LastIndexOf('.');

                if (extensionIndex == -1) {
                    MessageBox.Show("Selected file " + file + " has no extension");
                    continue;
                }

                string fileExtension = file.Substring(extensionIndex);

                if (fileExtension == ".cfg" ||fileExtension == ".txt") {

                    using (System.IO.StreamReader sr = new System.IO.StreamReader(file)) {
                        string fileName = file.Substring(file.LastIndexOf('\\') + 1);

                        ConfigFile configFile = new ConfigFile();
                        configFile.fileName = fileName;
                        configFile.fileContent = sr.ReadToEnd();
                        configFile.fileExtension = fileExtension;

                        _cfgFiles.Add(configFile);

                        ListViewItem lvi = new ListViewItem(fileName);
                        lvi.ImageIndex = 0;
                        listFiles.Items.Add(lvi);
                        listFiles.LargeImageList = imageList1;
                    }
                }
                else {
                    MessageBox.Show("Format \"" + fileExtension + "\" not supported");
                    continue;
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
        }

        private void btnInstall_Click(object sender, EventArgs e) {
            if (tbSteamDir.Text == "" || tbSteamDir.Text == "Enter your steam directory") {
                MessageBox.Show("Please enter your steam directory");
                return;
            }

            string[] directories = System.IO.Directory.GetDirectories(tbSteamDir.Text + "\\userdata");

            foreach (var directory in directories) {
                foreach (var cfg in _cfgFiles) {
                    try {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(directory + "\\730\\local\\cfg" + "\\" + cfg.fileName)) {
                            sw.Write(cfg.fileContent);
                        }
                    }
                    catch (Exception) {
                    }
                }   
            }

            MessageBox.Show("Configs has been successfully installed on all your accounts");
        }
    }
}
