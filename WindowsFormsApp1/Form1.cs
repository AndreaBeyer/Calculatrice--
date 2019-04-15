using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculatrice : Form
    {
        string chiffre1 = null;
        char operateur = ' ';
        string chiffre2 = null;
        bool boolChiffre1 = true;
        double resulat;
        double chiffre1Db;
        double chiffre2Db;
        bool resultStart = false;
        
        public Calculatrice()
        {
            InitializeComponent();
            textBox1.Text = chiffre1;
        }

        private void clear()
        {
            textBox1.Text = null;
            chiffre1 = null;
            chiffre2 = null;
            chiffre1Db = 0;
            chiffre2Db = 0;
            operateur = ' ';
            boolChiffre1 = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                chiffre1Db = double.Parse(chiffre1);
            }
            catch
            {
                textBox1.Text = "erreur !";
            }
            try
            {
                chiffre2Db = double.Parse(chiffre2);
            }
            catch
            {
                textBox1.Text = "erreur !";
            }
            
            if(operateur == '+')
            {
                resulat = chiffre1Db + chiffre2Db;
            }
            if (operateur == '-')
            {
                resulat = chiffre1Db - chiffre2Db;
            }
            if (operateur == '*')
            {
                resulat = chiffre1Db * chiffre2Db;
            }
            if (operateur == '/')
            {
                resulat = chiffre1Db / chiffre2Db;
            }

            chiffre1Db = resulat;
            chiffre1 = chiffre1Db.ToString();
            chiffre2 = null;
            operateur = ' ';
            boolChiffre1 = true;
            textBox1.Text = resulat.ToString();
            chiffre1 = null;
            

        }
        private void restart()
        {
            if(textBox1.Text != resulat.ToString())
            {
                boolChiffre1 = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "1";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "1";
                textBox1.Text = chiffre2;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            restartWithResult();
            if (boolChiffre1)
            {
                
                chiffre1 += "2";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "2";
                textBox1.Text = chiffre2;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "3";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "3";
                textBox1.Text = chiffre2;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "6";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "6";
                textBox1.Text = chiffre2;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "5";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "5";
                textBox1.Text = chiffre2;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "4";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "4";
                textBox1.Text = chiffre2;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "9";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "9";
                textBox1.Text = chiffre2;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "8";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "8";
                textBox1.Text = chiffre2;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "7";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "7";
                textBox1.Text = chiffre2;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (boolChiffre1)
            {
                
                chiffre1 += "0";
                textBox1.Text = chiffre1;
            }
            else
            {
                chiffre2 += "0";
                textBox1.Text = chiffre2;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (boolChiffre1)
            {
                
                if (chiffre1 == null)
                {
                    chiffre1 += "0";
                }
                chiffre1 += ",";
                textBox1.Text = chiffre1;
            }
            else
            {
                if(chiffre2 == null)
                {
                    chiffre2 += "0";
                }
                chiffre2 += ",";
                textBox1.Text = chiffre2;
                
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (resultStart)
            {
                chiffre1Db = resulat;
            }
            operateur = '*';
            boolChiffre1 = false;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (resultStart)
            {
                chiffre1Db = resulat;
            }
            operateur = '-';
            boolChiffre1 = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultStart)
            {
                chiffre1Db = resulat;
            }
            operateur = '+';
            boolChiffre1 = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void restartWithResult()
        {
            resultStart = !(textBox1.Text == resulat.ToString());

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (resultStart)
            {
                chiffre1Db = resulat;
            }
            operateur = '/';
            boolChiffre1 = false;
        }
    }
}
