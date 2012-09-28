namespace RandPass {
	partial class frmAbout {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.lblAbout2 = new System.Windows.Forms.Label();
			this.picGooeyLogo = new System.Windows.Forms.PictureBox();
			this.lblLicence = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtGplLicence = new System.Windows.Forms.TextBox();
			this.lnkGooeySite = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.picGooeyLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAbout2
			// 
			this.lblAbout2.AutoSize = true;
			this.lblAbout2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAbout2.Location = new System.Drawing.Point(143, 495);
			this.lblAbout2.Name = "lblAbout2";
			this.lblAbout2.Size = new System.Drawing.Size(175, 14);
			this.lblAbout2.TabIndex = 4;
			this.lblAbout2.Text = "Copyright © Gooey Software 2012";
			// 
			// picGooeyLogo
			// 
			this.picGooeyLogo.Image = ((System.Drawing.Image)(resources.GetObject("picGooeyLogo.Image")));
			this.picGooeyLogo.Location = new System.Drawing.Point(32, 400);
			this.picGooeyLogo.Name = "picGooeyLogo";
			this.picGooeyLogo.Size = new System.Drawing.Size(268, 92);
			this.picGooeyLogo.TabIndex = 5;
			this.picGooeyLogo.TabStop = false;
			// 
			// lblLicence
			// 
			this.lblLicence.AutoSize = true;
			this.lblLicence.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLicence.Location = new System.Drawing.Point(11, 2);
			this.lblLicence.Name = "lblLicence";
			this.lblLicence.Size = new System.Drawing.Size(307, 23);
			this.lblLicence.TabIndex = 6;
			this.lblLicence.Text = "The Random Password Generator";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 14);
			this.label1.TabIndex = 7;
			this.label1.Text = "Licenced under the GPLv3:";
			// 
			// txtGplLicence
			// 
			this.txtGplLicence.BackColor = System.Drawing.SystemColors.Info;
			this.txtGplLicence.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGplLicence.Location = new System.Drawing.Point(12, 49);
			this.txtGplLicence.MaxLength = 2147483640;
			this.txtGplLicence.Multiline = true;
			this.txtGplLicence.Name = "txtGplLicence";
			this.txtGplLicence.ReadOnly = true;
			this.txtGplLicence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtGplLicence.Size = new System.Drawing.Size(306, 338);
			this.txtGplLicence.TabIndex = 8;
			this.txtGplLicence.TabStop = false;
			this.txtGplLicence.Text = resources.GetString("txtGplLicence.Text");
			// 
			// lnkGooeySite
			// 
			this.lnkGooeySite.AutoSize = true;
			this.lnkGooeySite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkGooeySite.Location = new System.Drawing.Point(180, 509);
			this.lnkGooeySite.Name = "lnkGooeySite";
			this.lnkGooeySite.Size = new System.Drawing.Size(138, 14);
			this.lnkGooeySite.TabIndex = 10;
			this.lnkGooeySite.TabStop = true;
			this.lnkGooeySite.Text = "www.gooeysoftware.com";
			this.lnkGooeySite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGooeySite_LinkClicked);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 528);
			this.Controls.Add(this.lnkGooeySite);
			this.Controls.Add(this.txtGplLicence);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLicence);
			this.Controls.Add(this.picGooeyLogo);
			this.Controls.Add(this.lblAbout2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About...";
			this.Load += new System.EventHandler(this.frmAbout_Load);
			((System.ComponentModel.ISupportInitialize)(this.picGooeyLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAbout2;
		private System.Windows.Forms.PictureBox picGooeyLogo;
		private System.Windows.Forms.Label lblLicence;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGplLicence;
		private System.Windows.Forms.LinkLabel lnkGooeySite;
	}
}