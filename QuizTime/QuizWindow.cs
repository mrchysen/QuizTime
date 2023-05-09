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
    public partial class QuizWindow : Form
    {
        // Поля \\
        protected QuestionsHandler QH;
        protected int index = 0;
        protected int RightAnswer = 0;

        // Конструкторы \\
        public QuizWindow(QuestionsHandler qH)
        {
            InitializeComponent();
            PrepareWindow();

            QH = qH;

            if (QH.Length > 0)
                SetQuestion(qH[index]);
            else
                Close();
        }

        // Методы \\ 
        /// <summary>
        /// Метод конфигурации окна 
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

            panel1.BackColor = Color.FromArgb(191, 231, 245);
        }

        private void SetQuestion(Question q)
        {
            label1.Text = q.GetText;

            if(q is MultiQuestion mq) 
            {
                for (int i = 0; i < mq.GetAllAnswers.Count; i++)
                {
                    comboBox1.Items.Add(mq.GetAllAnswers[i]);
                }
            }
            else
            {
                comboBox1.Items.Add("Да");
                comboBox1.Items.Add("Нет");
            }
            comboBox1.SelectedIndex = 0;
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

        // Кнопка завершить
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы завершили тестирование. Вы набрали {RightAnswer} балл(a/ов) из {QH.Length}!!!", "Итоги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.Cancel;  
            Close();
        }
        // Кнопка Следующий вопрос
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            int ChosenAnswer = comboBox1.SelectedIndex + 1;
            if (QH[index].Quiz(ChosenAnswer)) 
            {
                RightAnswer++;
            }


            index++;
            if(index < QH.Length) 
            {
                comboBox1.Items.Clear();
                SetQuestion(QH[index]);
            }
            else
            {
                MessageBox.Show($"Вы завершили тестирование. Вы набрали {RightAnswer} балл(a/ов) из {QH.Length}!!!", "Итоги", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;
                Close();
            }
        }
    }
}
