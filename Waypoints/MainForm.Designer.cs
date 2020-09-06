namespace Waypoints
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTMToGPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPSToUTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEditor = new System.Windows.Forms.TabPage();
            this.wapoint_edit_groupBox = new System.Windows.Forms.GroupBox();
            this.addNew_button = new System.Windows.Forms.Button();
            this.lon_textBox = new System.Windows.Forms.TextBox();
            this.lat_textBox = new System.Windows.Forms.TextBox();
            this.tabPageSetup = new System.Windows.Forms.TabPage();
            this.waypointsdataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEditor.SuspendLayout();
            this.wapoint_edit_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waypointsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.configToolStripMenuItem.Text = "&Config";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTMToGPSToolStripMenuItem,
            this.gPSToUTMToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // uTMToGPSToolStripMenuItem
            // 
            this.uTMToGPSToolStripMenuItem.Name = "uTMToGPSToolStripMenuItem";
            this.uTMToGPSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uTMToGPSToolStripMenuItem.Text = "&UTM To GPS";
            this.uTMToGPSToolStripMenuItem.Click += new System.EventHandler(this.uTMToGPSToolStripMenuItem_Click);
            // 
            // gPSToUTMToolStripMenuItem
            // 
            this.gPSToUTMToolStripMenuItem.Name = "gPSToUTMToolStripMenuItem";
            this.gPSToUTMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gPSToUTMToolStripMenuItem.Text = "&GPS To UTM";
            this.gPSToUTMToolStripMenuItem.Click += new System.EventHandler(this.gPSToUTMToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPageEditor);
            this.tabControl1.Controls.Add(this.tabPageSetup);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(208, 570);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEditor
            // 
            this.tabPageEditor.Controls.Add(this.wapoint_edit_groupBox);
            this.tabPageEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditor.Name = "tabPageEditor";
            this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditor.Size = new System.Drawing.Size(200, 544);
            this.tabPageEditor.TabIndex = 0;
            this.tabPageEditor.Text = "Editor";
            this.tabPageEditor.UseVisualStyleBackColor = true;
            // 
            // wapoint_edit_groupBox
            // 
            this.wapoint_edit_groupBox.Controls.Add(this.addNew_button);
            this.wapoint_edit_groupBox.Controls.Add(this.lon_textBox);
            this.wapoint_edit_groupBox.Controls.Add(this.lat_textBox);
            this.wapoint_edit_groupBox.Location = new System.Drawing.Point(2, 5);
            this.wapoint_edit_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.wapoint_edit_groupBox.Name = "wapoint_edit_groupBox";
            this.wapoint_edit_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.wapoint_edit_groupBox.Size = new System.Drawing.Size(196, 107);
            this.wapoint_edit_groupBox.TabIndex = 3;
            this.wapoint_edit_groupBox.TabStop = false;
            this.wapoint_edit_groupBox.Text = "航点编辑";
            // 
            // addNew_button
            // 
            this.addNew_button.Location = new System.Drawing.Point(116, 79);
            this.addNew_button.Name = "addNew_button";
            this.addNew_button.Size = new System.Drawing.Size(75, 23);
            this.addNew_button.TabIndex = 5;
            this.addNew_button.Text = "添加";
            this.addNew_button.UseVisualStyleBackColor = true;
            this.addNew_button.Click += new System.EventHandler(this.addNew_button_Click);
            // 
            // lon_textBox
            // 
            this.lon_textBox.Location = new System.Drawing.Point(11, 41);
            this.lon_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.lon_textBox.Name = "lon_textBox";
            this.lon_textBox.Size = new System.Drawing.Size(68, 21);
            this.lon_textBox.TabIndex = 4;
            this.lon_textBox.Text = "lon";
            // 
            // lat_textBox
            // 
            this.lat_textBox.Location = new System.Drawing.Point(11, 18);
            this.lat_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.lat_textBox.Name = "lat_textBox";
            this.lat_textBox.Size = new System.Drawing.Size(68, 21);
            this.lat_textBox.TabIndex = 3;
            this.lat_textBox.Text = "lat";
            // 
            // tabPageSetup
            // 
            this.tabPageSetup.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetup.Name = "tabPageSetup";
            this.tabPageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetup.Size = new System.Drawing.Size(200, 544);
            this.tabPageSetup.TabIndex = 1;
            this.tabPageSetup.Text = "Setup";
            this.tabPageSetup.UseVisualStyleBackColor = true;
            // 
            // waypointsdataGridView
            // 
            this.waypointsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waypointsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waypointsdataGridView.Location = new System.Drawing.Point(12, 602);
            this.waypointsdataGridView.Name = "waypointsdataGridView";
            this.waypointsdataGridView.RowHeadersWidth = 62;
            this.waypointsdataGridView.RowTemplate.Height = 23;
            this.waypointsdataGridView.Size = new System.Drawing.Size(1077, 137);
            this.waypointsdataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 751);
            this.Controls.Add(this.waypointsdataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageEditor.ResumeLayout(false);
            this.wapoint_edit_groupBox.ResumeLayout(false);
            this.wapoint_edit_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waypointsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEditor;
        private System.Windows.Forms.TabPage tabPageSetup;
        private System.Windows.Forms.DataGridView waypointsdataGridView;
        private System.Windows.Forms.GroupBox wapoint_edit_groupBox;
        private System.Windows.Forms.TextBox lon_textBox;
        private System.Windows.Forms.TextBox lat_textBox;
        private System.Windows.Forms.Button addNew_button;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTMToGPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPSToUTMToolStripMenuItem;
    }
}

