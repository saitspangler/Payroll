namespace LunchOrder
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.boxHamburger = new System.Windows.Forms.GroupBox();
            this.cbFF = new System.Windows.Forms.CheckBox();
            this.cbKMM = new System.Windows.Forms.CheckBox();
            this.cbLTO = new System.Windows.Forms.CheckBox();
            this.boxOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.hamburgerPanel = new System.Windows.Forms.Panel();
            this.pizzaPanel = new System.Windows.Forms.Panel();
            this.boxPizza = new System.Windows.Forms.GroupBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.saladPanel = new System.Windows.Forms.Panel();
            this.boxSalad = new System.Windows.Forms.GroupBox();
            this.cbBreadSticks = new System.Windows.Forms.CheckBox();
            this.cbBaconBits = new System.Windows.Forms.CheckBox();
            this.cbCroutons = new System.Windows.Forms.CheckBox();
            this.boxMainCourse.SuspendLayout();
            this.boxHamburger.SuspendLayout();
            this.boxOrderTotal.SuspendLayout();
            this.hamburgerPanel.SuspendLayout();
            this.pizzaPanel.SuspendLayout();
            this.boxPizza.SuspendLayout();
            this.saladPanel.SuspendLayout();
            this.boxSalad.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxMainCourse
            // 
            this.boxMainCourse.Controls.Add(this.rdoSalad);
            this.boxMainCourse.Controls.Add(this.rdoPizza);
            this.boxMainCourse.Controls.Add(this.rdoHamburger);
            this.boxMainCourse.Location = new System.Drawing.Point(18, 58);
            this.boxMainCourse.Margin = new System.Windows.Forms.Padding(4);
            this.boxMainCourse.Name = "boxMainCourse";
            this.boxMainCourse.Padding = new System.Windows.Forms.Padding(4);
            this.boxMainCourse.Size = new System.Drawing.Size(300, 146);
            this.boxMainCourse.TabIndex = 0;
            this.boxMainCourse.TabStop = false;
            this.boxMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(10, 99);
            this.rdoSalad.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(144, 23);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(10, 64);
            this.rdoPizza.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(144, 23);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Location = new System.Drawing.Point(10, 29);
            this.rdoHamburger.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(180, 23);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // boxHamburger
            // 
            this.boxHamburger.Controls.Add(this.cbFF);
            this.boxHamburger.Controls.Add(this.cbKMM);
            this.boxHamburger.Controls.Add(this.cbLTO);
            this.boxHamburger.Location = new System.Drawing.Point(4, 4);
            this.boxHamburger.Margin = new System.Windows.Forms.Padding(4);
            this.boxHamburger.Name = "boxHamburger";
            this.boxHamburger.Padding = new System.Windows.Forms.Padding(4);
            this.boxHamburger.Size = new System.Drawing.Size(300, 146);
            this.boxHamburger.TabIndex = 1;
            this.boxHamburger.TabStop = false;
            this.boxHamburger.Text = "Add-On Items ($0.75/each)";
            // 
            // cbFF
            // 
            this.cbFF.AutoSize = true;
            this.cbFF.Location = new System.Drawing.Point(10, 99);
            this.cbFF.Margin = new System.Windows.Forms.Padding(4);
            this.cbFF.Name = "cbFF";
            this.cbFF.Size = new System.Drawing.Size(136, 23);
            this.cbFF.TabIndex = 2;
            this.cbFF.Text = "French Fries";
            this.cbFF.UseVisualStyleBackColor = true;
            this.cbFF.CheckedChanged += new System.EventHandler(this.cbFF_CheckedChanged);
            // 
            // cbKMM
            // 
            this.cbKMM.AutoSize = true;
            this.cbKMM.Location = new System.Drawing.Point(10, 64);
            this.cbKMM.Margin = new System.Windows.Forms.Padding(4);
            this.cbKMM.Name = "cbKMM";
            this.cbKMM.Size = new System.Drawing.Size(226, 23);
            this.cbKMM.TabIndex = 1;
            this.cbKMM.Text = "Ketchup, Mustard, Mayo";
            this.cbKMM.UseVisualStyleBackColor = true;
            this.cbKMM.CheckedChanged += new System.EventHandler(this.cbKMM_CheckedChanged);
            // 
            // cbLTO
            // 
            this.cbLTO.AutoSize = true;
            this.cbLTO.Location = new System.Drawing.Point(10, 29);
            this.cbLTO.Margin = new System.Windows.Forms.Padding(4);
            this.cbLTO.Name = "cbLTO";
            this.cbLTO.Size = new System.Drawing.Size(226, 23);
            this.cbLTO.TabIndex = 0;
            this.cbLTO.Text = "Lettuce, Tomato, Onion";
            this.cbLTO.UseVisualStyleBackColor = true;
            this.cbLTO.CheckedChanged += new System.EventHandler(this.cbLTO_CheckedChanged);
            // 
            // boxOrderTotal
            // 
            this.boxOrderTotal.Controls.Add(this.txtOrderTotal);
            this.boxOrderTotal.Controls.Add(this.txtTax);
            this.boxOrderTotal.Controls.Add(this.txtSubtotal);
            this.boxOrderTotal.Controls.Add(this.lblOrderTotal);
            this.boxOrderTotal.Controls.Add(this.lbltax);
            this.boxOrderTotal.Controls.Add(this.lblSubtotal);
            this.boxOrderTotal.Location = new System.Drawing.Point(18, 271);
            this.boxOrderTotal.Margin = new System.Windows.Forms.Padding(4);
            this.boxOrderTotal.Name = "boxOrderTotal";
            this.boxOrderTotal.Padding = new System.Windows.Forms.Padding(4);
            this.boxOrderTotal.Size = new System.Drawing.Size(300, 146);
            this.boxOrderTotal.TabIndex = 2;
            this.boxOrderTotal.TabStop = false;
            this.boxOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(142, 103);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(148, 26);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.Visible = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(142, 69);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(148, 26);
            this.txtTax.TabIndex = 4;
            this.txtTax.Visible = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(142, 27);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(148, 26);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.Visible = false;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(8, 106);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(126, 19);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total: ";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Location = new System.Drawing.Point(8, 70);
            this.lbltax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(90, 19);
            this.lbltax.TabIndex = 1;
            this.lbltax.Text = "Tax (5%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(8, 29);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 19);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(430, 271);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(170, 34);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(430, 326);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(430, 383);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // hamburgerPanel
            // 
            this.hamburgerPanel.Controls.Add(this.boxHamburger);
            this.hamburgerPanel.Location = new System.Drawing.Point(418, 58);
            this.hamburgerPanel.Name = "hamburgerPanel";
            this.hamburgerPanel.Size = new System.Drawing.Size(312, 158);
            this.hamburgerPanel.TabIndex = 6;
            this.hamburgerPanel.Visible = false;
            // 
            // pizzaPanel
            // 
            this.pizzaPanel.Controls.Add(this.boxPizza);
            this.pizzaPanel.Location = new System.Drawing.Point(380, 58);
            this.pizzaPanel.Name = "pizzaPanel";
            this.pizzaPanel.Size = new System.Drawing.Size(312, 158);
            this.pizzaPanel.TabIndex = 7;
            this.pizzaPanel.Visible = false;
            // 
            // boxPizza
            // 
            this.boxPizza.Controls.Add(this.cbOlives);
            this.boxPizza.Controls.Add(this.cbSausage);
            this.boxPizza.Controls.Add(this.cbPepperoni);
            this.boxPizza.Location = new System.Drawing.Point(6, 4);
            this.boxPizza.Name = "boxPizza";
            this.boxPizza.Size = new System.Drawing.Size(283, 146);
            this.boxPizza.TabIndex = 0;
            this.boxPizza.TabStop = false;
            this.boxPizza.Text = "Add-on items ($.50/each)";
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Location = new System.Drawing.Point(7, 104);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(82, 23);
            this.cbOlives.TabIndex = 2;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(7, 69);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(91, 23);
            this.cbSausage.TabIndex = 1;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(7, 34);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(109, 23);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // saladPanel
            // 
            this.saladPanel.Controls.Add(this.boxSalad);
            this.saladPanel.Location = new System.Drawing.Point(380, 58);
            this.saladPanel.Name = "saladPanel";
            this.saladPanel.Size = new System.Drawing.Size(283, 156);
            this.saladPanel.TabIndex = 8;
            this.saladPanel.Visible = false;
            // 
            // boxSalad
            // 
            this.boxSalad.Controls.Add(this.cbBreadSticks);
            this.boxSalad.Controls.Add(this.cbBaconBits);
            this.boxSalad.Controls.Add(this.cbCroutons);
            this.boxSalad.Location = new System.Drawing.Point(3, 3);
            this.boxSalad.Name = "boxSalad";
            this.boxSalad.Size = new System.Drawing.Size(273, 153);
            this.boxSalad.TabIndex = 0;
            this.boxSalad.TabStop = false;
            this.boxSalad.Text = "Add-on items ($.25/each)";
            // 
            // cbBreadSticks
            // 
            this.cbBreadSticks.AutoSize = true;
            this.cbBreadSticks.Location = new System.Drawing.Point(7, 101);
            this.cbBreadSticks.Name = "cbBreadSticks";
            this.cbBreadSticks.Size = new System.Drawing.Size(136, 23);
            this.cbBreadSticks.TabIndex = 2;
            this.cbBreadSticks.Text = "Bread Sticks";
            this.cbBreadSticks.UseVisualStyleBackColor = true;
            // 
            // cbBaconBits
            // 
            this.cbBaconBits.AutoSize = true;
            this.cbBaconBits.Location = new System.Drawing.Point(7, 59);
            this.cbBaconBits.Name = "cbBaconBits";
            this.cbBaconBits.Size = new System.Drawing.Size(118, 23);
            this.cbBaconBits.TabIndex = 1;
            this.cbBaconBits.Text = "Bacon Bits";
            this.cbBaconBits.UseVisualStyleBackColor = true;
            // 
            // cbCroutons
            // 
            this.cbCroutons.AutoSize = true;
            this.cbCroutons.Location = new System.Drawing.Point(7, 26);
            this.cbCroutons.Name = "cbCroutons";
            this.cbCroutons.Size = new System.Drawing.Size(100, 23);
            this.cbCroutons.TabIndex = 0;
            this.cbCroutons.Text = "Croutons";
            this.cbCroutons.UseVisualStyleBackColor = true;
            this.cbCroutons.CheckedChanged += new System.EventHandler(this.cbCroutons_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.saladPanel);
            this.Controls.Add(this.hamburgerPanel);
            this.Controls.Add(this.pizzaPanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.boxOrderTotal);
            this.Controls.Add(this.boxMainCourse);
            this.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Lunch Order";
            this.boxMainCourse.ResumeLayout(false);
            this.boxMainCourse.PerformLayout();
            this.boxHamburger.ResumeLayout(false);
            this.boxHamburger.PerformLayout();
            this.boxOrderTotal.ResumeLayout(false);
            this.boxOrderTotal.PerformLayout();
            this.hamburgerPanel.ResumeLayout(false);
            this.pizzaPanel.ResumeLayout(false);
            this.boxPizza.ResumeLayout(false);
            this.boxPizza.PerformLayout();
            this.saladPanel.ResumeLayout(false);
            this.boxSalad.ResumeLayout(false);
            this.boxSalad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox boxHamburger;
        private System.Windows.Forms.CheckBox cbFF;
        private System.Windows.Forms.CheckBox cbKMM;
        private System.Windows.Forms.CheckBox cbLTO;
        private System.Windows.Forms.GroupBox boxOrderTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Panel hamburgerPanel;
        private System.Windows.Forms.Panel pizzaPanel;
        private System.Windows.Forms.GroupBox boxPizza;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.Panel saladPanel;
        private System.Windows.Forms.GroupBox boxSalad;
        private System.Windows.Forms.CheckBox cbBreadSticks;
        private System.Windows.Forms.CheckBox cbBaconBits;
        private System.Windows.Forms.CheckBox cbCroutons;
    }
}

