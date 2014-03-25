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
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hotKeyComboBox = new System.Windows.Forms.ComboBox();
            this.applySettingButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currentHotKeyLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.reverseTextOrder = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.endTagTextBox = new System.Windows.Forms.TextBox();
            this.startTagTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Tag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Tag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HotKey:";
            // 
            // hotKeyComboBox
            // 
            this.hotKeyComboBox.FormattingEnabled = true;
            this.hotKeyComboBox.Location = new System.Drawing.Point(5, 94);
            this.hotKeyComboBox.Name = "hotKeyComboBox";
            this.hotKeyComboBox.Size = new System.Drawing.Size(81, 21);
            this.hotKeyComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.hotKeyComboBox, "Select the hotkey you want to use.");
            // 
            // applySettingButton
            // 
            this.applySettingButton.Location = new System.Drawing.Point(3, 167);
            this.applySettingButton.Name = "applySettingButton";
            this.applySettingButton.Size = new System.Drawing.Size(81, 23);
            this.applySettingButton.TabIndex = 6;
            this.applySettingButton.Text = "Apply";
            this.toolTip1.SetToolTip(this.applySettingButton, "Saves The settings and closes the settings dialog");
            this.applySettingButton.UseVisualStyleBackColor = true;
            this.applySettingButton.Click += new System.EventHandler(this.applySettingButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current HotKey:";
            // 
            // currentHotKeyLabel
            // 
            this.currentHotKeyLabel.AutoSize = true;
            this.currentHotKeyLabel.Location = new System.Drawing.Point(84, 151);
            this.currentHotKeyLabel.Name = "currentHotKeyLabel";
            this.currentHotKeyLabel.Size = new System.Drawing.Size(25, 13);
            this.currentHotKeyLabel.TabIndex = 8;
            this.currentHotKeyLabel.Text = "Key";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 167);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelButton, "Saves nothing and closes dialog.");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lockPicture
            // 
            this.lockPicture.Image = global::SimpleOnScreenDeathCounter.Properties.Resources.lock_open;
            this.lockPicture.InitialImage = null;
            this.lockPicture.Location = new System.Drawing.Point(90, 81);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(48, 48);
            this.lockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lockPicture.TabIndex = 14;
            this.lockPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.lockPicture, "Click to unlock to change hotkey.Unlocked on first use of\r\nS.O.S.D.C Will be lock" +
        "ed when Apply or Cancel is clicked.\r\n");
            this.lockPicture.Click += new System.EventHandler(this.LockPicture_Click);
            // 
            // reverseTextOrder
            // 
            this.reverseTextOrder.AutoSize = true;
            this.reverseTextOrder.Checked = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.ReverseOrder;
            this.reverseTextOrder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "ReverseOrder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reverseTextOrder.Location = new System.Drawing.Point(4, 131);
            this.reverseTextOrder.Name = "reverseTextOrder";
            this.reverseTextOrder.Size = new System.Drawing.Size(119, 17);
            this.reverseTextOrder.TabIndex = 12;
            this.reverseTextOrder.Text = "Reverse Text Order";
            this.toolTip1.SetToolTip(this.reverseTextOrder, "When Checked The Message and Count will be Reversed.\r\nExample: Off : Message:Coun" +
        "t. On: Count:Message.\r\n");
            this.reverseTextOrder.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.SaveCount;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "SaveCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(4, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Save Count.";
            this.toolTip1.SetToolTip(this.checkBox1, "When checked it will save the count when program closed.Good for when\r\nyou need t" +
        "o end your stream/recording session and want to keep the \r\nthe count.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // endTagTextBox
            // 
            this.endTagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "XsplitObsEndTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.endTagTextBox.Location = new System.Drawing.Point(5, 58);
            this.endTagTextBox.Name = "endTagTextBox";
            this.endTagTextBox.Size = new System.Drawing.Size(157, 20);
            this.endTagTextBox.TabIndex = 1;
            this.endTagTextBox.Text = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.XsplitObsEndTag;
            this.toolTip1.SetToolTip(this.endTagTextBox, "End Tag for use in Xsplit. Remove text for use in OBS");
            // 
            // startTagTextBox
            // 
            this.startTagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "XsplitObsStartTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startTagTextBox.Location = new System.Drawing.Point(5, 19);
            this.startTagTextBox.Name = "startTagTextBox";
            this.startTagTextBox.Size = new System.Drawing.Size(157, 20);
            this.startTagTextBox.TabIndex = 0;
            this.startTagTextBox.Text = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.XsplitObsStartTag;
            this.toolTip1.SetToolTip(this.startTagTextBox, "Stat Tag for use in Xsplit. Remove text for use in OBS");
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.applySettingButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 193);
            this.Controls.Add(this.lockPicture);
            this.Controls.Add(this.reverseTextOrder);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.currentHotKeyLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.applySettingButton);
            this.Controls.Add(this.hotKeyComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTagTextBox);
            this.Controls.Add(this.startTagTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S.O.S.D.C: Settings";
            this.toolTip1.SetToolTip(this, "Simple On Screen Death Counter(S.O.S.D.C):Settings");
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startTagTextBox;
        private System.Windows.Forms.TextBox endTagTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hotKeyComboBox;
        private System.Windows.Forms.Button applySettingButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentHotKeyLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox reverseTextOrder;
        private System.Windows.Forms.PictureBox lockPicture;
    }
}