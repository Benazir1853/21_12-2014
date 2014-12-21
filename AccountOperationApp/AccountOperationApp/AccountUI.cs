using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountUI : Form
    {
        public AccountUI()
        {
            InitializeComponent();
        }

        
        Amount amount1 = new Amount();
        

        private void createButton_Click(object sender, EventArgs e)
        {
             amount1.accountNo = accountNoTextBox.Text;
             amount1.name = nameTextBox.Text;
            MessageBox.Show("Account has been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           
            amount1.deposit = Convert.ToDouble(amountTextBox.Text);
            amount1.Deposit();
            MessageBox.Show("Deposited");

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount1.withdraw = Convert.ToDouble(amountTextBox.Text);
            amount1.Withdraw();
            MessageBox.Show("Withdrawn");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show( amount1.name+", Your Account No. is "+amount1.accountNo+ "and it's Balance is " +amount1.balance+ " Taka.");
        }
      
    }
}
