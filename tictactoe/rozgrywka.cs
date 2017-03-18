using System.Drawing;
using System.Windows.Forms;

namespace tictactoe
{
    public static class rozgrywka
    {
        public static bool gracz = true;
        public static void ZmianaPlayera(Button btn, Label Lgracz)
        {
            btn.Enabled = false;
            if (gracz == true)
            {
                btn.Text = "O";
                gracz = false;
                Lgracz.ForeColor = Color.Red;
                Lgracz.Text = "Gracz #";
            }
            else 
            {
                btn.Text = "#";
                gracz = true;
                Lgracz.ForeColor = Color.YellowGreen;
                Lgracz.Text = "Gracz O";
            }
        }
    }
}