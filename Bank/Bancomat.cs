using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bancomat
    {
      
        public event EventHandler<AccountEventArgs> Adding;
      
        public int ID { get; set; }
        public string Address { get; set; }
        public decimal Current_amount { get; set; }
        public  decimal balance { get; set; } = 100;
        public override string ToString()
        {
            return $"Bancomat ID \"{ID}\"\nAddress :\\{Address}\\\nAt the cash machine = {Current_amount}$ \n";
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
            if (Adding != null) { Adding(this, new AccountEventArgs($"Amount {sum}$ put on account\n " , sum, Current_amount)); }
         }
      
    }
}
