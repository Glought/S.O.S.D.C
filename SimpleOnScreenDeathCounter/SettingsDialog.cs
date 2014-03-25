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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleOnScreenDeathCounter
{
    public partial class SettingsDialog : Form
    {
        Keys keys;
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void applySettingButton_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.DontChangeHotkey)
            {
                Enum.TryParse<Keys>(hotKeyComboBox.SelectedValue.ToString(), out keys);
                Properties.Settings.Default.HotKey = keys;
                Properties.Settings.Default.DontChangeHotkey = true;
            }

            Properties.Settings.Default.Save();
            Close();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            hotKeyComboBox.DataSource = Enum.GetValues(typeof(Keys));
            currentHotKeyLabel.Text = Properties.Settings.Default.HotKey.ToString();
            startTagTextBox.Text = Properties.Settings.Default.XsplitObsStartTag;
            endTagTextBox.Text = Properties.Settings.Default.XsplitObsEndTag;


            if (Properties.Settings.Default.DontChangeHotkey)
            {
                this.lockPicture.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.lock_closed;
            }
            else
            {
                this.lockPicture.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.lock_open;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.DontChangeHotkey)
            {
                Properties.Settings.Default.DontChangeHotkey = true;
            }
            Close();
        }

        private void LockPicture_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DontChangeHotkey)
            {
                this.lockPicture.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.lock_open;
                Properties.Settings.Default.DontChangeHotkey = false;
            }
            else
            {
                Properties.Settings.Default.DontChangeHotkey = true;
                this.lockPicture.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.lock_closed;
            }
        }
    }
}
