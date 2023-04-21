using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._04_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = "";
            bool validInput = false;
            int iterator = 0;
            while (!validInput)
            {
                input = Microsoft.VisualBasic.Interaction.InputBox("Введите число:", "Запрос числа");
                int num;
                if (int.TryParse(input, out num))
                {
                    validInput = true;
                }
                DialogResult rez = MessageBox.Show($"Вы хотите выйти?", "Акинатор", MessageBoxButtons.YesNo);
                if (rez != DialogResult.No)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Введите число!");
                    
                    
                }               
            }
            int min = 0;
            int max = 100000000;
            int guess = 0;
            while (min <= max)
            {
                iterator++;
                guess = (min + max) / 2;
                DialogResult rez = MessageBox.Show($"Ваше число больше {guess}?", "Акинатор", MessageBoxButtons.YesNo);
                if (rez == DialogResult.Yes)
                {
                    min = guess + 1;
                }
                else
                {
                    max = guess - 1;
                }
            }
            MessageBox.Show($"Я угадал ваше число - {guess + 1}\nПонадобилось {iterator} попыток", "Акинатор");
        }
    }
}
