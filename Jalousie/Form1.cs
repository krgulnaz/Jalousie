using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jalousie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.aluminumRadioButton.Checked = false;
        }

        private void widthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (widthTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (heightTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((this.widthTextBox.Text.Length == 0) || (this.heightTextBox.Text.Length == 0) ||
                 (this.widthTextBox.Text == ",") || (this.heightTextBox.Text == ","))
            {
                this.okButton.Enabled = false;
            }
            else
            {
                this.okButton.Enabled = true;
            }
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((this.heightTextBox.Text.Length == 0) || (this.heightTextBox.Text.Length == 0) ||
                 (this.heightTextBox.Text == ",") || (this.heightTextBox.Text == ","))
            {
                this.okButton.Enabled = false;
            }
            else
            {
                this.okButton.Enabled = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Single width = Convert.ToSingle(this.widthTextBox.Text);
            Single height = Convert.ToSingle(this.heightTextBox.Text);
            Single S = width * height / 10000;
            Single C, price;

            if (this.plasticRadioButton.Checked)
            {
                C = 3600;
            }
            else
            {
                C = 1800;
            }
            price = S * C;

            if (this.aluminumRadioButton.Checked)
            {
                this.resultLabel.Text = "The size: " + width.ToString("N") +
               " x " + height.ToString("N") + " sm/n" + "\nMaterial: " + this.aluminumRadioButton.Text +
               "\nThe price: " + price.ToString("C");
            }
            else
            {
                this.resultLabel.Text = "The size: " + width.ToString("N") +
               " x " + height.ToString("N") + " sm/n" + "\nMaterial: " + this.plasticRadioButton.Text +
               "\nThe price: " + price.ToString("C");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
