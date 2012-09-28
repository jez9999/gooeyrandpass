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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picLineTop = new System.Windows.Forms.PictureBox();
			this.lblEnterLength = new System.Windows.Forms.Label();
			this.btnAbout = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLineTop)).BeginInit();
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
			this.lblEnterLength.Location = new System.Drawing.Point(31, 78);
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
			this.btnAbout.TabIndex = 4;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(220, 75);
			this.textBox1.MaxLength = 3;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(26, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 555);
			this.Controls.Add(this.textBox1);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox picLineTop;
		private System.Windows.Forms.Label lblEnterLength;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.TextBox textBox1;
	}
}

