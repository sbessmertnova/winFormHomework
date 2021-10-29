using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_2
{
    public partial class GuessNumber : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int numberOfAttempts;
        public GuessNumber()
        {
            InitializeComponent();
            CheckGuessedNumberButton.Text = "Проверить";
            GuessedNumberResultLabel.Text = "";
            computerNumber = random.Next(0, 101);
            numberOfAttempts = 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckGuessedNumberButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(GuessedNumberTextLabel.Text, out int number))
            {
                numberOfAttempts++;
                if (number == computerNumber)
                {
                    GuessedNumberResultLabel.Text = $"ВЫ ВЫИГРАЛИ! \nКОМПЬЮТЕР ЗАГАДАЛ ЧИСЛО {computerNumber}. \nКОЛИЧЕСТВО ПОПЫТОК: {numberOfAttempts}";
                }
                else if (number<computerNumber)
                {
                    GuessedNumberResultLabel.Text = "Компьютер загадал большее число";
                }
                else
                {
                    GuessedNumberResultLabel.Text = "Компьютер загадал меньшее число";
                }
            }
            else
            {
                MessageBox.Show($"Вы ввели некоррекстное число", "Ввод числа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuessedNumberTextLabel_TextChanged(object sender, EventArgs e)
        {
            if (GuessedNumberTextLabel.Text == string.Empty)
            {
                CheckGuessedNumberButton.Enabled = false;
            }      
        }
    }
}
