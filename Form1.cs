using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.IO;
namespace MoveDefaultUserFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!IsAdministrator())
            {
                System.Windows.Forms.MessageBox.Show("Please make sure you run as administrator!\n\nIt is required because this program modifies registry.",
                    "Error", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

        FolderBrowserDialog f = new FolderBrowserDialog();
        private void LocationBrowseButton_Click(object sender, EventArgs e)
        {
            f.RootFolder = Environment.SpecialFolder.MyComputer;
            if (!(f.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)) {
           
            LocationTextBox.Text = f.SelectedPath;
            string[] lengthHelper = (LocationTextBox.Text + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { LocationTextBox.Text = LocationTextBox.Text + '\\'; }
            
            ChangeLocation(GroupBox, f.SelectedPath);
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                System.Windows.Forms.MessageBox.Show("No administrator priveliges!\nPlease run as administrator!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MoveFolders();
        }

        private bool selected = true;
        private void RadioButton1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                UncheckAll(GroupBox);
                HeightChange();
                CheckBoxPadding(GroupBox);
                ToggleVisibility(GroupBox);
                
                selected = !selected;
            }
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                UncheckAll(GroupBox);
                HeightChange();      
                CheckBoxPadding(GroupBox);
                ToggleVisibility(GroupBox);       
                selected = !selected;
            }
        }

        private void HeightChange()
        {
            if (YesRadioButton.Checked)
            {
                this.Height -= 150;
                GroupBox.Height -= 150;
                moveButton.Location = new Point(moveButton.Location.X, moveButton.Location.Y - 150);
                progressBar.Location = new Point(progressBar.Location.X, progressBar.Location.Y - 150);
                infoButton.Location = new Point(infoButton.Location.X, infoButton.Location.Y - 150);
            }
            if (NoRadioButton.Checked)
            {
                this.Height += 150;
                GroupBox.Height += 150;
                moveButton.Location = new Point(moveButton.Location.X, moveButton.Location.Y + 150);
                progressBar.Location =  new Point(progressBar.Location.X, progressBar.Location.Y + 150);
                infoButton.Location = new Point(infoButton.Location.X, infoButton.Location.Y + 150);
            }
        }

        private void ChangeLocation(Control ctrl, string location)
        {
            TextBox textBox = ctrl as TextBox;
            if (textBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    ChangeLocation(child, location);
                }
            }
            else
            {
                string[] directory = textBox.Text.Split('\\');
                string[] lengthHelper = (location + '\\').Split('\\');
                if (!(lengthHelper[1].Length == 0)) { textBox.Text = location + '\\' + directory[directory.Length - 1]; ; }
                else { textBox.Text = location + directory[directory.Length - 1]; }
            }
        }

        private void CheckAll(Control ctrl)
        {
            CheckBox checkBox = ctrl as CheckBox;
            if (checkBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    CheckAll(child);
                }
            }
            else
            {
                if (checkBox.Name != "selectAllCheckBox")
                {
                    checkBox.Checked = true;
                }
            }
        }

        private void UncheckAll(Control ctrl)
        {
            CheckBox checkBox = ctrl as CheckBox;
            if (checkBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    UncheckAll(child);
                }
            }
            else
            {
                    checkBox.Checked = false;
            }
        }

        private void ToggleVisibility(Control ctrl)
        {
            if (selected)
            {
                TextBox textbox = ctrl as TextBox;
                if (textbox == null)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        ToggleVisibility(child);
                    }
                }
                else
                {
                    textbox.Visible = true;
                }

                Button button = ctrl as Button;
                if (button == null)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        ToggleVisibility(child);
                    }
                }
                else
                {
                    button.Visible = true;
                }
            }

            else
            {

                TextBox textbox = ctrl as TextBox;
                if (textbox == null)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        ToggleVisibility(child);
                    }
                }
                else
                {
                    textbox.Enabled = false;
                    textbox.Visible = false;
                }

                Button button = ctrl as Button;
                if (button == null)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        ToggleVisibility(child);
                    }
                }
                else
                {
                    button.Visible = false;
                    button.Enabled = false;
                }
            }
        }

        private void CheckBoxPadding(Control ctrl)
        {
            CheckBox checkBox = ctrl as CheckBox;
            if (checkBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    CheckBoxPadding(child);
                }
            }
            else
            {
                if (checkBox.Name != "selectAllCheckBox") { 
                    if (checkBox.Name.ToString() != "Desktop" && checkBox.Name.ToString() != "Links")
                    {
                        if (selected)
                        {
                            checkBox.Location = new Point(checkBox.Location.X, (checkBox.Location.Y * 2 - 19)); 
                        }
                        else
                        {
                            checkBox.Location = new Point(checkBox.Location.X, (checkBox.Location.Y / 2 + 10));
                        }
                    }
                }
            }
        }
 
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.SelectionStart = textbox.Text.Length;
            textbox.SelectionLength = 0;
        }

        string alert = "";
        private string MoveInfo(Control ctrl)
        {
            CheckBox checkBox = ctrl as CheckBox;
            if (checkBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    MoveInfo(child);
                }
            }
            else
            {
                if (checkBox.Checked)
                {
                    if (!(checkBox == selectAllCheckBox)) {
                    alert += checkBox.Name.ToString() + " being moved to " + GetMoveLocation(checkBox.Name.ToString()) + "\n";
                    }
                }
            }
            return alert + "\n\nNote: Folder names will be in your system's language.";
        }
        private string GetMoveLocation(string folderName)
        {
            string path = "";
            if (YesRadioButton.Checked)
            {
                if (!LocationTextBox.Text.EndsWith("\\"))
                {
                    return (LocationTextBox.Text + "\\" + folderName);
                }
                else return (LocationTextBox.Text + folderName);

            }
            else
            {
                if (folderName == "Desktop") { path = Desktop_TextBox.Text; }
                if (folderName == "Downloads") { path = Downloads_TextBox.Text; }
                if (folderName == "Documents") { path = Documents_TextBox.Text; }
                if (folderName == "Pictures") { path = Pictures_TextBox.Text; }
                if (folderName == "Videos") { path = Videos_TextBox.Text; }
                if (folderName == "Music") { path = Music_TextBox.Text; }
                if (folderName == "Links") { path = Links_TextBox.Text; }
                if (folderName == "Favorites") { path = Favorites_TextBox.Text; }
                if (folderName == "Searches") { path = Searches_TextBox.Text; }
                if (folderName == "SavedGames") { path = SavedGames_TextBox.Text; }
                if (folderName == "Contacts") { path = Contacts_TextBox.Text; }
                if (folderName == "Objects") { path = Objects_TextBox.Text; }
            }
            if (path.EndsWith("\\"))
            {
                return path.Remove(path.Length - 1);
            }
            else return path;

        }
        //Move methods
        private void MoveFolders()
        {
            alert = "";

            if (selectionCounter == 0) { System.Windows.Forms.MessageBox.Show("Select something to move!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            progressBar.Value = 0;
            double helper = 100 / selectionCounter; 
            int percent = (int)Math.Round(helper);

            DialogResult dialogResult = MessageBox.Show("Moving Folders\n\n" + MoveInfo(GroupBox), "Are you sure?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (YesRadioButton.Checked)
            {
                if (Desktop.Checked) { MoveDirectory("Desktop", -183, "imageres.dll", "", -21769, "shell32.dll"); progressBar.Value += percent; }
                if (Downloads.Checked) { MoveDirectory("{374DE290-123F-4565-9164-39C4925E467B}", -184, "imageres.dll", "",-21798, "shell32.dll"); progressBar.Value += percent; }
                if (Documents.Checked) { MoveDirectory("Personal", -112, "imageres.dll", "", -21770, "shell32.dll"); progressBar.Value += percent; }
                if (Pictures.Checked) { MoveDirectory("My Pictures", -113, "imageres.dll", "", -21779, "shell32.dll"); progressBar.Value += percent; }
                if (Videos.Checked) { MoveDirectory("My Video", -189, "imageres.dll", "", -21791, "shell32.dll"); progressBar.Value += percent; }
                if (Music.Checked) { MoveDirectory("My Music", -108, "imageres.dll", "",-21790, "shell32.dll"); progressBar.Value += percent; }
                if (Links.Checked) { MoveDirectory("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}", -185, "imageres.dll", "", -21810, "shell32.dll"); progressBar.Value += percent; }
                if (Favorites.Checked) { MoveDirectory("Favorites", -173, "shell32.dll", "",-21796, "shell32.dll"); progressBar.Value += percent; }
                if (Searches.Checked) { MoveDirectory("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}", -18, "imageres.dll", "", -9031, "shell32.dll"); progressBar.Value += percent; }
                if (SavedGames.Checked) { MoveDirectory("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}", -186, "imageres.dll", "", -21814, "shell32.dll"); progressBar.Value += percent; }
                if (Contacts.Checked) { MoveDirectory("{56784854-C6CB-462B-8169-88E350ACB882}", -181, "imageres.dll", "", -10100, "wab32res.dll"); progressBar.Value += percent; }
                if (Objects.Checked) { MoveDirectory("{31C0DD25-9439-4F12-BF41-7FF4EDA38722}", -198, "imageres.dll", "", -21825, "windows.storage.dll"); progressBar.Value += percent; }
                if (error) progressBar.Value = 0;
                else { progressBar.Value = 100; System.Windows.Forms.MessageBox.Show("Successfully moved " + selectionCounter + " folders!"); }
            }
            else
            {
                if (Desktop.Checked) { MoveDirectory("Desktop", -183, "imageres.dll", Desktop_TextBox.Text, -21769, "shell32.dll"); progressBar.Value += percent; }
                if (Downloads.Checked) { MoveDirectory("{374DE290-123F-4565-9164-39C4925E467B}", -184, "imageres.dll", Downloads_TextBox.Text, -21798, "shell32.dll"); progressBar.Value += percent; }
                if (Documents.Checked) { MoveDirectory("Personal", -112, "imageres.dll", Documents_TextBox.Text, -21770, "shell32.dll"); progressBar.Value += percent; }
                if (Pictures.Checked) { MoveDirectory("My Pictures", -113, "imageres.dll", Pictures_TextBox.Text, -21779, "shell32.dll"); progressBar.Value += percent; }
                if (Videos.Checked) { MoveDirectory("My Video", -189, "imageres.dll", Videos_TextBox.Text, -21791, "shell32.dll"); progressBar.Value += percent; }
                if (Music.Checked) { MoveDirectory("My Music", -108, "imageres.dll", Music_TextBox.Text, -21790, "shell32.dll"); progressBar.Value += percent; }
                if (Links.Checked) { MoveDirectory("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}", -185, "imageres.dll", Links_TextBox.Text, -21810, "shell32.dll"); progressBar.Value += percent; }
                if (Favorites.Checked) { MoveDirectory("Favorites", -173, "shell32.dll", Favorites_TextBox.Text, -21796, "shell32.dll"); progressBar.Value += percent; }
                if (Searches.Checked) { MoveDirectory("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}", -18, "imageres.dll", Searches_TextBox.Text, -9031, "shell32.dll"); progressBar.Value += percent; }
                if (SavedGames.Checked) { MoveDirectory("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}", -186, "imageres.dll", SavedGames_TextBox.Text, -21814, "shell32.dll"); progressBar.Value += percent; }
                if (Contacts.Checked) { MoveDirectory("{56784854-C6CB-462B-8169-88E350ACB882}", -181, "imageres.dll", Contacts_TextBox.Text, -10100, "wab32res.dll"); progressBar.Value += percent; }
                if (Objects.Checked) { MoveDirectory("{31C0DD25-9439-4F12-BF41-7FF4EDA38722}", -198, "imageres.dll", Objects_TextBox.Text, -21825, "windows.storage.dll"); progressBar.Value += percent; }
                if (error) progressBar.Value = 0;
                else { progressBar.Value = 100; System.Windows.Forms.MessageBox.Show("Successfully moved " + selectionCounter + " folders!"); }
            }
        }

        private void CopyFolder(string sourceFolder, string destFolder)
        {
            if (Directory.Exists(sourceFolder))
            {
                string command1 = "/c xcopy " + '"' + sourceFolder + '"' + '"' + destFolder + '"' + " /E /I";

                string arguments = command1;
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", arguments);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process.Start(procStartInfo);

            }
        }
        private bool error;
        private void MoveDirectory(string registryName, int iconNumber, string dllName, string individualLocation, int localizedName, string localizedDllName)
        {
            if (LocationTextBox.Text.Length < 2) { System.Windows.Forms.MessageBox.Show("Please select a valid location!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); error = true; return; }
            if (NoRadioButton.Checked) { if (individualLocation.Length < 3) { System.Windows.Forms.MessageBox.Show("Please select a valid location!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); error = true; return; } }


            error = false;
            string location="",sourceDir = "", folderName = GetFolderName(registryName);
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders\\");


            if (key.GetValueNames().Contains(registryName) == false){
                sourceDir = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + folderName;
            }
            else { sourceDir = key.GetValue(registryName).ToString(); }

            string[] split = sourceDir.Split('\\');
            if (NoRadioButton.Checked)
            {
                if (NoRadioButton.Checked)
                {
                    if (individualLocation.EndsWith("\\"))
                    {
                        location = individualLocation.Remove(individualLocation.Length - 1);
                    }
                    else location = individualLocation;
                }
            }
            else {
                if (!LocationTextBox.Text.EndsWith("\\"))
                {
                    location = LocationTextBox.Text + "\\" + split[split.Length - 1];
                }
                else location = LocationTextBox.Text + split[split.Length - 1];
            }

            if (sourceDir == location) { System.Windows.Forms.MessageBox.Show("The new folder must be different from the current folder!\n(" + split[split.Length - 1] + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); error = true; return; }
            else
            {
                if (!Directory.Exists(location)) { Directory.CreateDirectory(location); }

                key.SetValue(registryName, location);
                key.Close();

                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders\\");

                if (key.GetValueNames().Contains(registryName) == false)
                {
                    sourceDir = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + folderName;
                }
                else { sourceDir = key.GetValue(registryName).ToString(); }
            }

            split = sourceDir.Split('\\');
            if (NoRadioButton.Checked)
            {
                if (individualLocation.EndsWith("\\"))
                {
                    location = individualLocation.Remove(individualLocation.Length - 1);
                }
                else location = individualLocation;
            }
            else
            {
                if (!LocationTextBox.Text.EndsWith("\\"))
                {
                    location = LocationTextBox.Text + "\\" + split[split.Length - 1];
                }
                else location = LocationTextBox.Text + split[split.Length - 1];
            }

            if (sourceDir == location) { System.Windows.Forms.MessageBox.Show("The new folder must be different from the current folder!\n(" + split[split.Length - 1] + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); error = true; return; }
            else
            {
                key.SetValue(registryName, location);
                key.Close();

                RemoveDesktopIni(location);
                if (localizedDllName == "wab32res.dll")
                {
                    string[] lines = {"[.ShellClassInfo]",
                    "IconResource=%SystemRoot%\\system32\\" + dllName + "," + iconNumber,
                    "LocalizedResourceName=@%CommonProgramFiles%\\system\\" + localizedDllName + "," + localizedName};
                    File.WriteAllLines(location + @"\desktop.ini", lines);
                    File.WriteAllLines(location + @"\desktop.ini", lines);
                }
                else
                { 
                string[] lines = {"[.ShellClassInfo]",
                    "IconResource=%SystemRoot%\\system32\\" + dllName + "," + iconNumber,
                    "LocalizedResourceName=@%SystemRoot%\\system32\\" + localizedDllName + "," + localizedName};
                    File.WriteAllLines(location + @"\desktop.ini", lines);
                }
                
                SetAttrib(location);
                CopyFolder(sourceDir, location);
                DeleteFolder(sourceDir);
            }
        }

       private string GetFolderName(string registryName)
        {
            string folderName = "";

            if (registryName == "{374DE290-123F-4565-9164-39C4925E467B}") { folderName = "Downloads"; }
            else if (registryName == "Personal") { folderName = "Documents"; }
            else if (registryName == "My Pictures") { folderName = "Pictures"; }
            else if (registryName == "My Video") { folderName = "Videos"; }
            else if (registryName == "My Music") { folderName = "Music"; }
            else if (registryName == "{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}") { folderName = "Links"; }
            else if (registryName == "{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}") { folderName = "Searches"; }
            else if (registryName == "{56784854-C6CB-462B-8169-88E350ACB882}") { folderName = "Contacts"; }
            else if (registryName == "{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}") { folderName = "Saved Games"; }
            else if (registryName == "{31C0DD25-9439-4F12-BF41-7FF4EDA38722}") { folderName = "3D Objects"; }
            else { folderName = registryName; }

            return folderName;
        }
        private void SetAttrib(string location)
        {
            string command1 = "/c attrib +s +r +h  " + '"' + location + @"\desktop.ini" + '"';
            string command2 = "/c attrib +r " + '"' + location + '"';

            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", command1);
            //For some reason, if I have them in the same attribute, the folder does not get the read only attribute
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process.Start(procStartInfo);

            procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", command2);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process.Start(procStartInfo);
        }

        private void RemoveDesktopIni(string location)
        {
            location = location.Remove(location.Length - 1);

            string command1 = "/c attrib -s -r -h  " + '"' + location + @"\desktop.ini" + '"';
            string command2 = "/c del -s -r -h  " + '"' + location + @"\desktop.ini" + '"';

            string arguments = command1 + "&&" + command2;
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process.Start(procStartInfo);
        }

        private void DeleteFolder(string location)
        {
            string command1 = "/c rmdir " + '"' + location + '"' + " /s /Q";

            string arguments = command1;
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process.Start(procStartInfo);
        }

        //Button Clicks
        private void DesktopButton_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Desktop_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("Desktop"); }
            else { Desktop_TextBox.Text = f.SelectedPath + GetFolderName("Desktop"); }
        }

        private void DownloadsButton_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Downloads_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("{374DE290-123F-4565-9164-39C4925E467B}"); }
            else { Downloads_TextBox.Text = f.SelectedPath + GetFolderName("{374DE290-123F-4565-9164-39C4925E467B}"); }
        }

        private void DocumentsButton_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Documents_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("Personal"); }
            else { Documents_TextBox.Text = f.SelectedPath + GetFolderName("Personal"); }
        }

        private void PicturesButton_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Pictures_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("My Pictures"); }
            else { Pictures_TextBox.Text = f.SelectedPath + GetFolderName("My Pictures"); }
        }

        private void VideosButton_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Videos_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("My Video"); }
            else { Videos_TextBox.Text = f.SelectedPath + GetFolderName("My Video"); }
        }

        private void MusicButton_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Music_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("My Music"); }
            else { Music_TextBox.Text = f.SelectedPath + GetFolderName("My Music"); }
        }

        private void Links_Button_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Links_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}"); }
            else { Links_TextBox.Text = f.SelectedPath + GetFolderName("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}"); }
        }

        private void Favorites_Button_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Favorites_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("Favorites"); }
            else { Favorites_TextBox.Text = f.SelectedPath + GetFolderName("Favorites"); }
        }

        private void Searches_Button_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Searches_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}"); }
            else { Searches_TextBox.Text = f.SelectedPath + GetFolderName("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}"); }
        }

        private void SavedGames_Button_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { SavedGames_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}"); }
            else { SavedGames_TextBox.Text = f.SelectedPath + GetFolderName("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}"); }
        }

        private void Contacts_Button_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Contacts_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("{56784854-C6CB-462B-8169-88E350ACB882}"); }
            else { Contacts_TextBox.Text = f.SelectedPath + GetFolderName("{56784854-C6CB-462B-8169-88E350ACB882}"); }
        }

        private void Objects_Button_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            string[] lengthHelper = (f.SelectedPath + '\\').Split('\\');
            if (!(lengthHelper[1].Length == 0)) { Objects_TextBox.Text = f.SelectedPath + '\\' + GetFolderName("{31C0DD25-9439-4F12-BF41-7FF4EDA38722}"); }
            else { Objects_TextBox.Text = f.SelectedPath + GetFolderName("{31C0DD25-9439-4F12-BF41-7FF4EDA38722}"); }
        }

        //Checkbox changes
        private int selectionCounter = 0;
        private void Desktop_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Desktop_TextBox.Enabled = checkbox.Checked;
                Desktop_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Downloads_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Downloads_TextBox.Enabled = checkbox.Checked;
                Downloads_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Documents_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Documents_TextBox.Enabled = checkbox.Checked;
                Documents_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Pictures_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Pictures_TextBox.Enabled = checkbox.Checked;
                Pictures_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Videos_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Videos_TextBox.Enabled = checkbox.Checked;
                Videos_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Music_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Music_TextBox.Enabled = checkbox.Checked;
                Music_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }


        private void Links_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Links_TextBox.Enabled = checkbox.Checked;
                Links_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Favorites_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Favorites_TextBox.Enabled = checkbox.Checked;
                Favorites_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Searches_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Searches_TextBox.Enabled = checkbox.Checked;
                Searches_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void SavedGames_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                SavedGames_TextBox.Enabled = checkbox.Checked;
                SavedGames_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Contacts_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Contacts_TextBox.Enabled = checkbox.Checked;
                Contacts_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void Objects_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (!selected)
            {
                Objects_TextBox.Enabled = checkbox.Checked;
                Objects_Button.Enabled = checkbox.Checked;
            }
            if (checkbox.Checked == false) { selectAllCheckBox.Checked = false; selectionCounter--; } else selectionCounter++;
            if (selectionCounter == 12) selectAllCheckBox.Checked = true;
        }

        private void SelectAllCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) CheckAll(GroupBox);
            if (!checkBox.Checked) UncheckAll(GroupBox);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            var helpForm = new infoForm();
            helpForm.ShowDialog();
        }
    }

}
