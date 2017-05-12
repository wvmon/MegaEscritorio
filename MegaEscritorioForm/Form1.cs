using System;
using System.Windows.Forms;

namespace MegaEscritorioForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string width = wid.Text;
            string length = len.Text;
            string numDrawers = numberDrawers.Text;
            string material = surfaceMaterial.Text;
            string rushDays = numberDays.Text;

            try
            {
                Desk myDesk = new Desk(Convert.ToDouble(width), Convert.ToDouble(length), Convert.ToInt16(numDrawers), material.ToLower());
                Order newOrder = new Order(myDesk, Convert.ToInt16(rushDays));
                double orderTotal = newOrder.getTotalPrice();

                string totalFormat = $"{orderTotal:C}";
                total.Text = "Total: " + totalFormat;
                newOrder.WriteFile();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Data");
            }
        }
    }
}
