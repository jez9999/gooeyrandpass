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

		private void textBox1_KeyDown(object sender, KeyEventArgs ea)
		{
			// Only allow numerals and various control characters to be typed into this box
			Keys[] allowedKeys = new[] {
				Keys.Up,
				Keys.Down,
				Keys.Left,
				Keys.Right,
				Keys.Home,
				Keys.End,
				Keys.ShiftKey,
				Keys.Control,
				Keys.Alt,
				Keys.Back,
				Keys.Delete,
			};

			if (ea.Modifiers == Keys.None && (ea.KeyValue >= 48 && ea.KeyValue <= 57)) {
				return;
			}

			// Not a numeral; is it an allowed control character?
			foreach (var key in allowedKeys) {
				if (ea.KeyCode == key) {
					return;
				}
			}

			ea.SuppressKeyPress = true;
		}

		private void btnAbout_Click(object sender, EventArgs e) {
			frmAbout frmAboutInstance = new frmAbout();
			frmAboutInstance.ShowDialog(this);
		}
	}
}
