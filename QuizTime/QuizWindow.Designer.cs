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
            this.PanelYesNo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SimpleButton2 = new System.Windows.Forms.Label();
            this.SimpleButton1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.PanelYesNo.SuspendLayout();
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
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(586, 23);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "QuizTime v 2.0";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 45F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.PanelYesNo);
            this.gradientPanel1.Controls.Add(this.comboBox1);
            this.gradientPanel1.Controls.Add(this.SimpleButton2);
            this.gradientPanel1.Controls.Add(this.SimpleButton1);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.ExitButton);
            this.gradientPanel1.Controls.Add(this.TopPanel);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(586, 449);
            this.gradientPanel1.TabIndex = 1;
            // 
            // PanelYesNo
            // 
            this.PanelYesNo.ColumnCount = 2;
            this.PanelYesNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelYesNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelYesNo.Controls.Add(this.buttonYes, 0, 0);
            this.PanelYesNo.Controls.Add(this.buttonNo, 1, 0);
            this.PanelYesNo.Location = new System.Drawing.Point(10, 317);
            this.PanelYesNo.Name = "PanelYesNo";
            this.PanelYesNo.RowCount = 1;
            this.PanelYesNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelYesNo.Size = new System.Drawing.Size(568, 74);
            this.PanelYesNo.TabIndex = 8;
            // 
            // buttonYes
            // 
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYes.Location = new System.Drawing.Point(3, 3);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(278, 68);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNo.Location = new System.Drawing.Point(287, 3);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(278, 68);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 344);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(556, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // SimpleButton2
            // 
            this.SimpleButton2.BackColor = System.Drawing.Color.Green;
            this.SimpleButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SimpleButton2.Location = new System.Drawing.Point(10, 394);
            this.SimpleButton2.Name = "SimpleButton2";
            this.SimpleButton2.Size = new System.Drawing.Size(354, 48);
            this.SimpleButton2.TabIndex = 6;
            this.SimpleButton2.Text = "Принять ответ";
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
            this.SimpleButton1.Location = new System.Drawing.Point(10, 394);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(568, 48);
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
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 280);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 244);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тут будет вопрос";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.ExitButton.Location = new System.Drawing.Point(12, 604);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(460, 48);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuizWindow";
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.PanelYesNo.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel PanelYesNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
    }
}