using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppB
{
    public class Account
    {
        private int _acctNum;

        public int acctNum
        {
            get { return _acctNum; }
            set { _acctNum = value; }
        }

        private double _balance = 0;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Account(int acctNum)
        {
            this.acctNum = acctNum;
        }

    }
}
