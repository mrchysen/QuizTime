namespace QuizTime
{
    partial class ChooseFileWindow
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
            this.gradientPanel1 = new NewGUIElements.GradientPanel();
            this.BoxWithFileNames = new System.Windows.Forms.ComboBox();
            this.AcceptButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 45F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.BoxWithFileNames);
            this.gradientPanel1.Controls.Add(this.AcceptButton);
            this.gradientPanel1.Controls.Add(this.ExitButton);
            this.gradientPanel1.Controls.Add(this.TopPanel);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 814);
            this.gradientPanel1.TabIndex = 1;
            // 
            // BoxWithFileNames
            // 
            this.BoxWithFileNames.FormattingEnabled = true;
            this.BoxWithFileNames.Location = new System.Drawing.Point(12, 40);
            this.BoxWithFileNames.Name = "BoxWithFileNames";
            this.BoxWithFileNames.Size = new System.Drawing.Size(776, 24);
            this.BoxWithFileNames.TabIndex = 4;
            this.BoxWithFileNames.Text = "Для доступа к файлам нажмите сюда";
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Green;
            this.AcceptButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.AcceptButton.Location = new System.Drawing.Point(13, 675);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(774, 59);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            this.AcceptButton.MouseEnter += new System.EventHandler(this.SimpleButton_MouseEnter);
            this.AcceptButton.MouseLeave += new System.EventHandler(this.SimpleButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.ExitButton.Location = new System.Drawing.Point(13, 746);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(774, 59);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 28);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "Окно выбора файла";
            // 
            // ChooseFileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 814);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ChooseFileWindow";
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopPanel;
        private NewGUIElements.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label AcceptButton;
        private System.Windows.Forms.ComboBox BoxWithFileNames;
    }
}