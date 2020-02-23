using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200424274A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double total = 0;

            double paid = 0;

            int toonie = 0;

            int loonie = 0;

            int quarters = 0;

            int dimes = 0;

            int nickles = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            paidBox.Text = "";

            changeBox.Text = "";

            tooniesBox.Text = "";

            looniesBox.Text = "";

            quartersBox.Text = "";

            dimesBox.Text = "";

            nickelsBox.Text = "";
        }
    }
}
