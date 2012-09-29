using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gooey;
using System.Reflection;

namespace RandPass {
	public partial class frmAbout : Form {
		#region Private members

		private Utilities utils { get; set; }

		#endregion

		#region Constructors

		public frmAbout() {
			InitializeComponent();

			utils = new Utilities();
		}

		#endregion

		private void frmAbout_Load(object sender, EventArgs e) {
			Assembly thisAssembly = Assembly.GetExecutingAssembly();

			lblVer.Text = lblVer.Text.Replace("$ver", utils.GetVersionString(thisAssembly, VersionStringType.MajorMinor));

			// Prevent tabstop for link to website (property is unavailable in Visual Studio designer!)
			lnkGooeySite.TabStop = false;
		}

		private void lnkGooeySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs ea) {
			// Navigate to Gooey Software website
			System.Diagnostics.Process.Start("http://www.gooeysoftware.com/");
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
