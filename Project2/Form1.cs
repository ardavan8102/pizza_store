using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalPriceBtn_Click(object sender, EventArgs e)
        {
            int priceSize = 0, extraPrice, totalPrice, extra = 0;
            int friesPrice, saladPrice, waterPrice, cocaPrice;

            if (radioSmall.Checked == true)
                priceSize = Convert.ToInt32(pizzaSmall.Text);
            if (radioMedium.Checked == true)
                priceSize = Convert.ToInt32(pizzaMedium.Text);
            if (radioLarge.Checked == true)
                priceSize = Convert.ToInt32(pizzaLarge.Text);

            for (int i = 0; i < itemBox.Items.Count; i++)
                if (itemBox.GetItemChecked(i))
                    extra += 1;
            extraPrice = extra * Convert.ToInt32(extraMon.Text);

            friesPrice = Convert.ToInt32(friesNum.Text) * Convert.ToInt32(friesMon.Text);
            friesTotal.Text = friesPrice.ToString();

            saladPrice = Convert.ToInt32(saladNum.Text) * Convert.ToInt32(SaladMon.Text);
            saladTotal.Text = saladPrice.ToString();

            waterPrice = Convert.ToInt32(waterNum.Text) * Convert.ToInt32(waterMon.Text);
            waterTotal.Text = waterPrice.ToString();

            cocaPrice = Convert.ToInt32(cocaNum.Text) * Convert.ToInt32(cocaMon.Text);
            cocaTotal.Text = cocaPrice.ToString();

            totalPrice = priceSize + extraPrice + friesPrice +
                saladPrice + waterPrice + cocaPrice;
            if (sendHome.Checked)
                totalPrice += 10000; // + 10 , 000

            label1.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = totalPrice.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message1 = "Submit Your Order ?!";
            string title1 = "Order No . 229";
            MessageBoxButtons button1 = MessageBoxButtons.YesNo;
            MessageBoxIcon icon1 = MessageBoxIcon.Question;

            DialogResult result1 = MessageBox.Show(message1, title1, button1, icon1);

            if (result1 == DialogResult.Yes)
            {
                string message2 = "Your Order Submitted !";
                string title2 = "Order No . 229";
                MessageBoxButtons button2 = MessageBoxButtons.OK;
                MessageBoxIcon icon2 = MessageBoxIcon.Exclamation;

                DialogResult result2 = MessageBox.Show(message2, title2, button2, icon2);
            }
        }
    }
}
