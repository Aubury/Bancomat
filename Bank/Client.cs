using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Client
    {
        public event EventHandler<AccountEventArgs> Withdrawn;
        Bancomat _bank;
        public string Name { get; set; }
        public decimal Sum { get; }
        public Client(string name, Bancomat b)
        {
            Name = name;
            _bank = b;
        }
        public void Message(object sender,AccountEventArgs e)
        {
            Console.WriteLine(new AccountEventArgs($"-----------------Client\"{Name}\"----------------\n" + e.ToString(),e.Sum,e.Rest));
        }
        public void Withdraw(int sum)
        {
            if (_bank.Current_amount - sum == 0)
            {
                _bank.Current_amount -= sum;
            if (Withdrawn != null) { Withdrawn(this, new AccountEventArgs("\nBancomat is empty\n" + ToString(), sum,_bank.Current_amount)); }
             
                // if(Withdrawn != null) {Withdrawn(this,$"\nAmount {sum}$ withdrawn from account\n "+ToString()); }

            }
            if(_bank.Current_amount-sum < 0)
            {
                if (Withdrawn != null) { Withdrawn(this, new AccountEventArgs("\nNot enough money on the account\n" + ToString(), sum, _bank.Current_amount)); }
            }
            else
            {
                if (Withdrawn != null)
                {
                    _bank.Current_amount -= sum;
                    Withdrawn(this, new AccountEventArgs($"---------Client  \"{Name}\" : withdraw {sum}$ -------------", sum, _bank.Current_amount));

                    //Console.WriteLine($"---------Client  \"{Name}\" : withdraw {sum}$ -------------");
                }
               
            }
        }

    }
}
