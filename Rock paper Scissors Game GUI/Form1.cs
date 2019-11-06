using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_paper_Scissors_Game_GUI
{
    public partial class Form1 : Form
    {
        public static int round;
        public static int players;
        bool Checkstate = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Round1_CheckedChanged(object sender, EventArgs e)
        {

            Round3.Checked = false;
            Round5.Checked = false;
            Round7.Checked = false;
            Round9.Checked = false;
        }

        private void Round3_CheckedChanged(object sender, EventArgs e)
        {
            Round1.Checked = false;
            Round5.Checked = false;
            Round7.Checked = false;
            Round9.Checked = false;
        }

        private void Round5_CheckedChanged(object sender, EventArgs e)
        {
            Round1.Checked = false;
            Round3.Checked = false;
            Round7.Checked = false;
            Round9.Checked = false;
        }

        private void Round7_CheckedChanged(object sender, EventArgs e)
        {
            Round1.Checked = false;
            Round3.Checked = false;
            Round5.Checked = false;
            Round9.Checked = false;
        }

        private void Round9_CheckedChanged(object sender, EventArgs e)
        {
            Round1.Checked = false;
            Round3.Checked = false;
            Round5.Checked = false;
            Round7.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool round1, round3, round5, round7, round9, players1, players2, players3, players4, players5;
            round1 = Convert.ToBoolean(Round1.Checked);
            round3 = Convert.ToBoolean(Round3.Checked);
            round5 = Convert.ToBoolean(Round5.Checked);
            round7 = Convert.ToBoolean(Round7.Checked);
            round9 = Convert.ToBoolean(Round9.Checked);
            players1 = Convert.ToBoolean(Players1.Checked);
            players2 = Convert.ToBoolean(Players2.Checked);
            players3 = Convert.ToBoolean(Players3.Checked);
            players4 = Convert.ToBoolean(Players4.Checked);
            players5 = Convert.ToBoolean(Players5.Checked);
            if (round1 || round3 || round5 || round7 || round9)
            {
                if (players1 || players2 || players3 || players4 || players5)
                {
                    ErrorBox.Visible = false;
                    Round1.Visible = false;
                    Round3.Visible = false;
                    Round5.Visible = false;
                    Round7.Visible = false;
                    Round9.Visible = false;
                    Players1.Visible = false;
                    Players2.Visible = false;
                    Players3.Visible = false;
                    Players4.Visible = false;
                    Players5.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    button1.Visible = false;
                    if (round1)
                        round = 1;
                    else if (round3)
                        round = 3;
                    else if (round5)
                        round = 5;
                    else if (round7)
                        round = 7;
                    else
                        round = 9;
                    if (players1)
                        players = 1;
                    else if (players2)
                        players = 2;
                    else if (players3)
                        players = 3;
                    else if (players4)
                        players = 4;
                    else
                        players = 5;
                    this.Visible = false;
                    Form2 form2 = new Form2();
                    form2.Visible = true;
                 
                   form2.label1.Text = round.ToString();  //change the text of Form2's lable1 
                    


                }
                else
                {
                    ErrorBox.Visible = true;
                }
            }
            else
            {
                ErrorBox.Visible = true;
            }

        }

        private void Players1_CheckedChanged(object sender, EventArgs e)
        {
            Players2.Checked = false;
            Players3.Checked = false;
            Players4.Checked = false;
            Players5.Checked = false;
        }

        private void Players2_CheckedChanged(object sender, EventArgs e)
        {
            Players1.Checked = false;
            Players3.Checked = false;
            Players4.Checked = false;
            Players5.Checked = false;
        }

        private void Players4_CheckedChanged(object sender, EventArgs e)
        {
            Players2.Checked = false;
            Players3.Checked = false;
            Players1.Checked = false;
            Players5.Checked = false;
        }

        private void Players5_CheckedChanged(object sender, EventArgs e)
        {
            Players2.Checked = false;
            Players3.Checked = false;
            Players4.Checked = false;
            Players1.Checked = false;
        }

        private void Players3_CheckedChanged(object sender, EventArgs e)
        {
            Players2.Checked = false;
            Players1.Checked = false;
            Players4.Checked = false;
            Players5.Checked = false;
        }

        
    }
}
