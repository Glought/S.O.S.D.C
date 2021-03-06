﻿/*Simple On Screen Death Counter(S.O.S.D.C) Increments a number when a hotkey is press to a txt file.
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
using System.IO;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace SimpleOnScreenDeathCounter
{
    public partial class MainForm : Form
    {
        private string Message { get; set; }

        private int Count;
        private readonly KeyboardHookListener keyboardHookManager;

        public MainForm()
        {
            InitializeComponent();

            keyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            keyboardHookManager.Enabled = true;
            keyboardHookManager.KeyUp += KeyBoardHook_KeyUp;

            if (Properties.Settings.Default.FirstRun)
            {
                SettingsDialog settings = new SettingsDialog();
                if (settings.Created == false)
                {
                    settings.ShowDialog();
                }

                Properties.Settings.Default.FirstRun = false;
            }

            messageTextBox.Text = Properties.Settings.Default.Message;
            this.Message = messageTextBox.Text;

            if (Properties.Settings.Default.SaveCount)
            {
                Count = Properties.Settings.Default.Count;
                currentCountLabel.Text = Properties.Settings.Default.Count.ToString();
            }
            else
            {
                Count = 0;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentHotKeyInLabel.Text = Properties.Settings.Default.HotKeyIn.ToString();
            currentHotKeyDeLabel.Text = Properties.Settings.Default.HotKeyDe.ToString();
        }

        private void KeyBoardHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (Properties.Settings.Default.HotKeyEnabled && e.KeyCode == Properties.Settings.Default.HotKeyIn)
            {
                if (Properties.Settings.Default.SaveCount)
                {
                    Count = Count + 1;
                    Properties.Settings.Default.Count = Count;
                    currentCountLabel.Text = Properties.Settings.Default.Count.ToString();
                }
                else
                {
                    Count = Count + 1;
                    currentCountLabel.Text = Count.ToString();
                }
                Message = messageTextBox.Text;
                writeToFile();
                e.Handled = true;
            }
            if (Properties.Settings.Default.HotKeyEnabled && e.KeyCode == Properties.Settings.Default.HotKeyDe && Count != 0)
            {
                if (Properties.Settings.Default.SaveCount)
                {
                    Count = Count - 1;
                    Properties.Settings.Default.Count = Count;
                    currentCountLabel.Text = Properties.Settings.Default.Count.ToString();
                }
                else
                {
                    Count = Count - 1;
                    currentCountLabel.Text = Count.ToString();
                }
                Message = messageTextBox.Text;
                writeToFile();
                e.Handled = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            keyboardHookManager.KeyUp -= KeyBoardHook_KeyUp;
            this.keyboardHookManager.Dispose();
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            Message = messageTextBox.Text;
        }

        private void writeToFile()
        {
            if (Properties.Settings.Default.OBSToggle)
            {
                if (Properties.Settings.Default.ReverseOrder)
                {
                    File.WriteAllText(@"Count.txt", String.Format("{0}:{1}", Count.ToString(), Message));
                }
                else
                {
                    File.WriteAllText(@"Count.txt", String.Format("{0}:{1}", Message, Count.ToString()));
                }
            }
            else
            {
                if (Properties.Settings.Default.ReverseOrder)
                {
                    File.WriteAllText(@"Count.txt", String.Format(Properties.Settings.Default.XsplitObsStartTag + "{0}:{1}" + Properties.Settings.Default.XsplitObsEndTag, Count.ToString(), Message));
                }
                else
                {
                    File.WriteAllText(@"Count.txt", String.Format(Properties.Settings.Default.XsplitObsStartTag + "{0}:{1}" + Properties.Settings.Default.XsplitObsEndTag, Message, Count.ToString()));
                }
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            this.onOffLabel.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.GreenOn;
            currentHotKeyInLabel.Text = Properties.Settings.Default.HotKeyIn.ToString();
            currentHotKeyDeLabel.Text = Properties.Settings.Default.HotKeyDe.ToString();
            Properties.Settings.Default.HotKeyEnabled = true;
            Properties.Settings.Default.Message = messageTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.onOffLabel.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.RedOFF;
            Properties.Settings.Default.HotKeyEnabled = false;
            SettingsDialog settings = new SettingsDialog();
            if (settings.Created == false)
            {
                settings.ShowDialog();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Count = 0;
            if (Properties.Settings.Default.SaveCount)
            {
                Properties.Settings.Default.Count = Count;
                currentCountLabel.Text = Properties.Settings.Default.Count.ToString();
            }
            else
            {
                currentCountLabel.Text = Count.ToString();
            }

            writeToFile();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.onOffLabel.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.RedOFF;
            Properties.Settings.Default.HotKeyEnabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.SaveCount)
            {
                Properties.Settings.Default.Count = Count;
            }
            Properties.Settings.Default.HotKeyEnabled = false;
            Properties.Settings.Default.Message = messageTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}