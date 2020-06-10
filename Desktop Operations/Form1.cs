using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operations operations;
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectList(files_listBox,true);
            SelectList(directories_listBox,false);
        }
        public void SelectList(ListBox lst,bool type)
        {
            operations = new Operations();
            if (type)
            {
                foreach (var item in operations.fileNames)
                {
                    lst.Items.Add(operations.parseName(item));
                }
            }
            else
            {
                foreach (var item in operations.directorieNames)
                {
                    lst.Items.Add(operations.parseName(item));
                }
            }
        }
        private void Refresh_BTN_Click(object sender, EventArgs e)
        {
            files_listBox.Items.Clear();
            directories_listBox.Items.Clear();

            SelectList(files_listBox, true);
            SelectList(directories_listBox, false);

        }


        private void Open_BTN_Click(object sender, EventArgs e)
        {

            if(files_listBox.SelectedIndex>0 || directories_listBox.SelectedIndex > 0)
            {
                operations = new Operations();
                if (tabControl1.SelectedIndex == 0)
                    operations.Open(operations.fileNames[files_listBox.SelectedIndex], true);
                else
                    operations.Open(operations.directorieNames[directories_listBox.SelectedIndex], false);

                refresh_BTN.PerformClick();
            }
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            if (files_listBox.SelectedIndex > 0 || directories_listBox.SelectedIndex > 0)
            {
                operations = new Operations();
                if (tabControl1.SelectedIndex == 0)
                {
                    operations.Delete(operations.fileNames[files_listBox.SelectedIndex], true);
                    MessageBox.Show("File Deleted !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    operations.Delete(operations.directorieNames[directories_listBox.SelectedIndex], false);
                    MessageBox.Show("Directory Deleted !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                refresh_BTN.PerformClick();
            }
        }

        private void Buttons_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Trebuchet MS", 15.75f, FontStyle.Bold);
        }

        private void Buttons_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Trebuchet MS", 15.75f, FontStyle.Regular);
        }
        // Thanks for watching :)
    }
}
