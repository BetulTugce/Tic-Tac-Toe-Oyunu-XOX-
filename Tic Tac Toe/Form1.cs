using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char siraKimde = 'o';
        short hamle = 0;

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siraKimde = 'o';
            hamle = 0;  
            
            btn1.Enabled = true;
            btn1.Text = "";
            btn1.BackColor = Color.White;
            btn2.Enabled = true;
            btn2.Text = "";
            btn2.BackColor = Color.White;
            btn3.Enabled = true;
            btn3.Text = "";
            btn3.BackColor = Color.White;
            btn4.Enabled = true;
            btn4.Text = "";
            btn4.BackColor = Color.White;
            btn5.Enabled = true;
            btn5.Text = "";
            btn5.BackColor = Color.White;
            btn6.Enabled = true;
            btn6.Text = "";
            btn6.BackColor = Color.White;
            btn7.Enabled = true;
            btn7.Text = "";
            btn7.BackColor = Color.White;
            btn8.Enabled = true;
            btn8.Text = "";
            btn8.BackColor = Color.White;
            btn9.Enabled = true;
            btn9.Text = "";
            btn9.BackColor = Color.White;

            tableLayoutPanel1.Enabled = true;
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunculardan biri X, diğeri O sembolünü kullanmalıdır. Oyun sonunda 3 aynı sembolü arka arkaya sıralayan oyuncu " +
                "oyunu kazanır. Oyun sonunda 3 aynı sembol arka arkaya sıralanamamış ise oyun beraberedir.", 
                "Tic Tac Toe (XOX)");
        }

        //Bütün butonların click olaylarını buraya atadım..
        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Enabled = false;
            if (siraKimde == 'o')
            {
                button.BackColor = Color.Green;
                button.Text = "o";

                if (kontrol() == true)
                {
                    MessageBox.Show("Kazanan: " + siraKimde.ToString().ToUpper() + "!!");
                    tableLayoutPanel1.Enabled = false;
                }               
                else if (hamle==8)
                {
                    MessageBox.Show("Berabere!!");
                }
                siraKimde = 'x';
            }
            else if (siraKimde=='x')
            {
                button.BackColor = Color.Red;
                button.Text = "x";

                if (kontrol() == true)
                {
                    MessageBox.Show("Kazanan: " + siraKimde.ToString().ToUpper() + "!!");
                    tableLayoutPanel1.Enabled = false;
                }              
                else if (hamle == 8)
                {
                    MessageBox.Show("Berabere!!");
                }
                siraKimde = 'o';
            }
            hamle++;
        }

        private bool kontrol()
        {
            if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                   (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                   (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                   (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                   (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                   (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                   (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                   (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
