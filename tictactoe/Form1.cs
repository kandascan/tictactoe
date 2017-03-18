using System;
using System.Drawing;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public int WinO = 0;
        public int WinK = 0;
        public int Remis = 0;
        private int[] tablicaWygranych = new int[3];

        public Form1()
        {
            InitializeComponent();
            label3.ForeColor = Color.YellowGreen;
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button1, label3); 
            Wygrana.SprawdzWygrana(button1,button2,button3,button4,button5,button6,button7,button8,button9);
            tablicaWygranych = Wygrana.pobierzWynik();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button2, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button3, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button4, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button5, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button6, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button7, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button8, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            rozgrywka.ZmianaPlayera(button9, label3);
            Wygrana.SprawdzWygrana(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            tablicaWygranych = Wygrana.pobierzWynik();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset.NowaGra(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            lblWinO.Text = tablicaWygranych[0].ToString();
            lblWinK.Text = tablicaWygranych[1].ToString();
            lblRemis.Text = tablicaWygranych[2].ToString();
        }
    }
}
 