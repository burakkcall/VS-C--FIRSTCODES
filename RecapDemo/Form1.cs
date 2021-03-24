using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;     //Yükseklik     // Bu değişkenleri butonları birbirinden ayırmak için kullandık. Butonlar üst üsteydi
            int left = 0;     // Sol taraf

            for (int i = 0; i < buttons.GetUpperBound(0); i++)      // 0. boyutun en büyük alabileceği değer! Satır oluşturduk mesela bu 0. boyut oldugu için 0
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)   // i,j = 0 ŞU DEMEK: !! 0. satırın 0. sütunu !! j=1 oldugunda 0. satırın 2. butonunu gösterecek.
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;  // Soldan uzaklığı demek
                    buttons[i, j].Top = top;
                    left +=50;
                    if ((i+j)%2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;  // 2. satıra geçtiğinde top 50 artacak ve diğer satırlara geçebilecek
                left = 0;
            }

        }
    }
}

        
                 
