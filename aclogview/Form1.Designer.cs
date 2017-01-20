﻿namespace aclogview {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.listView_Packets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer_Bottom = new System.Windows.Forms.SplitContainer();
            this.textBox_PacketData = new System.Windows.Forms.TextBox();
            this.treeView_ParsedData = new System.Windows.Forms.TreeView();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem_File = new System.Windows.Forms.MenuItem();
            this.menuItem_Open = new System.Windows.Forms.MenuItem();
            this.menuItem_Edit = new System.Windows.Forms.MenuItem();
            this.menuItem_Help = new System.Windows.Forms.MenuItem();
            this.menuItem_About = new System.Windows.Forms.MenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.checkBox_HideHeaderOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Bottom)).BeginInit();
            this.splitContainer_Bottom.Panel1.SuspendLayout();
            this.splitContainer_Bottom.Panel2.SuspendLayout();
            this.splitContainer_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 24);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.listView_Packets);
            this.splitContainer_Main.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.splitContainer_Bottom);
            this.splitContainer_Main.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_Main.Size = new System.Drawing.Size(1520, 918);
            this.splitContainer_Main.SplitterDistance = 423;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // listView_Packets
            // 
            this.listView_Packets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView_Packets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Packets.FullRowSelect = true;
            this.listView_Packets.Location = new System.Drawing.Point(0, 0);
            this.listView_Packets.MultiSelect = false;
            this.listView_Packets.Name = "listView_Packets";
            this.listView_Packets.Size = new System.Drawing.Size(1516, 419);
            this.listView_Packets.TabIndex = 0;
            this.listView_Packets.UseCompatibleStateImageBehavior = false;
            this.listView_Packets.View = System.Windows.Forms.View.Details;
            this.listView_Packets.VirtualMode = true;
            this.listView_Packets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Packets_ColumnClick);
            this.listView_Packets.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView_Packets_RetrieveVirtualItem);
            this.listView_Packets.SelectedIndexChanged += new System.EventHandler(this.listView_Packets_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "S/R";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Headers";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Extra Info";
            this.columnHeader6.Width = 250;
            // 
            // splitContainer_Bottom
            // 
            this.splitContainer_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Bottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Bottom.Name = "splitContainer_Bottom";
            // 
            // splitContainer_Bottom.Panel1
            // 
            this.splitContainer_Bottom.Panel1.Controls.Add(this.textBox_PacketData);
            // 
            // splitContainer_Bottom.Panel2
            // 
            this.splitContainer_Bottom.Panel2.Controls.Add(this.treeView_ParsedData);
            this.splitContainer_Bottom.Size = new System.Drawing.Size(1520, 491);
            this.splitContainer_Bottom.SplitterDistance = 1130;
            this.splitContainer_Bottom.TabIndex = 0;
            // 
            // textBox_PacketData
            // 
            this.textBox_PacketData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PacketData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PacketData.Location = new System.Drawing.Point(0, 0);
            this.textBox_PacketData.Multiline = true;
            this.textBox_PacketData.Name = "textBox_PacketData";
            this.textBox_PacketData.Size = new System.Drawing.Size(1126, 487);
            this.textBox_PacketData.TabIndex = 0;
            // 
            // treeView_ParsedData
            // 
            this.treeView_ParsedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_ParsedData.Location = new System.Drawing.Point(0, 0);
            this.treeView_ParsedData.Name = "treeView_ParsedData";
            this.treeView_ParsedData.Size = new System.Drawing.Size(382, 487);
            this.treeView_ParsedData.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_File,
            this.menuItem_Edit,
            this.menuItem_Help});
            // 
            // menuItem_File
            // 
            this.menuItem_File.Index = 0;
            this.menuItem_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Open});
            this.menuItem_File.Text = "File";
            // 
            // menuItem_Open
            // 
            this.menuItem_Open.Index = 0;
            this.menuItem_Open.Text = "Open";
            this.menuItem_Open.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem_Edit
            // 
            this.menuItem_Edit.Index = 1;
            this.menuItem_Edit.Text = "Edit";
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.Index = 2;
            this.menuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_About});
            this.menuItem_Help.Text = "Help";
            // 
            // menuItem_About
            // 
            this.menuItem_About.Index = 0;
            this.menuItem_About.Text = "About";
            this.menuItem_About.Click += new System.EventHandler(this.menuItem_About_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1520, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(566, 0);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(165, 20);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.Visible = false;
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.Location = new System.Drawing.Point(539, 0);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Search.TabIndex = 3;
            this.pictureBox_Search.TabStop = false;
            this.pictureBox_Search.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 942);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1520, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // checkBox_HideHeaderOnly
            // 
            this.checkBox_HideHeaderOnly.Location = new System.Drawing.Point(805, 3);
            this.checkBox_HideHeaderOnly.Name = "checkBox_HideHeaderOnly";
            this.checkBox_HideHeaderOnly.Size = new System.Drawing.Size(138, 17);
            this.checkBox_HideHeaderOnly.TabIndex = 0;
            this.checkBox_HideHeaderOnly.Text = "Hide Header Only";
            this.checkBox_HideHeaderOnly.UseVisualStyleBackColor = true;
            this.checkBox_HideHeaderOnly.Visible = false;
            this.checkBox_HideHeaderOnly.CheckedChanged += new System.EventHandler(this.checkBox_HideHeaderOnly_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 964);
            this.Controls.Add(this.checkBox_HideHeaderOnly);
            this.Controls.Add(this.splitContainer_Main);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.pictureBox_Search);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "AC Log View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.splitContainer_Bottom.Panel1.ResumeLayout(false);
            this.splitContainer_Bottom.Panel1.PerformLayout();
            this.splitContainer_Bottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Bottom)).EndInit();
            this.splitContainer_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.ListView listView_Packets;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem_File;
        private System.Windows.Forms.MenuItem menuItem_Edit;
        private System.Windows.Forms.MenuItem menuItem_Help;
        private System.Windows.Forms.MenuItem menuItem_Open;
        private System.Windows.Forms.MenuItem menuItem_About;
        private System.Windows.Forms.SplitContainer splitContainer_Bottom;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textBox_PacketData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TreeView treeView_ParsedData;
        private System.Windows.Forms.CheckBox checkBox_HideHeaderOnly;
    }
}
