using System.Windows.Forms;

namespace tictactoe
{
    public static class reset
    {
        public static void NowaGra(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6,
            Button button7, Button button8, Button button9)
        {
            Button[] taButtons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            for (int i = 0; i < 9; i++)
            {
                taButtons[i].Enabled = true;
                taButtons[i].Text = "?";
            }
        }
    }
}