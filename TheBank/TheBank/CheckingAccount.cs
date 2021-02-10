using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    public class CheckingAccount: BankAccount
    {
        public CheckingAccount(string owner)
            : base(owner)
        {

        }
        public override decimal Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(0.25M);
            return this.Balance;
        }
        public override string ID
        {
            get
            {
                return this.m_owner + " - C ";
            }
        }
    }
}
