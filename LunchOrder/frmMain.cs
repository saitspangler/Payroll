using System;
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

        //subtotal and total variables
        decimal subtotal = 0m;
        decimal ordertax = 0m;
        decimal finalprice = 0m;
        
        //sales tax
        const decimal salesTax = 0.05m; 
        public frmMain()
        {
            InitializeComponent();

        }

        private void priceReset()
        {
            rdoHamburger.Checked = true;
            txtOrderTotal.Visible = false;
            txtSubtotal.Visible = false;
            txtTax.Visible = false;
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPanel.Visible = false;
            saladPanel.Visible = false;
            hamburgerPanel.Visible = true;
            clearPizzaCheckboxes();
            clearSaladCheckboxes();
            hidePrices();
            subtotal = hamburgerPrice;
            txtSubtotal.Text = subtotal.ToString("c");
            ordertax = (Math.Round((subtotal * salesTax), 2));
            txtTax.Text = ordertax.ToString("c");
            finalprice = ordertax + subtotal;
            txtOrderTotal.Text = finalprice.ToString("c");
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            hamburgerPanel.Visible = false;
            saladPanel.Visible = false;
            pizzaPanel.Visible = true;
            clearHamburgerCheckboxes();
            clearSaladCheckboxes();
            hidePrices();
            subtotal = pizzaPrice;
            txtSubtotal.Text = subtotal.ToString("c");
            ordertax = (Math.Round((pizzaPrice * salesTax), 2));
            txtTax.Text = ordertax.ToString("c");
            finalprice = ordertax + pizzaPrice;
            txtOrderTotal.Text = finalprice.ToString("c");

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            hamburgerPanel.Visible = false;
            pizzaPanel.Visible = false;
            saladPanel.Visible = true;
            clearHamburgerCheckboxes();
            clearPizzaCheckboxes();
            hidePrices();
            subtotal = saladPrice;
            txtSubtotal.Text = subtotal.ToString("c");
            ordertax = (Math.Round((saladPrice * salesTax), 2));
            txtTax.Text = ordertax.ToString("c");
            finalprice = saladPrice + ordertax;
            txtOrderTotal.Text = finalprice.ToString("c");

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //show a popup with order total
            showPrices();
            MessageBox.Show("Order Total: " + finalprice.ToString("c"));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearHamburgerCheckboxes();
            clearPizzaCheckboxes();
            clearHamburgerCheckboxes();
            priceReset();
        }
        
        private void showPrices()
        {
            txtSubtotal.Visible = true;
            txtTax.Visible = true;
            txtOrderTotal.Visible = true;
        }
        private void hidePrices()
        {
            txtSubtotal.Visible = false;
            txtTax.Visible = false;
            txtOrderTotal.Visible = false;
        }
        //to update the prices when add-ons checked
        private void addCalculate(decimal addons)
        {
            subtotal += addons;
            txtSubtotal.Text = subtotal.ToString("c");
            ordertax = (Math.Round((subtotal * salesTax), 2));
            txtTax.Text = ordertax.ToString("c");
            finalprice = ordertax + subtotal;
            txtOrderTotal.Text = finalprice.ToString("c");
        }
        // to update the prices when add-ons are no longer checked
        private void subtractCalculate(decimal addons)
        {
            subtotal -= addons;
            txtSubtotal.Text = subtotal.ToString("c");
            ordertax = (Math.Round((subtotal * salesTax), 2));
            txtTax.Text = ordertax.ToString("c");
            finalprice = ordertax + subtotal;
            txtOrderTotal.Text = finalprice.ToString("c");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbLTO_CheckedChanged(object sender, EventArgs e)

        {
            //add hamburgeraddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbLTO.Checked) { addCalculate(hamburgerAddItems); }
            //subtract hamburgeraddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(hamburgerAddItems); }
        }

        private void cbKMM_CheckedChanged(object sender, EventArgs e)
        {
            //add hamburgeraddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbKMM.Checked) { addCalculate(hamburgerAddItems); }
            //subtract hamburgeraddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(hamburgerAddItems); }
        }

        private void cbFF_CheckedChanged(object sender, EventArgs e)
        {
            //add hamburgeraddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbFF.Checked) { addCalculate( hamburgerAddItems); }
            //subtract hamburgeraddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate( hamburgerAddItems); }
        }
        // functions to clear checkboxes when new radio button is checked
        private void clearHamburgerCheckboxes()
        {
            foreach (Control control in boxHamburger.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
        private void clearPizzaCheckboxes()
        {
            foreach (Control control in boxPizza.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
        private void clearSaladCheckboxes()
        {
            foreach (Control control in boxSalad.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
        private void cbCroutons_CheckedChanged(object sender, EventArgs e)
        {
            //add saladaddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbCroutons.Checked) { addCalculate(saladAddItems); }
            //subtract saladaddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(saladAddItems); }
        }

        private void cbBaconBits_CheckedChanged(object sender, EventArgs e)
        {
            //add saladaddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbBaconBits.Checked) { addCalculate(saladAddItems); }
            //subtract saladaddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(saladAddItems); }
        }

        private void cbBreadSticks_CheckedChanged(object sender, EventArgs e)
        {
            //add pizzaaddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbBreadSticks.Checked) { addCalculate(saladAddItems); }
            //subtract pizzaaddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(saladAddItems); }
        }

        private void cbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            //add pizzaaddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbPepperoni.Checked) { addCalculate(pizzaAddItems); }
            //subtract pizzaaddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(pizzaAddItems); }
        }

        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {
            //add pizzaaddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbSausage.Checked) { addCalculate(pizzaAddItems); }
            //subtract pizzaaddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(pizzaAddItems); }
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            //add pizzaaddonitems to subtotal if checked and update the subtotal and ordertax text fields
            if (cbOlives.Checked) { addCalculate(pizzaAddItems); }
            //subtract pizzaaddonitems from subtotal if unchecked and update the subtotal and ordertax text fields
            else { subtractCalculate(pizzaAddItems); }
        }
    }
}
