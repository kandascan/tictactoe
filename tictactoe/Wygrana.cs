using System.Windows.Forms;

namespace tictactoe
{
    public static class Wygrana
    {
        public static int WinO = 0;
        public static int WinK = 0;
        public static int Remis = 0;

        public static int[] tablicaWynikow = {WinO, WinK, Remis};
        private static void DisablePrzyciskow(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6,
            Button button7, Button button8, Button button9)
        {
            Button[] taButtons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            for (int i = 0; i < 9; i++)
            {
                taButtons[i].Enabled = false;
            }
        }

        public static int[] pobierzWynik()
        {
            return tablicaWynikow;
        }
        public static void SprawdzWygrana(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Wygrał gracz O", "Game Over");
                WinO++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button1.Text == "#" && button2.Text == "#" && button3.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button1.Text == "#" && button5.Text == "#" && button9.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button3.Text == "#" && button5.Text == "#" && button7.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button1.Text == "#" && button4.Text == "#" && button7.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button2.Text == "#" && button5.Text == "#" && button8.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button3.Text == "#" && button6.Text == "#" && button9.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button4.Text == "#" && button5.Text == "#" && button6.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
            else if (button7.Text == "#" && button8.Text == "#" && button9.Text == "#")
            {
                MessageBox.Show("Wygrał gracz #", "Game Over");
                WinK++;
                DisablePrzyciskow(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            }
        }
    }
}