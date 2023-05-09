using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicOfApplication.Managers;

namespace QuizTime
{
    public partial class ChooseFileWindow : Form
    {
        // Поля \\
        protected FilesManager FilesManager;
        protected string ChoosenFile;
        protected int Index;

        // Св-ва \\
        public string GetChoosenFilePath => FilesManager.GetPathToChosenFile(Index);

        // Конструкторы \\
        public ChooseFileWindow(string PathToFilesDirectory)
        {
            InitializeComponent();
            PrepareWindow();

            FilesManager = new FilesManager(PathToFilesDirectory);
            FilesManager.LoadFilesNames();

            for (int i = 0; i < FilesManager.Length; i++)
            {
                BoxWithFileNames.Items.Add(FilesManager[i]);
            }
        }


        // Методы \\
        private void PrepareWindow()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            gradientPanel1.ColorTop = Color.FromArgb(237, 247, 244);
            gradientPanel1.ColorBottom = Color.FromArgb(237, 247, 244);

            TopPanel.BackColor = Color.FromArgb(191, 231, 245);

            AcceptButton.BackColor = Color.FromArgb(191, 231, 245);
            ExitButton.BackColor = Color.FromArgb(191, 231, 245);
        }

        // Методы для кнопки выхода (меняют цвет + функционал выхода)
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = Color.FromArgb(191, 231, 245);
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

        // Нажатие кнопки принять
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Index = BoxWithFileNames.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
