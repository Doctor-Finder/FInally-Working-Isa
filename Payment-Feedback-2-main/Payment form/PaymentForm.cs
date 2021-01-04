using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_form
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CreditCardWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CreditCardPicture_Click(object sender, EventArgs e)
        {
            CreditCardPanel.Visible = true;
            DebitCardPanel.Visible = false;
            ElectronicWalletPanel.Visible = false;
        }

        private void DebitCardPicture_Click(object sender, EventArgs e)
        {

            CreditCardPanel.Visible = true;
            DebitCardPanel.Visible = false;
            ElectronicWalletPanel.Visible = false;
        }

        private void ElectronicWalletPicture_Click(object sender, EventArgs e)
        {
            CreditCardPanel.Visible = true;
            DebitCardPanel.Visible = false;
            ElectronicWalletPanel.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.ShowDialog();
        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}
