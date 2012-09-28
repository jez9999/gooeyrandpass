using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandPass {
	public partial class frmAbout : Form {
		public frmAbout() {
			InitializeComponent();
		}

		private void frmAbout_Load(object sender, EventArgs e) {
			// Prevent tabstop for link to website (property is unavailable in Visual Studio designer!)
			lnkGooeySite.TabStop = false;
		}

		private void lnkGooeySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs ea) {
			// Navigate to Gooey Software website
			System.Diagnostics.Process.Start("http://www.gooeysoftware.com/");
		}
	}
}
