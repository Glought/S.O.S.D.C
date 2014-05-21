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
            this.hotKeyInComboBox = new System.Windows.Forms.ComboBox();
            this.applySettingButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currentHotKeyInLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.endTagTextBox = new System.Windows.Forms.TextBox();
            this.startTagTextBox = new System.Windows.Forms.TextBox();
            this.OBSToggleCheckBox = new System.Windows.Forms.CheckBox();
            this.reverseTextOrder = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hotKeyDeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentHotKeyDeLabel = new System.Windows.Forms.Label();
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
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HotKey Increment:";
            // 
            // hotKeyInComboBox
            // 
            this.hotKeyInComboBox.FormattingEnabled = true;
            this.hotKeyInComboBox.Location = new System.Drawing.Point(5, 94);
            this.hotKeyInComboBox.Name = "hotKeyInComboBox";
            this.hotKeyInComboBox.Size = new System.Drawing.Size(81, 21);
            this.hotKeyInComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.hotKeyInComboBox, "Select the hotkey you want to use.");
            // 
            // applySettingButton
            // 
            this.applySettingButton.Location = new System.Drawing.Point(5, 237);
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
            this.label4.Location = new System.Drawing.Point(1, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current HotKey Increment:";
            // 
            // currentHotKeyInLabel
            // 
            this.currentHotKeyInLabel.AutoSize = true;
            this.currentHotKeyInLabel.Location = new System.Drawing.Point(137, 208);
            this.currentHotKeyInLabel.Name = "currentHotKeyInLabel";
            this.currentHotKeyInLabel.Size = new System.Drawing.Size(25, 13);
            this.currentHotKeyInLabel.TabIndex = 8;
            this.currentHotKeyInLabel.Text = "Key";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 237);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelButton, "Saves nothing and closes dialog.");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // endTagTextBox
            // 
            this.endTagTextBox.Location = new System.Drawing.Point(5, 58);
            this.endTagTextBox.Name = "endTagTextBox";
            this.endTagTextBox.Size = new System.Drawing.Size(157, 20);
            this.endTagTextBox.TabIndex = 1;
            this.endTagTextBox.Text = "</xsplit>";
            this.toolTip1.SetToolTip(this.endTagTextBox, "End Tag for use in Xsplit. Remove text for use in OBS");
            // 
            // startTagTextBox
            // 
            this.startTagTextBox.Location = new System.Drawing.Point(5, 19);
            this.startTagTextBox.Name = "startTagTextBox";
            this.startTagTextBox.Size = new System.Drawing.Size(157, 20);
            this.startTagTextBox.TabIndex = 0;
            this.startTagTextBox.Text = "<xsplit>";
            this.toolTip1.SetToolTip(this.startTagTextBox, "Stat Tag for use in Xsplit. Remove text for use in OBS");
            // 
            // OBSToggleCheckBox
            // 
            this.OBSToggleCheckBox.AutoSize = true;
            this.OBSToggleCheckBox.Checked = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.OBSToggle;
            this.OBSToggleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "OBSToggle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OBSToggleCheckBox.Location = new System.Drawing.Point(5, 189);
            this.OBSToggleCheckBox.Name = "OBSToggleCheckBox";
            this.OBSToggleCheckBox.Size = new System.Drawing.Size(84, 17);
            this.OBSToggleCheckBox.TabIndex = 13;
            this.OBSToggleCheckBox.Text = "OBS Toggle";
            this.toolTip1.SetToolTip(this.OBSToggleCheckBox, "When Checked Start and end tags are ignored and disabled.\r\n");
            this.OBSToggleCheckBox.UseVisualStyleBackColor = true;
            this.OBSToggleCheckBox.CheckStateChanged += new System.EventHandler(this.OBSToggleCheckBox_CheckStateChanged);
            // 
            // reverseTextOrder
            // 
            this.reverseTextOrder.AutoSize = true;
            this.reverseTextOrder.Checked = global::SimpleOnScreenDeathCounter.Properties.Settings.Default.ReverseOrder;
            this.reverseTextOrder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SimpleOnScreenDeathCounter.Properties.Settings.Default, "ReverseOrder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reverseTextOrder.Location = new System.Drawing.Point(5, 173);
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
            this.checkBox1.Location = new System.Drawing.Point(5, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Save Count.";
            this.toolTip1.SetToolTip(this.checkBox1, "When checked it will save the count when program closed.Good for when\r\nyou need t" +
                    "o end your stream/recording session and want to keep the \r\nthe count.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // hotKeyDeComboBox
            // 
            this.hotKeyDeComboBox.FormattingEnabled = true;
            this.hotKeyDeComboBox.Location = new System.Drawing.Point(4, 134);
            this.hotKeyDeComboBox.Name = "hotKeyDeComboBox";
            this.hotKeyDeComboBox.Size = new System.Drawing.Size(81, 21);
            this.hotKeyDeComboBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.hotKeyDeComboBox, "Select the hotkey you want to use.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "HotKey Decrement:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Current HotKey Decrement:";
            // 
            // currentHotKeyDeLabel
            // 
            this.currentHotKeyDeLabel.AutoSize = true;
            this.currentHotKeyDeLabel.Location = new System.Drawing.Point(137, 221);
            this.currentHotKeyDeLabel.Name = "currentHotKeyDeLabel";
            this.currentHotKeyDeLabel.Size = new System.Drawing.Size(25, 13);
            this.currentHotKeyDeLabel.TabIndex = 8;
            this.currentHotKeyDeLabel.Text = "Key";
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.applySettingButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hotKeyDeComboBox);
            this.Controls.Add(this.OBSToggleCheckBox);
            this.Controls.Add(this.reverseTextOrder);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.currentHotKeyDeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentHotKeyInLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.applySettingButton);
            this.Controls.Add(this.hotKeyInComboBox);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.O.S.D.C: Settings";
            this.toolTip1.SetToolTip(this, "Simple On Screen Death Counter(S.O.S.D.C):Settings");
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startTagTextBox;
        private System.Windows.Forms.TextBox endTagTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hotKeyInComboBox;
        private System.Windows.Forms.Button applySettingButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentHotKeyInLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox reverseTextOrder;
        private System.Windows.Forms.CheckBox OBSToggleCheckBox;
        private System.Windows.Forms.ComboBox hotKeyDeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentHotKeyDeLabel;
    }
}