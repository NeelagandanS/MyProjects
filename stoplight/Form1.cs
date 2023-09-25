using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoplight
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            redStopLight.Visible = true;
            yellowStopLight.Visible = false;
            greenStopLight.Visible = false;
        }
        private void Btnstart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (redStopLight.Visible == true)
            {
                redStopLight.Visible = false;
                yellowStopLight.Visible = false;
                greenStopLight.Visible = true;
            }
            else if (greenStopLight.Visible == true)
            {
                redStopLight.Visible = false;
                yellowStopLight.Visible = true;
                greenStopLight.Visible = false;
            }
            else if (yellowStopLight.Visible == true)
            {
                redStopLight.Visible = true;
                yellowStopLight.Visible = false;
                greenStopLight.Visible = false;
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (greenStopLight.Visible == true)
            {
                Car.Left = Car.Left += 15;
            }
            else if (yellowStopLight.Visible == true)
            {
                Car.Left = Car.Left += 5;

            }

        }


        private void Btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

      
    }
}
