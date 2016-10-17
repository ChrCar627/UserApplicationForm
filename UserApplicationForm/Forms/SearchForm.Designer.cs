namespace UserApplicationForm
{
	partial class SearchForm
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
			this.searchfirstname = new System.Windows.Forms.TextBox();
			this.resultsbox = new System.Windows.Forms.ListBox();
			this.buttonview = new System.Windows.Forms.Button();
			this.buttonremove = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.searchlastname = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonadd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonload = new System.Windows.Forms.Button();
			this.buttonsave = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.currentfilelabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchfirstname
			// 
			this.searchfirstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchfirstname.Location = new System.Drawing.Point(10, 34);
			this.searchfirstname.Name = "searchfirstname";
			this.searchfirstname.Size = new System.Drawing.Size(238, 20);
			this.searchfirstname.TabIndex = 0;
			this.searchfirstname.TextChanged += new System.EventHandler(this.searchfirstname_TextChanged);
			// 
			// resultsbox
			// 
			this.resultsbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.resultsbox.FormattingEnabled = true;
			this.resultsbox.ItemHeight = 15;
			this.resultsbox.Location = new System.Drawing.Point(10, 18);
			this.resultsbox.Name = "resultsbox";
			this.resultsbox.Size = new System.Drawing.Size(238, 169);
			this.resultsbox.TabIndex = 3;
			this.resultsbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.resultsbox_Format);
			this.resultsbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultsbox_KeyDown);
			this.resultsbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsbox_MouseDoubleClick);
			// 
			// buttonview
			// 
			this.buttonview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonview.Location = new System.Drawing.Point(150, 34);
			this.buttonview.Name = "buttonview";
			this.buttonview.Size = new System.Drawing.Size(87, 23);
			this.buttonview.TabIndex = 4;
			this.buttonview.Text = "View/Edit";
			this.buttonview.UseVisualStyleBackColor = true;
			this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
			// 
			// buttonremove
			// 
			this.buttonremove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonremove.Location = new System.Drawing.Point(20, 34);
			this.buttonremove.Name = "buttonremove";
			this.buttonremove.Size = new System.Drawing.Size(87, 23);
			this.buttonremove.TabIndex = 5;
			this.buttonremove.Text = "Remove";
			this.buttonremove.UseVisualStyleBackColor = true;
			this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "First Name";
			// 
			// searchlastname
			// 
			this.searchlastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchlastname.Location = new System.Drawing.Point(10, 80);
			this.searchlastname.Name = "searchlastname";
			this.searchlastname.Size = new System.Drawing.Size(238, 20);
			this.searchlastname.TabIndex = 1;
			this.searchlastname.TextChanged += new System.EventHandler(this.searchlastname_TextChanged);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Last Name";
			// 
			// buttonadd
			// 
			this.buttonadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonadd.Location = new System.Drawing.Point(20, 5);
			this.buttonadd.Name = "buttonadd";
			this.buttonadd.Size = new System.Drawing.Size(87, 23);
			this.buttonadd.TabIndex = 8;
			this.buttonadd.Text = "Add";
			this.buttonadd.UseVisualStyleBackColor = true;
			this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.resultsbox);
			this.groupBox1.Location = new System.Drawing.Point(15, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 192);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Results";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.searchfirstname);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.searchlastname);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(15, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(258, 110);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Search Criteria";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.buttonload);
			this.panel1.Controls.Add(this.buttonsave);
			this.panel1.Controls.Add(this.buttonview);
			this.panel1.Controls.Add(this.buttonremove);
			this.panel1.Controls.Add(this.buttonadd);
			this.panel1.Location = new System.Drawing.Point(15, 334);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(258, 64);
			this.panel1.TabIndex = 11;
			// 
			// buttonload
			// 
			this.buttonload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonload.Location = new System.Drawing.Point(196, 5);
			this.buttonload.Name = "buttonload";
			this.buttonload.Size = new System.Drawing.Size(41, 23);
			this.buttonload.TabIndex = 10;
			this.buttonload.Text = "Load";
			this.buttonload.UseVisualStyleBackColor = true;
			this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
			// 
			// buttonsave
			// 
			this.buttonsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonsave.Location = new System.Drawing.Point(150, 5);
			this.buttonsave.Name = "buttonsave";
			this.buttonsave.Size = new System.Drawing.Size(41, 23);
			this.buttonsave.TabIndex = 9;
			this.buttonsave.Text = "Save";
			this.buttonsave.UseVisualStyleBackColor = true;
			this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(289, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentfilelabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 399);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(289, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// currentfilelabel
			// 
			this.currentfilelabel.Name = "currentfilelabel";
			this.currentfilelabel.Size = new System.Drawing.Size(72, 17);
			this.currentfilelabel.Text = "No file open";
			this.currentfilelabel.ToolTipText = "The currently opened file";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// SearchForm
			// 
			this.AcceptButton = this.buttonview;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 421);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Application Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox searchlastname;
		private System.Windows.Forms.TextBox searchfirstname;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonremove;
		private System.Windows.Forms.Button buttonview;
		private System.Windows.Forms.ListBox resultsbox;
		private System.Windows.Forms.Button buttonadd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Button buttonload;
		private System.Windows.Forms.Button buttonsave;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel currentfilelabel;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		
		public System.Windows.Forms.ListBox ResultsBox {
			get { return resultsbox; }
			set { resultsbox = value; }
		}
		public System.Windows.Forms.TextBox SearchLastName {
			get { return searchlastname; }
			set { searchlastname = value; }
		}
		public System.Windows.Forms.TextBox SearchFirstName {
			get { return searchfirstname; }
			set { searchfirstname = value; }
		}
		public System.Windows.Forms.ToolStripStatusLabel CurrentFileLabel {
			get { return currentfilelabel; }
			set { currentfilelabel = value; }
		}



	}
}

