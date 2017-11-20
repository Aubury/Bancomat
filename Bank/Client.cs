using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Client
    {
        public event EventHandler<AccountEventArgs> Balance_Zero;
        public event EventHandler<AccountEventArgs> Withdrawn;
        Bancomat _bank;
        public string Name { get; set; }
        public Client(string name, Bancomat b)
        {
            Name = name;
            _bank = b;
            
        }
        public void Message(object sender,AccountEventArgs e)
        {
            if (_bank.Current_amount - e.OperationSum == 0) { Console.WriteLine();}
            if (_bank.Current_amount - e.OperationSum < 0) { Console.WriteLine(); }
            else
            {
                Console.WriteLine(new AccountEventArgs($"-----------------Client\"{Name}\"----------------\n" + e.ToString(), e.Rest, e.OperationSum));
            } 
        }
        public void Withdraw(int sum)
        {

            if (_bank.Current_amount-sum < 0)
            {
                if (Balance_Zero != null) { Balance_Zero(this, new AccountEventArgs("\nNot enough money in the ATM\n" + ToString(), _bank.Current_amount, sum)); }
            }
           
            if (_bank.Current_amount - sum == 0)
            {
                _bank.Current_amount -= sum;
            if (Balance_Zero != null) {Balance_Zero(this, new AccountEventArgs($"---------------  Client  \"{Name}\" : withdraw {sum}$ -------------\n\n**************** Bancomat is empty ***************\n\n" + ToString(),_bank.Current_amount,sum)); }
            }

            else
            {
                if (Withdrawn != null)
                {
                    _bank.Current_amount -= sum;
                    Withdrawn(this, new AccountEventArgs($"---------------  Client  \"{Name}\" : withdraw {sum}$ -------------\n", _bank.Current_amount, sum));

                }
               
            }
        }

    }
}
