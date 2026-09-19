using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace PizzaOrderApp
{
    public class PizzaOrderForm : Form
    {
        // Toppings - CheckBoxes (user can select more than one)
        private CheckBox chkOnions;
        private CheckBox chkGreenPepper;
        private CheckBox chkPepperoni;
        private CheckBox chkSausage;

        // Dining options - RadioButtons (user can select only one)
        private RadioButton rbPickUp;
        private RadioButton rbDelivery;
        private RadioButton rbDineIn;

        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Pizza Order Form";
            this.Size = new Size(340, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Title label
            Label lblTitle = new Label();
            lblTitle.Text = "Pizza Order Form";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(60, 20);
            this.Controls.Add(lblTitle);

            // "Select toppings" heading
            Label lblToppings = new Label();
            lblToppings.Text = "Select toppings";
            lblToppings.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblToppings.AutoSize = true;
            lblToppings.Location = new Point(30, 80);
            this.Controls.Add(lblToppings);

            // "Dining options" heading
            Label lblDining = new Label();
            lblDining.Text = "Dining options";
            lblDining.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDining.AutoSize = true;
            lblDining.Location = new Point(180, 80);
            this.Controls.Add(lblDining);

            // Toppings checkboxes
            chkOnions = new CheckBox();
            chkOnions.Text = "Onions";
            chkOnions.Location = new Point(30, 115);
            chkOnions.AutoSize = true;
            this.Controls.Add(chkOnions);

            chkGreenPepper = new CheckBox();
            chkGreenPepper.Text = "Green pepper";
            chkGreenPepper.Location = new Point(30, 145);
            chkGreenPepper.AutoSize = true;
            this.Controls.Add(chkGreenPepper);

            chkPepperoni = new CheckBox();
            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.Location = new Point(30, 175);
            chkPepperoni.AutoSize = true;
            this.Controls.Add(chkPepperoni);

            chkSausage = new CheckBox();
            chkSausage.Text = "Sausage";
            chkSausage.Location = new Point(30, 205);
            chkSausage.AutoSize = true;
            this.Controls.Add(chkSausage);

            // Dining option radio buttons
            rbPickUp = new RadioButton();
            rbPickUp.Text = "Pick up";
            rbPickUp.Location = new Point(180, 115);
            rbPickUp.AutoSize = true;
            this.Controls.Add(rbPickUp);

            rbDelivery = new RadioButton();
            rbDelivery.Text = "Delivery";
            rbDelivery.Location = new Point(180, 145);
            rbDelivery.AutoSize = true;
            this.Controls.Add(rbDelivery);

            rbDineIn = new RadioButton();
            rbDineIn.Text = "Dine in";
            rbDineIn.Location = new Point(180, 175);
            rbDineIn.AutoSize = true;
            this.Controls.Add(rbDineIn);
        }
    }
}
