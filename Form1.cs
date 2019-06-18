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
            
            if (!IsAdministrator()) System.Windows.Forms.MessageBox.Show("Please make sure you run as administrator!");
            
        }

        private static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocationBrowserDialog.ShowDialog();
            LocationTextBox.Text = LocationBrowserDialog.SelectedPath;

        }

        private void Documents_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Music_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool selected = true;
        private void RadioButton1_Click(object sender, EventArgs e)
        {
            if (!selected)
            { 
                UncheckAll(GroupBox);
                HeightChange();
                CheckBoxPadding(GroupBox);
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
                selected = !selected;
            }
        }

        private void HeightChange()
        {
            if (YesRadioButton.Checked) this.Height -= 50;
            if (NoRadioButton.Checked) this.Height += 50;
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

        private void Objects_Click(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

        }
    }


}
