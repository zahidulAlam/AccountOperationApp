using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account account=new Account();
        public double withdrawAmount;
        private void create_Button(object sender, EventArgs e)
        {
            account.accountNumber = accountTextBox.Text;
            account.customerName = customerNameTextBox.Text;
            account.amount = 0;
            MessageBox.Show("Account created successfully");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
             double withdrawAmount= Convert.ToDouble(amountTextBox.Text);
            MessageBox.Show("Deposited " + account.Deposit(withdrawAmount));
            amountTextBox.Clear();

            //MessageBox.Show(Convert.ToString(account.Deposit()));
        }

        public void withdrawButton_Click(object sender, EventArgs e)
        {
            
            withdrawAmount = Convert.ToDouble(amountTextBox.Text);
            account.Withdraw(withdrawAmount);
            MessageBox.Show("Withdrawn " + withdrawAmount);
            amountTextBox.Clear();

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.customerName + "," + "your account number: " + account.accountNumber +
                            "and it's balance is "+" "+ account.amount);
        }

    }
}
