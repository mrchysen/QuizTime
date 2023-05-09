using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTime
{
    public partial class MainWindow : Form
    {
        // Поля \\
        protected Point LastPoint; // Для передвижения окна
        protected string PathToDirectoryWithFiles; // Путь к файлам с вопросами
        protected string ChoosenFilePath; // Путь к выбранному файлу
        protected LogicOfApplication.QuestionsAndBoxes.QuestionsHandler Qhandler;

        // Конструкторы \\
        public MainWindow()
        {
            InitializeComponent();
            PrepareWindow();

            PathToDirectoryWithFiles = "C:\\Users\\kokos\\OneDrive\\Рабочий стол\\p";
        }

        // Методы \\ 
        /// <summary>
        /// Метод конфигурации окна 
        /// </summary>
        private void PrepareWindow()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            gradientPanel1.ColorTop = Color.FromArgb(237,247,244);
            gradientPanel1.ColorBottom = Color.FromArgb(237, 247, 244);

            TopPanel.BackColor = Color.FromArgb(191,231,245);

            SimpleButton1.BackColor = Color.FromArgb(191, 231, 245);
            SimpleButton2.BackColor = Color.FromArgb(191, 231, 245);
            SimpleButton3.BackColor = Color.FromArgb(191, 231, 245);

            ExitButton.BackColor = Color.FromArgb(191, 231, 245);
        }

        // Методы для кнопки выхода (меняют цвет + функционал выхода)
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = Color.FromArgb(191, 231, 245); ;
            }
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = Color.FromArgb(141, 202, 224);
            }
        }

        // Методы для обычных кнопок (меняют цвет) 
        private void SimpleButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = Color.FromArgb(191, 231, 245);
            }
        }
        private void SimpleButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = Color.FromArgb(141, 202, 224);
            }
        }

        // Методы для передвижения окна
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        // Метод, показывающий начальное приветственное-окно
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Visible = false;

            HelloWindow Hw = new HelloWindow();
            
            Hw.ShowDialog();

            Visible = true;

        }

        // Кнопка выбора файла
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            ChooseFileWindow Cfw = new ChooseFileWindow(PathToDirectoryWithFiles);
            Cfw.ShowDialog();
            if(Cfw.DialogResult == DialogResult.OK)
            {
                ChoosenFilePath = Cfw.GetChoosenFilePath;
                TopPanel.Text = "QuizTime v 2.0 [Файл подключён]";
                Qhandler = new LogicOfApplication.QuestionsAndBoxes.QuestionsHandler();
                Qhandler.LoadFromFile(ChoosenFilePath);
            }
        }

        // Кнопка просмотра вопросов
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            if(Qhandler != null)
            {
                ShowQuestionsWindow Sqw = new ShowQuestionsWindow(Qhandler);
                Sqw.ShowDialog();
            }
            
        }

        private void SimpleButton3_Click(object sender, EventArgs e)
        {
            QuizWindow QW = new QuizWindow(Qhandler);
            QW.ShowDialog();
        }
    }
}
