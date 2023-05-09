
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTime
{
    public partial class HelloWindow : Form
    {
        // Поля \\
        private Point LastPoint;

        // Конструктор \\ 
        public HelloWindow()
        {
            InitializeComponent();
            PrepareWindow();

            timer1.Enabled = true;
            timer1.Interval = 4000;
        }

        // Методы \\
        /// <summary>
        /// Метод конфигурации окна 
        /// </summary>
        private void PrepareWindow()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Logo.Location = new Point(this.Width / 2 - Logo.Size.Width / 2, this.Height / 2 - Logo.Size.Height / 2 );

            gradientPanel1.ColorTop = Color.FromArgb(141, 202, 224);
            gradientPanel1.ColorBottom = Color.FromArgb(191, 231, 245);
        }

        // Методы для передвижения окна 
        private void gradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Метод таймера, чтобы формула выкючилась через определённое время
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();

            Close();
        }
    }
}
