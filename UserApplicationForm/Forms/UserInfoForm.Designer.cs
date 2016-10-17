namespace UserApplicationForm {
	partial class UserInfoForm {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonedit = new System.Windows.Forms.Button();
			this.accountinfo = new System.Windows.Forms.GroupBox();
			this.textboxusername = new System.Windows.Forms.TextBox();
			this.textboxpassword = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.personalinfo = new System.Windows.Forms.GroupBox();
			this.dobpicker = new System.Windows.Forms.DateTimePicker();
			this.textboxfirst = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textboxlast = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.addressinfo = new System.Windows.Forms.GroupBox();
			this.textboxzip = new System.Windows.Forms.TextBox();
			this.textboxstate = new System.Windows.Forms.TextBox();
			this.textboxcity = new System.Windows.Forms.TextBox();
			this.textboxstreetname = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonsubmit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.accountinfo.SuspendLayout();
			this.personalinfo.SuspendLayout();
			this.addressinfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonedit);
			this.panel1.Controls.Add(this.accountinfo);
			this.panel1.Controls.Add(this.personalinfo);
			this.panel1.Controls.Add(this.addressinfo);
			this.panel1.Controls.Add(this.buttonsubmit);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(270, 405);
			this.panel1.TabIndex = 18;
			// 
			// buttonedit
			// 
			this.buttonedit.Location = new System.Drawing.Point(111, 379);
			this.buttonedit.Name = "buttonedit";
			this.buttonedit.Size = new System.Drawing.Size(75, 23);
			this.buttonedit.TabIndex = 28;
			this.buttonedit.Text = "Edit";
			this.buttonedit.UseVisualStyleBackColor = true;
			this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
			// 
			// accountinfo
			// 
			this.accountinfo.Controls.Add(this.textboxusername);
			this.accountinfo.Controls.Add(this.textboxpassword);
			this.accountinfo.Controls.Add(this.label6);
			this.accountinfo.Controls.Add(this.label5);
			this.accountinfo.Location = new System.Drawing.Point(0, 249);
			this.accountinfo.Name = "accountinfo";
			this.accountinfo.Size = new System.Drawing.Size(270, 110);
			this.accountinfo.TabIndex = 27;
			this.accountinfo.TabStop = false;
			this.accountinfo.Text = "Account Information";
			// 
			// textboxusername
			// 
			this.textboxusername.Location = new System.Drawing.Point(89, 33);
			this.textboxusername.Name = "textboxusername";
			this.textboxusername.Size = new System.Drawing.Size(162, 20);
			this.textboxusername.TabIndex = 22;
			// 
			// textboxpassword
			// 
			this.textboxpassword.Location = new System.Drawing.Point(89, 60);
			this.textboxpassword.Name = "textboxpassword";
			this.textboxpassword.Size = new System.Drawing.Size(162, 20);
			this.textboxpassword.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "Username:";
			// 
			// personalinfo
			// 
			this.personalinfo.Controls.Add(this.dobpicker);
			this.personalinfo.Controls.Add(this.textboxfirst);
			this.personalinfo.Controls.Add(this.label1);
			this.personalinfo.Controls.Add(this.textboxlast);
			this.personalinfo.Controls.Add(this.label2);
			this.personalinfo.Controls.Add(this.label3);
			this.personalinfo.Location = new System.Drawing.Point(1, 3);
			this.personalinfo.Name = "personalinfo";
			this.personalinfo.Size = new System.Drawing.Size(269, 100);
			this.personalinfo.TabIndex = 26;
			this.personalinfo.TabStop = false;
			this.personalinfo.Text = "Personal Information";
			// 
			// dobpicker
			// 
			this.dobpicker.CustomFormat = "MMM dd, yyyy";
			this.dobpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dobpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dobpicker.Location = new System.Drawing.Point(91, 73);
			this.dobpicker.Name = "dobpicker";
			this.dobpicker.Size = new System.Drawing.Size(162, 21);
			this.dobpicker.TabIndex = 19;
			// 
			// textboxfirst
			// 
			this.textboxfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textboxfirst.Location = new System.Drawing.Point(91, 18);
			this.textboxfirst.Name = "textboxfirst";
			this.textboxfirst.Size = new System.Drawing.Size(162, 21);
			this.textboxfirst.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "First Name:";
			// 
			// textboxlast
			// 
			this.textboxlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textboxlast.Location = new System.Drawing.Point(91, 45);
			this.textboxlast.Name = "textboxlast";
			this.textboxlast.Size = new System.Drawing.Size(162, 21);
			this.textboxlast.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Last Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Date of Birth:";
			// 
			// addressinfo
			// 
			this.addressinfo.Controls.Add(this.textboxzip);
			this.addressinfo.Controls.Add(this.textboxstate);
			this.addressinfo.Controls.Add(this.textboxcity);
			this.addressinfo.Controls.Add(this.textboxstreetname);
			this.addressinfo.Controls.Add(this.label11);
			this.addressinfo.Controls.Add(this.label10);
			this.addressinfo.Controls.Add(this.label9);
			this.addressinfo.Controls.Add(this.label4);
			this.addressinfo.Location = new System.Drawing.Point(1, 109);
			this.addressinfo.Name = "addressinfo";
			this.addressinfo.Size = new System.Drawing.Size(269, 134);
			this.addressinfo.TabIndex = 21;
			this.addressinfo.TabStop = false;
			this.addressinfo.Text = "Address";
			// 
			// textboxzip
			// 
			this.textboxzip.Location = new System.Drawing.Point(91, 98);
			this.textboxzip.Name = "textboxzip";
			this.textboxzip.Size = new System.Drawing.Size(162, 20);
			this.textboxzip.TabIndex = 7;
			// 
			// textboxstate
			// 
			this.textboxstate.Location = new System.Drawing.Point(91, 71);
			this.textboxstate.Name = "textboxstate";
			this.textboxstate.Size = new System.Drawing.Size(162, 20);
			this.textboxstate.TabIndex = 6;
			// 
			// textboxcity
			// 
			this.textboxcity.Location = new System.Drawing.Point(91, 45);
			this.textboxcity.Name = "textboxcity";
			this.textboxcity.Size = new System.Drawing.Size(162, 20);
			this.textboxcity.TabIndex = 5;
			// 
			// textboxstreetname
			// 
			this.textboxstreetname.Location = new System.Drawing.Point(91, 17);
			this.textboxstreetname.Name = "textboxstreetname";
			this.textboxstreetname.Size = new System.Drawing.Size(162, 20);
			this.textboxstreetname.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(32, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Zip Code:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(50, 74);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 2;
			this.label10.Text = "State:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(58, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "City:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Street Address:";
			// 
			// buttonsubmit
			// 
			this.buttonsubmit.Location = new System.Drawing.Point(192, 379);
			this.buttonsubmit.Name = "buttonsubmit";
			this.buttonsubmit.Size = new System.Drawing.Size(75, 23);
			this.buttonsubmit.TabIndex = 20;
			this.buttonsubmit.Text = "Submit";
			this.buttonsubmit.UseVisualStyleBackColor = true;
			this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
			// 
			// UserInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 429);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "UserInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserInfoForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInfoForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInfoForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.accountinfo.ResumeLayout(false);
			this.accountinfo.PerformLayout();
			this.personalinfo.ResumeLayout(false);
			this.personalinfo.PerformLayout();
			this.addressinfo.ResumeLayout(false);
			this.addressinfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox textboxpassword;
		private System.Windows.Forms.TextBox textboxusername;
		private System.Windows.Forms.GroupBox addressinfo;
		private System.Windows.Forms.TextBox textboxzip;
		private System.Windows.Forms.TextBox textboxstate;
		private System.Windows.Forms.TextBox textboxcity;
		private System.Windows.Forms.TextBox textboxstreetname;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonsubmit;
		private System.Windows.Forms.DateTimePicker dobpicker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textboxlast;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textboxfirst;
		private System.Windows.Forms.GroupBox accountinfo;
		private System.Windows.Forms.GroupBox personalinfo;
		private System.Windows.Forms.Button buttonedit;
	}
}