using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder

    /*
     * Lunch Order Application
     * 
     * Author: Peter Spangler
     * 
     * When: March 2023
     */
{
    public partial class frmMain : Form
    {
        //main courses prices
        const decimal hamburgerPrice = 6.95m;
        const decimal pizzaPrice = 5.95m;
        const decimal saladPrice = 4.95m;

        //add-on prices
        const decimal hamburgerAddItems = 0.75m;
        const decimal pizzaAddItems = 0.50m;
        const decimal saladAddItems = 0.25m;

        //subtotal variables
        decimal subtotal = 0m;
        decimal withoutax = 0m;
        
        //sales tax
        const decimal salesTax = 0.05m; 
        public frmMain()
        {
            InitializeComponent();

        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            decimal ordertax;
            decimal withtax;
            decimal beforetax;

            if (rdoHamburger.Checked)
            {
                pizzaPanel.Visible = false;
                saladPanel.Visible = false;
                hamburgerPanel.Visible = true;
                beforetax = subtotal += hamburgerPrice;
                foreach( Control control in boxHamburger.Controls)
                {
                    if (control is CheckBox)
                    {
                   
                        subtotal += hamburgerAddItems;
                    }
                }
                txtSubtotal.Text = beforetax.ToString();
                ordertax = (Math.Round((hamburgerPrice * salesTax), 2));
                txtTax.Text = ordertax.ToString();
                withtax = ordertax + hamburgerPrice;
                txtOrderTotal.Text = withtax.ToString();
            }
            else
            {

            }

        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            decimal ordertax;
            decimal withtax;
            hamburgerPanel.Visible = false;
            saladPanel.Visible = false;
            pizzaPanel.Visible = true;
            txtSubtotal.Text = pizzaPrice.ToString();
            ordertax = (Math.Round((pizzaPrice * salesTax), 2));
            txtTax.Text = ordertax.ToString();
            withtax= ordertax + pizzaPrice;
            txtOrderTotal.Text = withtax.ToString();

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            decimal ordertax;
            decimal withtax;
            hamburgerPanel.Visible = false;
            pizzaPanel.Visible = false;
            saladPanel.Visible = true;
            txtSubtotal.Text = subtotal.ToString();
            ordertax = (Math.Round((saladPrice * salesTax), 2));
            txtTax.Text = ordertax.ToString();
            withtax = ordertax + pizzaPrice;
            txtOrderTotal.Text = withtax.ToString();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            txtOrderTotal.Visible = true;
            txtSubtotal.Visible = true;
            txtTax.Visible = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbCroutons_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbLTO_CheckedChanged(object sender, EventArgs e)

        {

        }

        private void cbKMM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFF_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
