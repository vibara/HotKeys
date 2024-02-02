namespace HotKeys
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hotKeyControl = new HotKeyControl();
            SuspendLayout();
            // 
            // hotKeyControl
            // 
            hotKeyControl.Location = new Point(47, 41);
            hotKeyControl.Name = "hotKeyControl";
            hotKeyControl.Size = new Size(94, 169);
            hotKeyControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 251);
            Controls.Add(hotKeyControl);
            Name = "MainForm";
            Text = "TEST FORM";
            ResumeLayout(false);
        }


        #endregion


        private HotKeyControl hotKeyControl;
    }
}