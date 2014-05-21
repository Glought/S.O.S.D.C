/*Simple On Screen Death Counter(S.O.S.D.C) Increments a number when a hotkey is press to a txt file.
  Copyright 2014 ThoughtsOfGlought

  This file is part of Simple On Screen Death Counter(S.O.S.D.C).
  Simple On Screen Death Counter(S.O.S.D.C) is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  Simple On Screen Death Counter(S.O.S.D.C) is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Simple On Screen Death Counter(S.O.S.D.C).  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;


namespace SimpleOnScreenDeathCounter
{
    public partial class SettingsDialog : Form
    {
        private Keys keys;

        public SettingsDialog()
        {
            InitializeComponent();
            if (Properties.Settings.Default.FirstRun)
            {
                Properties.Settings.Default.HotKeyIn = Keys.H;
                Properties.Settings.Default.HotKeyDe = Keys.J;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "S.O.S.D.C:First Run";
                this.toolTip1.SetToolTip(this, "Simple On Screen Death Counter(S.O.S.D.C):First Run.Click Apply if you want to use default Hot key:H");
            }
            else
            {
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            }
        }

        private void applySettingButton_Click(object sender, EventArgs e)
        {
            if (hotKeyInComboBox.SelectedValue.ToString() != "None")
            {
                Enum.TryParse<Keys>(hotKeyInComboBox.SelectedValue.ToString(), out keys);
                Properties.Settings.Default.HotKeyIn = keys;
            }
            if (hotKeyDeComboBox.SelectedValue.ToString() != "None")
            {
                Enum.TryParse<Keys>(hotKeyDeComboBox.SelectedValue.ToString(), out keys);
                Properties.Settings.Default.HotKeyDe = keys;
            }

            if (Properties.Settings.Default.FirstRun && hotKeyInComboBox.SelectedValue.ToString() == "None" && hotKeyDeComboBox.SelectedValue.ToString() == "None")
            {
                Properties.Settings.Default.HotKeyIn = Keys.H;
                Properties.Settings.Default.HotKeyDe = Keys.J;
            }

            Properties.Settings.Default.XsplitObsStartTag = startTagTextBox.Text;
            Properties.Settings.Default.XsplitObsEndTag = endTagTextBox.Text;

            Properties.Settings.Default.Save();
            Close();
            Dispose();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            hotKeyInComboBox.DataSource = Enum.GetValues(typeof(SosdcKeys));
            hotKeyDeComboBox.DataSource = Enum.GetValues(typeof(SosdcKeys));
            currentHotKeyInLabel.Text = Properties.Settings.Default.HotKeyIn.ToString();
            currentHotKeyDeLabel.Text = Properties.Settings.Default.HotKeyDe.ToString();
            startTagTextBox.Text = Properties.Settings.Default.XsplitObsStartTag;
            endTagTextBox.Text = Properties.Settings.Default.XsplitObsEndTag;
            if (Properties.Settings.Default.OBSToggle)
            {
                startTagTextBox.Enabled = false;
                endTagTextBox.Enabled = false;
            }
            else
            {
                startTagTextBox.Enabled = true;
                endTagTextBox.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void OBSToggleCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OBSToggle)
            {
                startTagTextBox.Enabled = false;
                endTagTextBox.Enabled = false;
            }
            else
            {
                startTagTextBox.Enabled = true;
                endTagTextBox.Enabled = true;
            }
        }
    }
}