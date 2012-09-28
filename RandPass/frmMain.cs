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
	public partial class frmMain : Form {
		private Utilities utils { get; set; }

		public frmMain() {
			InitializeComponent();

			utils = new Utilities();
		}

		private void frmMain_Load(object sender, EventArgs e) {
			Assembly thisAssembly = Assembly.GetExecutingAssembly();

			this.Text = this.Text.Replace("$ver", utils.GetVersionString(thisAssembly, VersionStringType.MajorMinor));
			picLineTop.Height = 3;
		}
	}
}
