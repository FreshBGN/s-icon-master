namespace S_Icon_Master
{
    partial class ConsoleForm
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
            DirList = new ListBox();
            SuspendLayout();
            // 
            // DirList
            // 
            DirList.BackColor = Color.FromArgb(24, 0, 0);
            DirList.ForeColor = Color.White;
            DirList.FormattingEnabled = true;
            DirList.ItemHeight = 15;
            DirList.Items.AddRange(new object[] { "Starting S Icon Master...", "Ready!" });
            DirList.Location = new Point(1, 1);
            DirList.Name = "DirList";
            DirList.Size = new Size(531, 229);
            DirList.TabIndex = 8;
            // 
            // ConsoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(533, 231);
            ControlBox = false;
            Controls.Add(DirList);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ConsoleForm";
            Text = "ConsoleForm";
            ResumeLayout(false);
        }

        #endregion

        public ListBox DirList;
    }
}