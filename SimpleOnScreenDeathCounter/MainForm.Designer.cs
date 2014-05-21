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




namespace SimpleOnScreenDeathCounter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.apply_Button = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.currentCountLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.onOffLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentHotKeyInLabel = new System.Windows.Forms.Label();
            this.KeyboardKeyEventProvider1 = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.currentHotKeyDeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apply_Button
            // 
            this.apply_Button.Location = new System.Drawing.Point(2, 101);
            this.apply_Button.Name = "apply_Button";
            this.apply_Button.Size = new System.Drawing.Size(82, 24);
            this.apply_Button.TabIndex = 0;
            this.apply_Button.Text = "Start/Save";
            this.toolTip.SetToolTip(this.apply_Button, "Enables the hotkeys and save the text in the message text box.\r\nClosing the progr" +
                    "am will also save the text.\r\n");
            this.apply_Button.UseVisualStyleBackColor = true;
            this.apply_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(-1, 30);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Message:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(-1, 77);
            this.countLabel.MaximumSize = new System.Drawing.Size(0, 25);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "Count:";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(90, 101);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 24);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.toolTip.SetToolTip(this.settingsButton, "Settings dialog to set HotKey and Set Start and End tags for Xsplit.Disables the " +
                    "hotkey");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // currentCountLabel
            // 
            this.currentCountLabel.AutoSize = true;
            this.currentCountLabel.Location = new System.Drawing.Point(34, 77);
            this.currentCountLabel.Name = "currentCountLabel";
            this.currentCountLabel.Size = new System.Drawing.Size(13, 13);
            this.currentCountLabel.TabIndex = 6;
            this.currentCountLabel.Text = "0";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(90, 72);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Count";
            this.toolTip.SetToolTip(this.resetButton, "Resets the count");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(58, 72);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(26, 23);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "S";
            this.toolTip.SetToolTip(this.StopButton, "Disables the HotKey.");
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            this.toolTip.Tag = "";
            // 
            // onOffLabel
            // 
            this.onOffLabel.AutoSize = true;
            this.onOffLabel.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.RedOFF;
            this.onOffLabel.Location = new System.Drawing.Point(128, 28);
            this.onOffLabel.Name = "onOffLabel";
            this.onOffLabel.Size = new System.Drawing.Size(37, 13);
            this.onOffLabel.TabIndex = 9;
            this.onOffLabel.Text = "          ";
            this.toolTip.SetToolTip(this.onOffLabel, "Green:HotKeys Enabled. Red:Hotkeys disabled");
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.messageTextBox.Location = new System.Drawing.Point(2, 46);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(163, 20);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.Message;
            this.toolTip.SetToolTip(this.messageTextBox, "The message that will appear next to the Count");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current HotKey Increment:";
            // 
            // currentHotKeyInLabel
            // 
            this.currentHotKeyInLabel.AutoSize = true;
            this.currentHotKeyInLabel.Location = new System.Drawing.Point(137, 2);
            this.currentHotKeyInLabel.Name = "currentHotKeyInLabel";
            this.currentHotKeyInLabel.Size = new System.Drawing.Size(25, 13);
            this.currentHotKeyInLabel.TabIndex = 11;
            this.currentHotKeyInLabel.Text = "Key";
            // 
            // KeyboardKeyEventProvider1
            // 
            this.KeyboardKeyEventProvider1.Enabled = false;
            this.KeyboardKeyEventProvider1.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current HotKey Decrement:";
            // 
            // currentHotKeyDeLabel
            // 
            this.currentHotKeyDeLabel.AutoSize = true;
            this.currentHotKeyDeLabel.Location = new System.Drawing.Point(137, 15);
            this.currentHotKeyDeLabel.Name = "currentHotKeyDeLabel";
            this.currentHotKeyDeLabel.Size = new System.Drawing.Size(25, 13);
            this.currentHotKeyDeLabel.TabIndex = 11;
            this.currentHotKeyDeLabel.Text = "Key";
            // 
            // MainForm
            // 
            this.AcceptButton = this.apply_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 130);
            this.Controls.Add(this.currentHotKeyDeLabel);
            this.Controls.Add(this.currentHotKeyInLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onOffLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.currentCountLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.apply_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.O.S.D.C";
            this.toolTip.SetToolTip(this, "Simple On Screen Death Counter(S.O.S.D.C)\r\n");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply_Button;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label currentCountLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label onOffLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentHotKeyInLabel;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider KeyboardKeyEventProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentHotKeyDeLabel;
    }
}

