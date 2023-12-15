using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicOfApplication.QuestionsAndBoxes;


namespace QuizTime
{
    public partial class ShowQuestionsWindow : Form
    {
        // Поля \\
        private QuestionsHandler Handler;

        // Конструкторы \\
        public ShowQuestionsWindow(QuestionsHandler Qh)
        {
            InitializeComponent();
            PrepareWindow();

            Handler = Qh;
            richTextBox1.Text = Qh.GetOnlyText;
        }

        // Методы \\ 
        /// <summary>
        /// Метод конфигурации окна и элементов на нём
        /// </summary>
        private void PrepareWindow()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            gradientPanel1.ColorTop = Color.FromArgb(237, 247, 244);
            gradientPanel1.ColorBottom = Color.FromArgb(237, 247, 244);

            TopPanel.BackColor = Color.FromArgb(191, 231, 245);

            SimpleButton1.BackColor = Color.FromArgb(191, 231, 245);
            SimpleButton2.BackColor = Color.FromArgb(191, 231, 245);
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

        // Кнопка назад
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Кнопка перемешать вопросы
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Handler.ShakeQuestion();
            richTextBox1.Text = Handler.GetOnlyText;
        }
    }
}
