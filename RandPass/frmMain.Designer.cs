namespace RandPass {
	partial class frmMain {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picLineTop = new System.Windows.Forms.PictureBox();
			this.lblEnterLength = new System.Windows.Forms.Label();
			this.btnAbout = new System.Windows.Forms.Button();
			this.txtPassLength = new System.Windows.Forms.TextBox();
			this.picLine1 = new System.Windows.Forms.PictureBox();
			this.lblChars = new System.Windows.Forms.Label();
			this.tabPassFormat = new System.Windows.Forms.TabControl();
			this.tpSimple = new System.Windows.Forms.TabPage();
			this.chkNumbers = new System.Windows.Forms.CheckBox();
			this.chkSmlLetters = new System.Windows.Forms.CheckBox();
			this.chkCapLetters = new System.Windows.Forms.CheckBox();
			this.lblIncludeInPass = new System.Windows.Forms.Label();
			this.tpAdvanced = new System.Windows.Forms.TabPage();
			this.lblPassFormat = new System.Windows.Forms.Label();
			this.lblGeneratedPass = new System.Windows.Forms.Label();
			this.picLine2 = new System.Windows.Forms.PictureBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.btnCopyToClipboard = new System.Windows.Forms.Button();
			this.tmrNewPass = new System.Windows.Forms.Timer(this.components);
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLineTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLine1)).BeginInit();
			this.tabPassFormat.SuspendLayout();
			this.tpSimple.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLine2)).BeginInit();
			this.SuspendLayout();
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(322, 12);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(32, 32);
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(12, 16);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(307, 23);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "The Random Password Generator";
			// 
			// picLineTop
			// 
			this.picLineTop.BackColor = System.Drawing.Color.Black;
			this.picLineTop.Image = ((System.Drawing.Image)(resources.GetObject("picLineTop.Image")));
			this.picLineTop.Location = new System.Drawing.Point(0, 57);
			this.picLineTop.Name = "picLineTop";
			this.picLineTop.Size = new System.Drawing.Size(366, 10);
			this.picLineTop.TabIndex = 2;
			this.picLineTop.TabStop = false;
			// 
			// lblEnterLength
			// 
			this.lblEnterLength.AutoSize = true;
			this.lblEnterLength.Location = new System.Drawing.Point(13, 78);
			this.lblEnterLength.Name = "lblEnterLength";
			this.lblEnterLength.Size = new System.Drawing.Size(184, 13);
			this.lblEnterLength.TabIndex = 3;
			this.lblEnterLength.Text = "Enter length of password to generate:";
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(279, 73);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 5;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// txtPassLength
			// 
			this.txtPassLength.Location = new System.Drawing.Point(202, 75);
			this.txtPassLength.MaxLength = 3;
			this.txtPassLength.Name = "txtPassLength";
			this.txtPassLength.Size = new System.Drawing.Size(26, 20);
			this.txtPassLength.TabIndex = 4;
			this.txtPassLength.Text = "8";
			this.txtPassLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// picLine1
			// 
			this.picLine1.BackColor = System.Drawing.Color.Black;
			this.picLine1.Image = ((System.Drawing.Image)(resources.GetObject("picLine1.Image")));
			this.picLine1.Location = new System.Drawing.Point(40, 110);
			this.picLine1.Name = "picLine1";
			this.picLine1.Size = new System.Drawing.Size(286, 10);
			this.picLine1.TabIndex = 6;
			this.picLine1.TabStop = false;
			// 
			// lblChars
			// 
			this.lblChars.AutoSize = true;
			this.lblChars.Location = new System.Drawing.Point(228, 78);
			this.lblChars.Name = "lblChars";
			this.lblChars.Size = new System.Drawing.Size(33, 13);
			this.lblChars.TabIndex = 7;
			this.lblChars.Text = "chars";
			// 
			// tabPassFormat
			// 
			this.tabPassFormat.Controls.Add(this.tpSimple);
			this.tabPassFormat.Controls.Add(this.tpAdvanced);
			this.tabPassFormat.Location = new System.Drawing.Point(12, 144);
			this.tabPassFormat.Name = "tabPassFormat";
			this.tabPassFormat.SelectedIndex = 0;
			this.tabPassFormat.Size = new System.Drawing.Size(342, 224);
			this.tabPassFormat.TabIndex = 8;
			// 
			// tpSimple
			// 
			this.tpSimple.Controls.Add(this.chkNumbers);
			this.tpSimple.Controls.Add(this.chkSmlLetters);
			this.tpSimple.Controls.Add(this.chkCapLetters);
			this.tpSimple.Controls.Add(this.lblIncludeInPass);
			this.tpSimple.Location = new System.Drawing.Point(4, 22);
			this.tpSimple.Name = "tpSimple";
			this.tpSimple.Padding = new System.Windows.Forms.Padding(3);
			this.tpSimple.Size = new System.Drawing.Size(334, 198);
			this.tpSimple.TabIndex = 0;
			this.tpSimple.Text = "Simple";
			this.tpSimple.UseVisualStyleBackColor = true;
			// 
			// chkNumbers
			// 
			this.chkNumbers.AutoSize = true;
			this.chkNumbers.Checked = true;
			this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNumbers.Location = new System.Drawing.Point(201, 85);
			this.chkNumbers.Name = "chkNumbers";
			this.chkNumbers.Size = new System.Drawing.Size(68, 17);
			this.chkNumbers.TabIndex = 13;
			this.chkNumbers.Text = "Numbers";
			this.chkNumbers.UseVisualStyleBackColor = true;
			this.chkNumbers.CheckedChanged += new System.EventHandler(this.chkNumbers_CheckedChanged);
			// 
			// chkSmlLetters
			// 
			this.chkSmlLetters.AutoSize = true;
			this.chkSmlLetters.Checked = true;
			this.chkSmlLetters.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSmlLetters.Location = new System.Drawing.Point(129, 62);
			this.chkSmlLetters.Name = "chkSmlLetters";
			this.chkSmlLetters.Size = new System.Drawing.Size(82, 17);
			this.chkSmlLetters.TabIndex = 12;
			this.chkSmlLetters.Text = "Small letters";
			this.chkSmlLetters.UseVisualStyleBackColor = true;
			this.chkSmlLetters.CheckedChanged += new System.EventHandler(this.chkSmlLetters_CheckedChanged);
			// 
			// chkCapLetters
			// 
			this.chkCapLetters.AutoSize = true;
			this.chkCapLetters.Checked = true;
			this.chkCapLetters.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCapLetters.Location = new System.Drawing.Point(57, 39);
			this.chkCapLetters.Name = "chkCapLetters";
			this.chkCapLetters.Size = new System.Drawing.Size(89, 17);
			this.chkCapLetters.TabIndex = 11;
			this.chkCapLetters.Text = "Capital letters";
			this.chkCapLetters.UseVisualStyleBackColor = true;
			this.chkCapLetters.CheckedChanged += new System.EventHandler(this.chkCapLetters_CheckedChanged);
			// 
			// lblIncludeInPass
			// 
			this.lblIncludeInPass.AutoSize = true;
			this.lblIncludeInPass.Location = new System.Drawing.Point(120, 8);
			this.lblIncludeInPass.Name = "lblIncludeInPass";
			this.lblIncludeInPass.Size = new System.Drawing.Size(110, 13);
			this.lblIncludeInPass.TabIndex = 10;
			this.lblIncludeInPass.Text = "Include in password...";
			// 
			// tpAdvanced
			// 
			this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
			this.tpAdvanced.Name = "tpAdvanced";
			this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
			this.tpAdvanced.Size = new System.Drawing.Size(334, 198);
			this.tpAdvanced.TabIndex = 1;
			this.tpAdvanced.Text = "Advanced";
			this.tpAdvanced.UseVisualStyleBackColor = true;
			// 
			// lblPassFormat
			// 
			this.lblPassFormat.AutoSize = true;
			this.lblPassFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassFormat.Location = new System.Drawing.Point(137, 117);
			this.lblPassFormat.Name = "lblPassFormat";
			this.lblPassFormat.Size = new System.Drawing.Size(100, 13);
			this.lblPassFormat.TabIndex = 9;
			this.lblPassFormat.Text = "Password format";
			// 
			// lblGeneratedPass
			// 
			this.lblGeneratedPass.AutoSize = true;
			this.lblGeneratedPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.lblGeneratedPass.Location = new System.Drawing.Point(122, 389);
			this.lblGeneratedPass.Name = "lblGeneratedPass";
			this.lblGeneratedPass.Size = new System.Drawing.Size(123, 13);
			this.lblGeneratedPass.TabIndex = 10;
			this.lblGeneratedPass.Text = "Generated password";
			// 
			// picLine2
			// 
			this.picLine2.BackColor = System.Drawing.Color.Black;
			this.picLine2.Image = ((System.Drawing.Image)(resources.GetObject("picLine2.Image")));
			this.picLine2.Location = new System.Drawing.Point(40, 382);
			this.picLine2.Name = "picLine2";
			this.picLine2.Size = new System.Drawing.Size(286, 10);
			this.picLine2.TabIndex = 11;
			this.picLine2.TabStop = false;
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.SystemColors.Window;
			this.txtPass.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(12, 409);
			this.txtPass.MaxLength = 3;
			this.txtPass.Name = "txtPass";
			this.txtPass.ReadOnly = true;
			this.txtPass.Size = new System.Drawing.Size(342, 20);
			this.txtPass.TabIndex = 12;
			// 
			// btnStartStop
			// 
			this.btnStartStop.Location = new System.Drawing.Point(12, 438);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(167, 23);
			this.btnStartStop.TabIndex = 13;
			this.btnStartStop.Text = "???";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// btnCopyToClipboard
			// 
			this.btnCopyToClipboard.Location = new System.Drawing.Point(187, 438);
			this.btnCopyToClipboard.Name = "btnCopyToClipboard";
			this.btnCopyToClipboard.Size = new System.Drawing.Size(167, 23);
			this.btnCopyToClipboard.TabIndex = 14;
			this.btnCopyToClipboard.Text = "Copy password to clipboard";
			this.btnCopyToClipboard.UseVisualStyleBackColor = true;
			this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
			// 
			// tmrNewPass
			// 
			this.tmrNewPass.Tick += new System.EventHandler(this.tmrNewPass_Tick);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(12, 523);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 555);
			this.Controls.Add(this.lblGeneratedPass);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCopyToClipboard);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.picLine2);
			this.Controls.Add(this.lblPassFormat);
			this.Controls.Add(this.tabPassFormat);
			this.Controls.Add(this.lblChars);
			this.Controls.Add(this.picLine1);
			this.Controls.Add(this.txtPassLength);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.lblEnterLength);
			this.Controls.Add(this.picLineTop);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.picLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The Random Password Generator v$ver";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLineTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLine1)).EndInit();
			this.tabPassFormat.ResumeLayout(false);
			this.tpSimple.ResumeLayout(false);
			this.tpSimple.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLine2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox picLineTop;
		private System.Windows.Forms.Label lblEnterLength;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.TextBox txtPassLength;
		private System.Windows.Forms.PictureBox picLine1;
		private System.Windows.Forms.Label lblChars;
		private System.Windows.Forms.TabControl tabPassFormat;
		private System.Windows.Forms.TabPage tpSimple;
		private System.Windows.Forms.TabPage tpAdvanced;
		private System.Windows.Forms.Label lblPassFormat;
		private System.Windows.Forms.Label lblIncludeInPass;
		private System.Windows.Forms.CheckBox chkNumbers;
		private System.Windows.Forms.CheckBox chkSmlLetters;
		private System.Windows.Forms.CheckBox chkCapLetters;
		private System.Windows.Forms.Label lblGeneratedPass;
		private System.Windows.Forms.PictureBox picLine2;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.Button btnCopyToClipboard;
		private System.Windows.Forms.Timer tmrNewPass;
		private System.Windows.Forms.Button btnExit;
	}
}

