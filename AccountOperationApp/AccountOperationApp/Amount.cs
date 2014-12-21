using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Amount
    {
        public string accountNo;
        public string name;
        public double deposit;
        public double withdraw;
        public double balance =0;

        public double Deposit()
        {
             balance =  balance + deposit;
            return balance;
        }

        public double Withdraw()
        {
           balance= balance - withdraw;
            return balance;
        }
    }
}
