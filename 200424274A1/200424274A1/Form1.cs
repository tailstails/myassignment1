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
    public partial class ChangeCalculator : Form
    {
        public ChangeCalculator()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            //intialization of the variables

            double total = 0;

            double paid = 0;

            int toonie = 0;

            int loonie = 0;

            int quarters = 0;

            int dimes = 0;

            int nickles = 0;

            //checks to see if the text boxes for the total and paid are blank
            if(String.IsNullOrWhiteSpace (textBox1.Text) || String.IsNullOrWhiteSpace(paidBox.Text)) {

                MessageBox.Show("This text cannot be empty. Please input numbers");
                return;
            }

            //checks to see if the textboxes for the total and paid contain letters
            if(Double.TryParse(textBox1.Text, out total) == false || Double.TryParse(paidBox.Text, out paid) == false)
            {
                MessageBox.Show("Please input proper numbers. Text is not allowed");
                return;  
            }

            //checks to see if the total is greater than the paid amount
            if(Double.Parse(textBox1.Text) > Double.Parse(paidBox.Text))
            {
                MessageBox.Show("The total must be less than the amount you paid.");
                return;
            }




            //total is stored in this textbox
                total = double.Parse(textBox1.Text);

            //paid is stored in this textbox
            paid = double.Parse(paidBox.Text);

            //change box holds the diffrence of paid and total
            changeBox.Text = "$" + (paid - total).ToString();
            double change = (paid - total) * 100; 

            //to find the toonies, divide change by 200 and get the remainder
            toonie = (int)change / 200;
            tooniesBox.Text = toonie.ToString();
            change = change % 200;

            //to find the loonies, divide change by 100 and get the remainder
            loonie = (int)change / 100;
            looniesBox.Text = loonie.ToString();
            change = change % 100;

            //to find the quarters, divide change by 25 and get the remainder
            quarters = (int)change / 25;
            quartersBox.Text = quarters.ToString();
            change = change % 25;

            //to find the dimes, divide change by 10 and get the remainder
            dimes = (int)change / 10;
            change = change % 10;

            //to find the toonies, divide change by 200 and get the remainder
            nickles = (int)change / 5;
            change = change % 5;

            //if statement to determine the proper change distribution between dimes and nickels
            if (change >= 3)
            {
                nickles++;
            } //if change is greater than 3, round up

            if(nickles == 2) 
            {
                nickles = 0; dimes++;
            } //if nickles are 2, convert it to a dime

            dimesBox.Text = dimes.ToString(); //Holds the dime info in this textbox
            nickelsBox.Text = nickles.ToString(); //Holds the nickles info in this textbox
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Initializing textboxes

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
