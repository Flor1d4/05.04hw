using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._04
{
    public partial class Form1 : Form
    {
        public static int MessageBoxCount = 0;
        public Form1()
        {
            InitializeComponent();   
            
            MessageBoxCount++;
            string Text1 = "Моё Резюме";
            MessageBox.Show(Text1, "", MessageBoxButtons.OK);  
            
            MessageBoxCount++;
            string Text2 = "Меня зовут - Игорь Головань.";
            MessageBox.Show(Text2, "Имя", MessageBoxButtons.OK);

            MessageBoxCount++;
            string Text3 = "C++, C#, .NET, Html, Illustrator, Photoshop, PremierePro, Blender,\nКурица Терияки и Макароны по флотски.";
            MessageBox.Show(Text3, "Навыки", MessageBoxButtons.OK);

            MessageBoxCount++;
            string Text4 = "Владею немецким языком на уровне В1, английским языком на уровне B2 и так же польским на уровне B1, \nчто позволяет мне свободно общаться на этих языках.";
            MessageBox.Show(Text4, "Языки", MessageBoxButtons.OK);

            MessageBoxCount++;          
            string Text5 = "Законченное полное среднее образование - Гимназия №5.\n Незаконченное полное высшее образование - ОТУШ\"ШАГ\".";
            MessageBox.Show(Text5, "Образование", MessageBoxButtons.OK);

            MessageBoxCount++;
            string ResultText = Text1 + Text2 + Text3 + Text4 + Text5;
            double ResultCount = ResultText.Length / MessageBoxCount;
            MessageBox.Show($"{ResultCount}","Среднее число символов");
        }

      
    }
}
