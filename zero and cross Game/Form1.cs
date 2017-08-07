using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zero_and_cross_Game
{
    public partial class Form1 : Form
    {
        int num=0;
        int count = 0;

        int win0 = 0;
        int winX = 0;
        int draw = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private string addText()
        {
            if(num==0)
            {
                num = 1;
                return '0'.ToString();
            }
            else
            { num = 0;
                return 'X'.ToString();
            }
        }
        private void checkwinner()
        {
            //horizontal checks
            if(A1.Text==A2.Text&&A2.Text==A3.Text&& A1.Text!=string.Empty)
            { MessageBox.Show(A3.Text+"---- WINNER ", A3.Text);panel1.Enabled = false; return; }
            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != string.Empty )
            { MessageBox.Show(B3.Text + "---- WINNER", B3.Text); panel1.Enabled = false; return; }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != string.Empty )
            { MessageBox.Show(A3.Text + "---- WINNER", A3.Text); panel1.Enabled = false; return; }

            //vertical checks
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != string.Empty )
            { MessageBox.Show(A1.Text + "---- WINNER", A1.Text); panel1.Enabled = false; return; }
            if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != string.Empty )
            { MessageBox.Show(A2.Text + "---- WINNER", A2.Text); panel1.Enabled = false; return; }
            if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != string.Empty )
            { MessageBox.Show(A3.Text + "---- WINNER ", A3.Text); panel1.Enabled = false; return; }

            //diagonal checks
            if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != string.Empty )
            { MessageBox.Show(A1.Text + "---- WINNER ", A1.Text); panel1.Enabled = false; return; }
            if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != string.Empty )
            { MessageBox.Show(A3.Text + "---- WINNER", A3.Text); panel1.Enabled = false; return; }

            if(count==9)
            { MessageBox.Show("THE MATCH IS DRAW"); }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if(A1.Text==string.Empty)
            {
                A1.Text = addText();
                 
                count++;
                checkwinner();
                
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (A2.Text == string.Empty)
            {
                A2.Text = addText();
                count++;
                checkwinner();
              
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3.Text == string.Empty)
            {
                A3.Text = addText();
                count++;
                checkwinner();
                
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.Text == string.Empty)
            {
                B1.Text = addText();
                count++;
                checkwinner();
                
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2.Text == string.Empty)
            {
                count++;
                B2.Text = addText();
                checkwinner();
              
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (B3.Text == string.Empty)
            {
                count++;
                B3.Text = addText();
                checkwinner();
                
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (C1.Text == string.Empty)
            {
                count++;
                C1.Text = addText();
                checkwinner();
              
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (C2.Text == string.Empty)
            {
                count++;
                C2.Text = addText();
                checkwinner();
               
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (C3.Text == string.Empty)
            {
                count++;
                C3.Text = addText();
                checkwinner();
                
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            num = 0;
            panel1.Enabled = true;
            try
            {
                foreach(Control c in panel1.Controls)
                {
                    Button b = (Button)c;
                    b.Text = string.Empty;
                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Developed by Malik","Ankit Malik");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
