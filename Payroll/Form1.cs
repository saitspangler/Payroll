using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Form1 : Form
    {
        /*
         * Payroll Calculator
         * Author: Peter
         * Date: March 2023
         */
        public Form1()
        {
            InitializeComponent();
        }
        //calculate pay amount based on hours worked * rate
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal hours;  //   input - hours worked
            decimal rate;   //    input - hourly rate
            decimal payAmount;  //   output - amount earned

            // get inputs and do calculation
            hours = Convert.ToDecimal(txtHours.Text);

            rate = Convert.ToDecimal(txtRate.Text);

            //display rate
            payAmount = hours * rate;

            txtPay.Text = Convert.ToString(payAmount);
        }
    }
}
