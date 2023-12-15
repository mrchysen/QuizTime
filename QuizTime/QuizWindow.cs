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

            panel1.BackColor = Color.FromArgb(191, 231, 245);
        }

        /// <summary>
        /// Подготавливает форму к новому вопросу
        /// </summary>
        /// <param name="q"></param>
        private void SetQuestion(Question q)
        {
            label1.Text = q.GetText;

            if(q is MultiQuestion mq) 
            {
                PanelYesNo.Visible = false;
                comboBox1.Visible = true;
                SimpleButton1.Size = new Size(208,48);
                SimpleButton1.Location = new Point(370, 394);
                SimpleButton2.Visible = true;

                for (int i = 0; i < mq.GetAllAnswers.Count; i++)
                {
                    comboBox1.Items.Add(mq.GetAllAnswers[i]);
                }
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                PanelYesNo.Visible = true;
                comboBox1.Visible = false;
                SimpleButton1.Size = new Size(568, 48);
                SimpleButton1.Location = new Point(10, 394);
                SimpleButton2.Visible = false;


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

        // Кнопка завершить
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы завершили тестирование. Вы набрали {RightAnswer} балл(a/ов) из {QH.Length}!!!", "Итоги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.Cancel;  
            Close();
        }

        // Кнопка Принять ответ [Логика: проверить + след. вопрос]
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            int ChosenAnswer = comboBox1.SelectedIndex + 1;

            if (QH[index].Quiz(ChosenAnswer)) 
            {
                RightAnswer++;
            }

            NextQuestion();
        }

        //Кнопка Да [Логика: проверка + след. вопрос]
        private void button1_Click(object sender, EventArgs e)
        {
            if (QH[index].Quiz(1)) RightAnswer++;
            
            NextQuestion();
        }

        //Кнопка Нет [Логика: проверка + след. вопрос]
        private void button2_Click(object sender, EventArgs e)
        {
            if (QH[index].Quiz(2)) RightAnswer++;

            NextQuestion();
        }

        /// <summary>
        /// Метод перехода к следующему вопросу
        /// </summary>
        private void NextQuestion()
        {
            index++;

            if (index < QH.Length)
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
