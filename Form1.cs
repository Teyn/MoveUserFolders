using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace MoveDefaultUserFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!IsAdministrator()) System.Windows.Forms.MessageBox.Show("Please make sure you run as administrator!\n It is required because this program edits registry.");
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
            ChangeTextboxes(GroupBox);

        }
        int teszt = 13;
        private void ChangeTextboxes(Control ctrl)
        {
            
            TextBox textBox = ctrl as TextBox;
            if (textBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    ChangeTextboxes(child);
                }
            }
            else
            {
                // textBox.Text = LocationTextBox.Text = LocationBrowserDialog.SelectedPath + "\\" + getName("");
                teszt--;
                textBox.Text = teszt.ToString();
                
            }
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
                if (checkBox.Name.ToString() != "left1" && checkBox.Name.ToString() != "right1")
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

        string[,] names = new string[2, 6] { { "Desktop", "Downloads", "Documents", "Pictures", "Videos", "Music" }, { "Links", "Favorites", "Searches", "Saved Games", "Contacts", "3D Objects" } };
        
        private string getName(string name)
        {
            int helper1 = 0;
            string helper2 = name.Substring(name.Length - 1, 1);
            if (name.StartsWith("left")) { helper1 = 0; } else { helper1 = 1; }


            return names[helper1,int.Parse(helper2) - 1];
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.SelectionStart = textbox.Text.Length;
            textbox.SelectionLength = 0;
        }
        //Button Clicks
        private void Left1Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            left1_TextBox.Text = LocationBrowserDialog.SelectedPath + "\\" + getName("left1");
        }

        private void Left2Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            left2_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Left3Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            left3_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Left4Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            left4_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Left5Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            left5_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Left6Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            left6_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Right1_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            right1_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Right2_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            right2_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Right3_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            right3_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Right4_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            right4_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Right5_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            right5_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }

        private void Right6_Button_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            right6_TextBox.Text = LocationBrowserDialog.SelectedPath;
        }
      
        //Checkbox changes

        private void Left1_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                left1_TextBox.Enabled = checkbox.Checked;
                left1_Button.Enabled = checkbox.Checked;
            }
        }

        private void Left2_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                left2_TextBox.Enabled = checkbox.Checked;
                left2_Button.Enabled = checkbox.Checked;
            }
        }

        private void Left3_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                left3_TextBox.Enabled = checkbox.Checked;
                left3_Button.Enabled = checkbox.Checked;
            }
        }

        private void Left4_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                left4_TextBox.Enabled = checkbox.Checked;
                left4_Button.Enabled = checkbox.Checked;
            }
        }

        private void Left5_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                left5_TextBox.Enabled = checkbox.Checked;
                left5_Button.Enabled = checkbox.Checked;
            }
        }

        private void Left6_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                left6_TextBox.Enabled = checkbox.Checked;
                left6_Button.Enabled = checkbox.Checked;
            }
        }


        private void Right1_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                right1_TextBox.Enabled = checkbox.Checked;
                right1_Button.Enabled = checkbox.Checked;
            }
        }

        private void Right2_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                right2_TextBox.Enabled = checkbox.Checked;
                right2_Button.Enabled = checkbox.Checked;
            }
        }

        private void Right3_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                right3_TextBox.Enabled = checkbox.Checked;
                right3_Button.Enabled = checkbox.Checked;
            }
        }

        private void Right4_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                right4_TextBox.Enabled = checkbox.Checked;
                right4_Button.Enabled = checkbox.Checked;
            }
        }

        private void Right5_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                right5_TextBox.Enabled = checkbox.Checked;
                right5_Button.Enabled = checkbox.Checked;
            }
        }

        private void Right6_CheckedChanged(object sender, EventArgs e)
        {
            if (!selected)
            {
                CheckBox checkbox = (CheckBox)sender;
                right6_TextBox.Enabled = checkbox.Checked;
                right6_Button.Enabled = checkbox.Checked;
            }
        }

    }


}
