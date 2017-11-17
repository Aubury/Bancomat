using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public delegate void AccountStateHandler(object sender, string message);
    class Bancomat
    {
        public event AccountStateHandler Adding;
        public event AccountStateHandler Withdrawn;
       
        public int ID { get; set; }
        public string Address { get; set; }
        public decimal Current_amount { get; set; }
        decimal balance { get; set; } = 100;
        public override string ToString()
        {
            return $"Bancomat ID \"{ID}\"\nAddress :\\{Address}\\\nTotal amount of money = {Current_amount}$ \n";
        }
        public void Show()
        {

        }
        public Bancomat(int id, string address)
        {
            ID = id;
            Address = address;
            Current_amount = 0;
        }
        public Bancomat(int sum)
        {
            Current_amount = sum;
        }
        public void Put_money(int sum)
        {
            Current_amount += sum;
            if(Adding != null) { Adding(this,$"\nAmount {sum}$ put on account\n " + ToString());}
        }
        public void Withdraw(int sum)
        {
            if(Current_amount-sum >= balance)
            {
                Current_amount -= sum;
               // if(Withdrawn != null) {Withdrawn(this,$"\nAmount {sum}$ withdrawn from account\n "+ToString()); }
              
            }
            else
            {
                if (Withdrawn != null) { Withdrawn(this,"\nNot enough money on the account\n"+ToString()); }
             }
        }
    }
}
