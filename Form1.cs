using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.IO;
//TODO: button (maybe progression bar)
//TODO: Icon
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


        private void LocationBrowseButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            LocationTextBox.Text = LocationBrowserDialog.SelectedPath;
            ChangeLocation(GroupBox, LocationBrowserDialog.SelectedPath);
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                System.Windows.Forms.MessageBox.Show("No administrator priveliges!\nPlease run as administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                textBox.Text = location + "\\" + directory[directory.Length-2];
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
        //Button Clicks
        private void DesktopButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Desktop_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Desktop";
        }

        private void DownloadsButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Downloads_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Downloads";
        }

        private void DocumentsButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Documents_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Documents";
        }

        private void PicturesButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Pictures_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Pictures";
        }

        private void VideosButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Videos_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Videos";
        }

        private void MusicButton_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Music_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Music";
        }

        private void Links_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Links_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Links";
        }

        private void Favorites_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Favorites_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Favorites";
        }

        private void Searches_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Searches_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Searches";
        }

        private void SavedGames_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            SavedGames_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Saved Games";
        }

        private void Contacts_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Contacts_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\Contacts";
        }

        private void Objects_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            Objects_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\3D Objects";
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

        //Move methods
        //TODO: Delete old folders
        public static void CopyFolder(string sourceFolder, string destFolder)
        {
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                
                string name = Path.GetFileName(file);
                if(name != "desktop.ini")
                { 
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
                }
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
               
            }
        }
        //Todo: fix documents
        //check if right side works
        private void MoveFolders()
        {
            if (Desktop.Checked) MoveDirectory("Desktop",-183);
            if (Downloads.Checked) MoveDirectory("{374DE290-123F-4565-9164-39C4925E467B}",-184);
            if (Documents.Checked) MoveDirectory("Personal", -112);
            if (Pictures.Checked) MoveDirectory("My Pictures", -113);
            if (Videos.Checked) MoveDirectory("My Video", -189);
            if (Music.Checked) MoveDirectory("My Music", -108);
            if (Links.Checked) MoveDirectory("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}", -189);
            if (Favorites.Checked) MoveDirectory("Favorites", -173);
            if (Searches.Checked) MoveDirectory("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}", -18);
            if (SavedGames.Checked) MoveDirectory("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}", -186);
            if (Contacts.Checked) MoveDirectory("{56784854-C6CB-462B-8169-88E350ACB882}", -181);
            if (Objects.Checked) MoveDirectory("{31C0DD25-9439-4F12-BF41-7FF4EDA38722}", -108);
        }

        private void MoveDirectory(string registryName, int iconNumber)
        {
            string location,sourceDir = "";
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders\\");
            if(key == null){
                string folderName="";
                if (registryName == "{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}") { folderName = "\\Links"; }
                if (registryName == "{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}") { folderName = "\\Searches"; }
                if (registryName == "{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}") { folderName = "\\Saved Games"; }
                if (registryName == "{56784854-C6CB-462B-8169-88E350ACB882}") { folderName = "\\Contacts"; }
                if (registryName == "{31C0DD25-9439-4F12-BF41-7FF4EDA38722}") { folderName = "\\3D Objects"; }
                else { folderName = registryName; }
                sourceDir = System.Environment.GetEnvironmentVariable("USERPROFILE") + folderName;
                System.Windows.Forms.MessageBox.Show(System.Environment.GetEnvironmentVariable("USERPROFILE") + folderName);
            }

            sourceDir = key.GetValue(registryName).ToString();
            string[] split = sourceDir.Split('\\');

            location = LocationTextBox.Text + '\\' + split[split.Length - 1];
            
            if (split.Length == 2) {location = LocationTextBox.Text + split[split.Length - 1]; }
            System.Windows.Forms.MessageBox.Show(split.Length.ToString()) ;


            if (!Directory.Exists(location)) { Directory.CreateDirectory(location); }

            key.SetValue(registryName, location);
            key.Close();
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders\\");
            key.SetValue(registryName, location);
            key.Close();

            if (File.Exists(location + '\\' + "desktop.ini"))
            {
                RemoveAttrib(location);
                File.Delete(location + '\\' + "desktop.ini");
            }
            string[] lines = {"[.ShellClassInfo]",
                "IconResource=%SystemRoot%\\system32\\imageres.dll," + iconNumber,
                "LocalizedResourceName=" + split[split.Length-1]};
            File.WriteAllLines(location + @"\desktop.ini", lines);
            SetAttrib(location);
            CopyFolder(sourceDir, location);

            DirectoryInfo directory = new DirectoryInfo(sourceDir);
            directory.GetFiles().ToList().ForEach(f => f.Delete());
        }

        private void SetAttrib(string location)
        {
            string command1 = "attrib +r +s +h  " + '"' + location + @"\desktop.ini" + '"';
            string command2 = "attrib +r " + '"' + location + '"';

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            
            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(command1);
                    sw.WriteLine(command2);
                }
            }
        }

        private void RemoveAttrib(string location)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "attrib -r -s -h  " + '"' + location + @"\desktop.ini" + '"'; ;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
