﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        Form mainFormHandler;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainFormHandler = Application.OpenForms["Form1"];
            mainFormHandler.Size = new Size(417, 440);


            Button[,] buttons = new Button[8,8];
            int top=0;
            int left=0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i+j)%2 == 0)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }

                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
            

        }
    }
}
