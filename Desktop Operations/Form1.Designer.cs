namespace Desktop_Operations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.files_listBox = new System.Windows.Forms.ListBox();
            this.open_BTN = new System.Windows.Forms.Button();
            this.refresh_BTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.directories_listBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.files_listBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.directories_listBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Directories";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Delete_BTN);
            this.panel1.Controls.Add(this.refresh_BTN);
            this.panel1.Controls.Add(this.open_BTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 84);
            this.panel1.TabIndex = 1;
            // 
            // files_listBox
            // 
            this.files_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.files_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.files_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files_listBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.files_listBox.ForeColor = System.Drawing.Color.Aqua;
            this.files_listBox.FormattingEnabled = true;
            this.files_listBox.ItemHeight = 21;
            this.files_listBox.Location = new System.Drawing.Point(3, 3);
            this.files_listBox.Name = "files_listBox";
            this.files_listBox.Size = new System.Drawing.Size(349, 247);
            this.files_listBox.TabIndex = 0;
            // 
            // open_BTN
            // 
            this.open_BTN.BackColor = System.Drawing.Color.Transparent;
            this.open_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.open_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.open_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.open_BTN.ForeColor = System.Drawing.Color.Lime;
            this.open_BTN.Location = new System.Drawing.Point(9, 23);
            this.open_BTN.Name = "open_BTN";
            this.open_BTN.Size = new System.Drawing.Size(102, 43);
            this.open_BTN.TabIndex = 1;
            this.open_BTN.Text = "Open";
            this.open_BTN.UseVisualStyleBackColor = false;
            this.open_BTN.Click += new System.EventHandler(this.Open_BTN_Click);
            this.open_BTN.MouseLeave += new System.EventHandler(this.Buttons_Leave);
            this.open_BTN.MouseHover += new System.EventHandler(this.Buttons_Hover);
            // 
            // refresh_BTN
            // 
            this.refresh_BTN.BackColor = System.Drawing.Color.Transparent;
            this.refresh_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refresh_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refresh_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refresh_BTN.ForeColor = System.Drawing.Color.Yellow;
            this.refresh_BTN.Location = new System.Drawing.Point(130, 23);
            this.refresh_BTN.Name = "refresh_BTN";
            this.refresh_BTN.Size = new System.Drawing.Size(102, 43);
            this.refresh_BTN.TabIndex = 2;
            this.refresh_BTN.Text = "Refresh";
            this.refresh_BTN.UseVisualStyleBackColor = false;
            this.refresh_BTN.Click += new System.EventHandler(this.Refresh_BTN_Click);
            this.refresh_BTN.MouseLeave += new System.EventHandler(this.Buttons_Leave);
            this.refresh_BTN.MouseHover += new System.EventHandler(this.Buttons_Hover);
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Delete_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Delete_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Delete_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_BTN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete_BTN.ForeColor = System.Drawing.Color.Red;
            this.Delete_BTN.Location = new System.Drawing.Point(249, 23);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(102, 43);
            this.Delete_BTN.TabIndex = 3;
            this.Delete_BTN.Text = "Delete";
            this.Delete_BTN.UseVisualStyleBackColor = false;
            this.Delete_BTN.Click += new System.EventHandler(this.Delete_BTN_Click);
            this.Delete_BTN.MouseLeave += new System.EventHandler(this.Buttons_Leave);
            this.Delete_BTN.MouseHover += new System.EventHandler(this.Buttons_Hover);
            // 
            // directories_listBox
            // 
            this.directories_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.directories_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directories_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directories_listBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.directories_listBox.ForeColor = System.Drawing.Color.Aqua;
            this.directories_listBox.FormattingEnabled = true;
            this.directories_listBox.ItemHeight = 21;
            this.directories_listBox.Location = new System.Drawing.Point(3, 3);
            this.directories_listBox.Name = "directories_listBox";
            this.directories_listBox.Size = new System.Drawing.Size(349, 247);
            this.directories_listBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(363, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox files_listBox;
        private System.Windows.Forms.Button open_BTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button refresh_BTN;
        private System.Windows.Forms.ListBox directories_listBox;
    }
}

