namespace HotKeys
{
    partial class HotKeyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxShift = new CheckBox();
            checkBoxCtrl = new CheckBox();
            checkBoxAlt = new CheckBox();
            checkBoxWin = new CheckBox();
            comboBoxLetter = new ComboBox();
            SuspendLayout();
            // 
            // checkBoxShift
            // 
            checkBoxShift.AutoSize = true;
            checkBoxShift.Checked = true;
            checkBoxShift.CheckState = CheckState.Checked;
            checkBoxShift.Location = new Point(13, 12);
            checkBoxShift.Name = "checkBoxShift";
            checkBoxShift.Size = new Size(50, 19);
            checkBoxShift.TabIndex = 0;
            checkBoxShift.Text = "Shift";
            checkBoxShift.UseVisualStyleBackColor = true;
            checkBoxShift.CheckedChanged += checkBoxShift_CheckedChanged;
            // 
            // checkBoxCtrl
            // 
            checkBoxCtrl.AutoSize = true;
            checkBoxCtrl.Checked = true;
            checkBoxCtrl.CheckState = CheckState.Checked;
            checkBoxCtrl.Location = new Point(13, 37);
            checkBoxCtrl.Name = "checkBoxCtrl";
            checkBoxCtrl.Size = new Size(45, 19);
            checkBoxCtrl.TabIndex = 1;
            checkBoxCtrl.Text = "Ctrl";
            checkBoxCtrl.UseVisualStyleBackColor = true;
            checkBoxCtrl.CheckedChanged += checkBoxCtrl_CheckedChanged;
            // 
            // checkBoxAlt
            // 
            checkBoxAlt.AutoSize = true;
            checkBoxAlt.Checked = true;
            checkBoxAlt.CheckState = CheckState.Checked;
            checkBoxAlt.Location = new Point(13, 64);
            checkBoxAlt.Name = "checkBoxAlt";
            checkBoxAlt.Size = new Size(41, 19);
            checkBoxAlt.TabIndex = 2;
            checkBoxAlt.Text = "Alt";
            checkBoxAlt.UseVisualStyleBackColor = true;
            checkBoxAlt.CheckedChanged += checkBoxAlt_CheckedChanged;
            // 
            // checkBoxWin
            // 
            checkBoxWin.AutoSize = true;
            checkBoxWin.Location = new Point(13, 89);
            checkBoxWin.Name = "checkBoxWin";
            checkBoxWin.Size = new Size(47, 19);
            checkBoxWin.TabIndex = 3;
            checkBoxWin.Text = "Win";
            checkBoxWin.UseMnemonic = false;
            checkBoxWin.UseVisualStyleBackColor = true;
            checkBoxWin.CheckedChanged += checkBoxWin_CheckedChanged;
            // 
            // comboBoxLetter
            // 
            comboBoxLetter.AllowDrop = true;
            comboBoxLetter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLetter.FormattingEnabled = true;
            comboBoxLetter.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            comboBoxLetter.Location = new Point(13, 116);
            comboBoxLetter.Name = "comboBoxLetter";
            comboBoxLetter.Size = new Size(65, 23);
            comboBoxLetter.TabIndex = 4;
            comboBoxLetter.Text = "A";
            comboBoxLetter.SelectedIndexChanged += comboBoxLetter_SelectedIndexChanged;
            // 
            // HotKeyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxLetter);
            Controls.Add(checkBoxWin);
            Controls.Add(checkBoxAlt);
            Controls.Add(checkBoxCtrl);
            Controls.Add(checkBoxShift);
            Name = "HotKeyControl";
            Size = new Size(167, 169);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxShift;
        private CheckBox checkBoxCtrl;
        private CheckBox checkBoxAlt;
        private CheckBox checkBoxWin;
        private ComboBox comboBoxLetter;
    }
}
