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
using System.Runtime.InteropServices;

namespace RandPass {
	public partial class frmMain : Form {
		#region Private members

		private const string _strStartGenerating = "Start generating";
		private const string _strStopGenerating = "Stop generating";
		private Utilities _utils { get; set; }
		private PassGenerator _passGen { get; set; }
		private Point _origPassBoxLocation { get; set; }
		private Size _origPassBoxSize { get; set; }

		#endregion

		#region Constructors

		public frmMain() {
			InitializeComponent();

			_utils = new Utilities();
			_passGen = new PassGenerator();
			_origPassBoxLocation = txtPass.Location;
			_origPassBoxSize = txtPass.Size;
		}

		#endregion

		#region Private helper methods

		/// <summary>
		/// Because the WinForms designer doesn't let us resize picture boxes to a height of less than 10, for
		/// some reason, we need to resize them to be as short as we really want them to be, on form load.
		/// </summary>
		private void resizeLines() {
			picLineTop.Height = 3;
			picLine1.Height = 1;
			picLine2.Height = 1;
		}

		/// <summary>
		/// Sizes the password box to hold the number of characters specified, based on the size of the
		/// font that is used to render the password box text.  If wider than the containing form, only sizes
		/// to the width of the form.  Also centres the box horizontally.
		/// </summary>
		/// <param name="contents">The string to be displayed in the password box.</param>
		private void sizePasswordBox(string contents) {
			Size textSize = TextRenderer.MeasureText(txtPass.CreateGraphics(), contents, txtPass.Font);

			if (textSize.Width >= _origPassBoxSize.Width) {
				// Wider than the original width; just reset to original width and position
				txtPass.Size = _origPassBoxSize;
				txtPass.Location = _origPassBoxLocation;
			}
			else {
				txtPass.Size = new Size(textSize.Width, _origPassBoxSize.Height);
				txtPass.Location = new Point(_origPassBoxLocation.X + ((_origPassBoxSize.Width / 2) - (textSize.Width / 2)), _origPassBoxLocation.Y);
			}
		}

		/// <summary>
		/// When one of the "simple mode" password format checkboxes has been changed, at least one of them
		/// must remain checked.  If this checkbox is being unchecked, and it's the last one that's still
		/// checked, we force it to remain checked.
		/// </summary>
		/// <param name="boxChanged">The checkbox that's just been changed.</param>
		private void ensureOneCheckboxChecked(CheckBox boxChanged) {
			// One checkbox MUST be selected
			if (!chkCapLetters.Checked && !chkSmlLetters.Checked && !chkNumbers.Checked) {
				boxChanged.Checked = true;
			}
		}

		/// <summary>
		/// Generates a "simple" password, based on the contents of the "simple" tab, or an error string
		/// explaining the problem generating the password if there was a problem.
		/// </summary>
		/// <param name="txtPassTag">The value to assign to the password box's Tag property to indicate whether password generation was successful.</param>
		/// <returns>If successful, the generated password; otherwise, an error string.</returns>
		private string generateSimplePassword(out object txtPassTag) {
			txtPassTag = "";

			try {
				uint passLength;
				if (!uint.TryParse((txtPassLength.Text == "" ? "0" : txtPassLength.Text), out passLength)) {
					throw new Exception("Couldn't parse password length '" + txtPassLength.Text + "' as an integer!");
				}
				txtPassTag = new PassGenerationResult { Successful = true };
				return _passGen.GeneratePassword((passLength == 0 ? 1 : passLength), chkCapLetters.Checked, chkSmlLetters.Checked, chkNumbers.Checked);
			}
			catch (Exception ex) {
				txtPassTag = new PassGenerationResult { Successful = false };
				return "Error generating password: " + ex.Message;
			}
		}

		/// <summary>
		/// Generates an "advanced" password, based on the contents of the "advanced" tab, or an error string
		/// explaining the problem generating the password if there was a problem.
		/// </summary>
		/// <param name="txtPassTag">The value to assign to the password box's Tag property to indicate whether password generation was successful.</param>
		/// <returns>If successful, the generated password; otherwise, an error string.</returns>
		private string generateAdvancedPassword(out object txtPassTag) {
			txtPassTag = "";

			try {
				txtPassTag = new PassGenerationResult { Successful = true };
				return _passGen.GeneratePassword(txtFormatOfPass.Text);
			}
			catch (Exception ex) {
				txtPassTag = new PassGenerationResult { Successful = false };
				return "Error generating password: " + ex.Message;
			}
		}

		#endregion

		#region Private classes and structs

		private struct PassGenerationResult {
			public bool Successful;
		}

		#endregion

		private void frmMain_Load(object sender, EventArgs ea) {
			Assembly thisAssembly = Assembly.GetExecutingAssembly();

			this.Text = this.Text.Replace("$ver", _utils.GetVersionString(thisAssembly, VersionStringType.MajorMinor));
			resizeLines();

			btnStartStop.Text = _strStartGenerating;
			txtPass.Enabled = false;
			txtPass.BackColor = SystemColors.Control;

			txtPass.Tag = new PassGenerationResult { Successful = false };
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

		private void btnAbout_Click(object sender, EventArgs ea) {
			frmAbout frmAboutInstance = new frmAbout();
			frmAboutInstance.ShowDialog(this);
		}

		private void btnStartStop_Click(object sender, EventArgs ea) {
			if (!tmrNewPass.Enabled) {
				tmrNewPass.Start();
				btnStartStop.Text = _strStopGenerating;
			}
			else {
				tmrNewPass.Stop();
				btnStartStop.Text = _strStartGenerating;
			}
		}

		private void tmrNewPass_Tick(object sender, EventArgs ea) {
			txtPass.Enabled = true;
			txtPass.BackColor = SystemColors.Window;

			string passString = "";
			object txtPassTag;
			if ((string)tabPassFormat.SelectedTab.Tag == "simple") {
				passString = generateSimplePassword(out txtPassTag);
				txtPass.Tag = txtPassTag;
			}
			else if ((string)tabPassFormat.SelectedTab.Tag == "advanced") {
				passString = generateAdvancedPassword(out txtPassTag);
				txtPass.Tag = txtPassTag;
			}

			sizePasswordBox(passString);
			txtPass.Text = passString;
		}

		private void btnExit_Click(object sender, EventArgs ea) {
			Application.Exit();
		}

		private void chkCapLetters_CheckedChanged(object sender, EventArgs ea) {
			ensureOneCheckboxChecked((CheckBox)sender);
		}

		private void chkSmlLetters_CheckedChanged(object sender, EventArgs e) {
			ensureOneCheckboxChecked((CheckBox)sender);
		}

		private void chkNumbers_CheckedChanged(object sender, EventArgs e) {
			ensureOneCheckboxChecked((CheckBox)sender);
		}

		private void btnCopyToClipboard_Click(object sender, EventArgs e) {
			if (txtPass.Tag == null || !((PassGenerationResult)txtPass.Tag).Successful) {
				// No password to copy to clipboard
				_utils.ShowError("No password to copy to clipboard!");
			}
			else {
				// Copy to clipboard
				Clipboard.SetText(txtPass.Text, TextDataFormat.Text);
				_utils.ShowInfo("Password copied to clipboard.");
			}
		}

		private void tabPassFormat_SelectedIndexChanged(object sender, EventArgs ea) {
			if ((string)tabPassFormat.SelectedTab.Tag == "simple") {
				txtPassLength.Enabled = true;
			}
			else if ((string)tabPassFormat.SelectedTab.Tag == "advanced") {
				txtPassLength.Enabled = false;
			}
		}
	}
}
