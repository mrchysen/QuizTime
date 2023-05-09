namespace QuizTime
{
    partial class QuizWindow
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
            this.TopPanel = new System.Windows.Forms.Label();
            this.gradientPanel1 = new NewGUIElements.GradientPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SimpleButton2 = new System.Windows.Forms.Label();
            this.SimpleButton1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(782, 28);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "QuizTime v 2.0";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 45F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.comboBox1);
            this.gradientPanel1.Controls.Add(this.SimpleButton2);
            this.gradientPanel1.Controls.Add(this.SimpleButton1);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.ExitButton);
            this.gradientPanel1.Controls.Add(this.TopPanel);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(782, 553);
            this.gradientPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 424);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(740, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // SimpleButton2
            // 
            this.SimpleButton2.BackColor = System.Drawing.Color.Green;
            this.SimpleButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SimpleButton2.Location = new System.Drawing.Point(13, 485);
            this.SimpleButton2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SimpleButton2.Name = "SimpleButton2";
            this.SimpleButton2.Size = new System.Drawing.Size(472, 59);
            this.SimpleButton2.TabIndex = 6;
            this.SimpleButton2.Text = "Следующий вопрос";
            this.SimpleButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            this.SimpleButton2.MouseEnter += new System.EventHandler(this.SimpleButton_MouseEnter);
            this.SimpleButton2.MouseLeave += new System.EventHandler(this.SimpleButton_MouseLeave);
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.BackColor = System.Drawing.Color.Green;
            this.SimpleButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SimpleButton1.Location = new System.Drawing.Point(493, 485);
            this.SimpleButton1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(276, 59);
            this.SimpleButton1.TabIndex = 5;
            this.SimpleButton1.Text = "Завершить";
            this.SimpleButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            this.SimpleButton1.MouseEnter += new System.EventHandler(this.SimpleButton_MouseEnter);
            this.SimpleButton1.MouseLeave += new System.EventHandler(this.SimpleButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 344);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 300);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тут будет вопрос";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // QuizWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "QuizWindow";
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopPanel;
        private NewGUIElements.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SimpleButton2;
        private System.Windows.Forms.Label SimpleButton1;
        private System.Windows.Forms.Label label1;
    }
}