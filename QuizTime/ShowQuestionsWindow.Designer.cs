namespace QuizTime
{
    partial class ShowQuestionsWindow
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
            this.SimpleButton1 = new System.Windows.Forms.Label();
            this.SimpleButton2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.gradientPanel1.Controls.Add(this.SimpleButton1);
            this.gradientPanel1.Controls.Add(this.SimpleButton2);
            this.gradientPanel1.Controls.Add(this.richTextBox1);
            this.gradientPanel1.Controls.Add(this.ExitButton);
            this.gradientPanel1.Controls.Add(this.TopPanel);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(918, 610);
            this.gradientPanel1.TabIndex = 1;
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.BackColor = System.Drawing.Color.Green;
            this.SimpleButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.SimpleButton1.Location = new System.Drawing.Point(13, 542);
            this.SimpleButton1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(524, 59);
            this.SimpleButton1.TabIndex = 5;
            this.SimpleButton1.Text = "Перемешать вопросы";
            this.SimpleButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            this.SimpleButton1.MouseEnter += new System.EventHandler(this.SimpleButton_MouseEnter);
            this.SimpleButton1.MouseLeave += new System.EventHandler(this.SimpleButton_MouseLeave);
            // 
            // SimpleButton2
            // 
            this.SimpleButton2.BackColor = System.Drawing.Color.Green;
            this.SimpleButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.SimpleButton2.Location = new System.Drawing.Point(606, 542);
            this.SimpleButton2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SimpleButton2.Name = "SimpleButton2";
            this.SimpleButton2.Size = new System.Drawing.Size(299, 59);
            this.SimpleButton2.TabIndex = 4;
            this.SimpleButton2.Text = "Назад";
            this.SimpleButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            this.SimpleButton2.MouseEnter += new System.EventHandler(this.SimpleButton_MouseEnter);
            this.SimpleButton2.MouseLeave += new System.EventHandler(this.SimpleButton_MouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(893, 483);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.ExitButton.Location = new System.Drawing.Point(16, 743);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(613, 59);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TopPanel.Size = new System.Drawing.Size(918, 28);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "Просмотр вопросов";
            // 
            // ShowQuestionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 610);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ShowQuestionsWindow";
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NewGUIElements.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label TopPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label SimpleButton1;
        private System.Windows.Forms.Label SimpleButton2;
    }
}