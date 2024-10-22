namespace S_Icon_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            ApplyButton = new Button();
            ExitButton = new Button();
            DirList = new ListBox();
            pictureBox1 = new PictureBox();
            hideCheckBox = new CheckBox();
            ConsoleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(219, 42);
            label1.TabIndex = 1;
            label1.Text = "The following directories were\r\ndetected to contain icons:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ApplyButton
            // 
            ApplyButton.BackColor = Color.FromArgb(24, 0, 0);
            ApplyButton.ForeColor = Color.White;
            ApplyButton.Location = new Point(172, 607);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(144, 54);
            ApplyButton.TabIndex = 5;
            ApplyButton.Text = "Apply Icons";
            ApplyButton.UseVisualStyleBackColor = false;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(24, 0, 0);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(12, 607);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 54);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // DirList
            // 
            DirList.BackColor = Color.FromArgb(24, 0, 0);
            DirList.ForeColor = Color.White;
            DirList.FormattingEnabled = true;
            DirList.ItemHeight = 15;
            DirList.Items.AddRange(new object[] { "(None)" });
            DirList.Location = new Point(12, 83);
            DirList.Name = "DirList";
            DirList.Size = new Size(304, 499);
            DirList.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(227, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // hideCheckBox
            // 
            hideCheckBox.AutoSize = true;
            hideCheckBox.ForeColor = Color.White;
            hideCheckBox.Location = new Point(78, 588);
            hideCheckBox.Name = "hideCheckBox";
            hideCheckBox.Size = new Size(172, 19);
            hideCheckBox.TabIndex = 9;
            hideCheckBox.Text = "Hide icon file after applying";
            hideCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConsoleButton
            // 
            ConsoleButton.BackColor = Color.FromArgb(24, 0, 0);
            ConsoleButton.ForeColor = Color.White;
            ConsoleButton.Location = new Point(-1, -1);
            ConsoleButton.Name = "ConsoleButton";
            ConsoleButton.Size = new Size(58, 23);
            ConsoleButton.TabIndex = 10;
            ConsoleButton.Text = "Console";
            ConsoleButton.UseVisualStyleBackColor = false;
            ConsoleButton.Click += ConsoleButton_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(328, 673);
            ControlBox = false;
            Controls.Add(ConsoleButton);
            Controls.Add(hideCheckBox);
            Controls.Add(pictureBox1);
            Controls.Add(DirList);
            Controls.Add(ExitButton);
            Controls.Add(ApplyButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "S Icon Master - Apply Icons";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button ApplyButton;
        private Button ExitButton;
        private ListBox DirList;
        private PictureBox pictureBox1;
        private CheckBox hideCheckBox;
        private Button ConsoleButton;
    }
}