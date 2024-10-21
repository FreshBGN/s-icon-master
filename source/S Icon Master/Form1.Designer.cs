namespace S_Icon_Master
{
    partial class SelectDirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDirForm));
            label1 = new Label();
            SelectButton = new Button();
            ParentDirText = new RichTextBox();
            SearchButton = new Button();
            ExitButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(279, 21);
            label1.TabIndex = 0;
            label1.Text = "Select the parent directory to search in:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SelectButton
            // 
            SelectButton.BackColor = Color.FromArgb(24, 0, 0);
            SelectButton.ForeColor = Color.White;
            SelectButton.Location = new Point(90, 109);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(142, 35);
            SelectButton.TabIndex = 1;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = false;
            SelectButton.Click += SelectButton_Click;
            // 
            // ParentDirText
            // 
            ParentDirText.BackColor = Color.FromArgb(24, 0, 0);
            ParentDirText.ForeColor = Color.White;
            ParentDirText.Location = new Point(22, 62);
            ParentDirText.Name = "ParentDirText";
            ParentDirText.ReadOnly = true;
            ParentDirText.Size = new Size(279, 41);
            ParentDirText.TabIndex = 3;
            ParentDirText.Text = "(None)";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(24, 0, 0);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(167, 239);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(144, 54);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search Selected";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(24, 0, 0);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(12, 239);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 54);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(222, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SelectDirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(323, 305);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(ExitButton);
            Controls.Add(SearchButton);
            Controls.Add(ParentDirText);
            Controls.Add(SelectButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectDirForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S Icon Master - Select Directory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SelectButton;
        private RichTextBox ParentDirText;
        private Button SearchButton;
        private Button ExitButton;
        private PictureBox pictureBox1;
    }
}