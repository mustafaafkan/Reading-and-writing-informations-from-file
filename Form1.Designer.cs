namespace astproject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachNameToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.searchNumToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.tnumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editingToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStrip,
            this.saveToolStrip,
            this.saveAsToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.Size = new System.Drawing.Size(114, 22);
            this.openToolStrip.Text = "&Open";
            this.openToolStrip.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(114, 22);
            this.saveToolStrip.Text = "&Save";
            this.saveToolStrip.Click += new System.EventHandler(this.saveToolStrip_Click);
            // 
            // saveAsToolStrip
            // 
            this.saveAsToolStrip.Name = "saveAsToolStrip";
            this.saveAsToolStrip.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStrip.Text = "Save &As";
            this.saveAsToolStrip.Click += new System.EventHandler(this.saveAsToolStrip_Click);
            // 
            // editingToolStripMenuItem
            // 
            this.editingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStrip,
            this.editToolStrip});
            this.editingToolStripMenuItem.Name = "editingToolStripMenuItem";
            this.editingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editingToolStripMenuItem.Text = "Editing";
            // 
            // addToolStrip
            // 
            this.addToolStrip.Name = "addToolStrip";
            this.addToolStrip.Size = new System.Drawing.Size(96, 22);
            this.addToolStrip.Text = "&Add";
            this.addToolStrip.Click += new System.EventHandler(this.addToolStrip_Click);
            // 
            // editToolStrip
            // 
            this.editToolStrip.Name = "editToolStrip";
            this.editToolStrip.Size = new System.Drawing.Size(96, 22);
            this.editToolStrip.Text = "&Edit";
            this.editToolStrip.Click += new System.EventHandler(this.editToolStrip_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seachNameToolStrip,
            this.searchNumToolStrip});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // seachNameToolStrip
            // 
            this.seachNameToolStrip.Name = "seachNameToolStrip";
            this.seachNameToolStrip.Size = new System.Drawing.Size(215, 22);
            this.seachNameToolStrip.Text = "Seach &Name";
            this.seachNameToolStrip.Click += new System.EventHandler(this.seachNameToolStrip_Click);
            // 
            // searchNumToolStrip
            // 
            this.searchNumToolStrip.Name = "searchNumToolStrip";
            this.searchNumToolStrip.Size = new System.Drawing.Size(215, 22);
            this.searchNumToolStrip.Text = "Search &Telephone Number";
            this.searchNumToolStrip.Click += new System.EventHandler(this.searchNumToolStrip_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(124, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // tnumberBox
            // 
            this.tnumberBox.Location = new System.Drawing.Point(124, 107);
            this.tnumberBox.Name = "tnumberBox";
            this.tnumberBox.Size = new System.Drawing.Size(100, 20);
            this.tnumberBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telephone Numbers";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 153);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(224, 96);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(283, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnumberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem editingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStrip;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seachNameToolStrip;
        private System.Windows.Forms.ToolStripMenuItem searchNumToolStrip;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox tnumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

