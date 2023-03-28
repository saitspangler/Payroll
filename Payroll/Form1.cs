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
        
        const decimal FULL_WEEK = 37.5m;
        const decimal OT_RATE = 1.5m;
        public Form1()
        {
            InitializeComponent();
        }
        // at the start of the application, to hide the overtime panel
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlOvertime.Visible = false;
        }

        //calculate pay amount based on hours worked * rate
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal hours;  //   input - hours worked
            decimal rate;   //    input - hourly rate
            decimal regularPay; // input - regular time pay
            decimal otPay; //       input - over time pay
            decimal payAmount;  //   output - amount earned

            // get inputs and do calculation
            hours = Convert.ToDecimal(txtHours.Text);

            rate = Convert.ToDecimal(txtRate.Text);

            //calculate pay amount
            if (hours <= FULL_WEEK)
            {
                regularPay = hours * rate;
                otPay = 0;
                pnlOvertime.Visible = false;
            }
            else // hours > FULL_WEEK so overtime applies
            {
                regularPay = FULL_WEEK * rate;
                otPay = (hours - FULL_WEEK) * rate * OT_RATE;
                pnlOvertime.Visible = true;
            }
            payAmount = regularPay + otPay;

            // display pay amount
            txtRegular.Text = regularPay.ToString("c");
            txtOvertime.Text = otPay.ToString("c");
            txtPay.Text = payAmount.ToString("c");
        }
    }
}
