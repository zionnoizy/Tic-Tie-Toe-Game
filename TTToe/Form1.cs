using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TTToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
        }
        bool turn = true;

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            checkForWinner();
        }

        private void checkForWinner()
        {
            //horizontal checks
            bool there_is_a_flag = false;

            if (A1.Text == A2.Text)
                there_is_a_flag = true;

        } //end checkForWinner
    }
}
