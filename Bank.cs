﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppB
{
    class Bank
    {
        private List<Account> _accounts = new List<Account>();

        public List<Account> Accounts
        {
            get{return _accounts;}
            set{_accounts = value;}
        }


    }
}
