using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
//TODO: top location changes it for all
//TODO: button (maybe progression bar)
//TODO: Icon
namespace MoveDefaultUserFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!IsAdministrator()) System.Windows.Forms.MessageBox.Show("Please make sure you run as administrator!\n\nIt is required because this program edits registry.");
        }

        private static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            LocationTextBox.Text = LocationBrowserDialog.SelectedPath;
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
            if (YesRadioButton.Checked) { this.Height -= 120; GroupBox.Height -= 120; }
            if (NoRadioButton.Checked) { this.Height += 120; GroupBox.Height += 120; }
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

        private int x, y;
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
                            x = Convert.ToInt32(checkBox.Location.X.ToString());
                            y = Convert.ToInt32(checkBox.Location.Y.ToString()) * 2 - 19;
                            checkBox.Location = new Point(x, y);
                        }
                        else
                        {
                            x = Convert.ToInt32(checkBox.Location.X.ToString());
                            y = Convert.ToInt32(checkBox.Location.Y.ToString()) / 2 + 10;
                            checkBox.Location = new Point(x, y);
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

    }


}
