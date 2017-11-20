using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Collector
    {
     
        Bancomat _bank;
        Management _men;
        Client _cl;
        
        public int ID_Collector { get; set; }
        public Collector(int id,Bancomat b, Management m,Client c)
        {
            ID_Collector = id;
            _bank = b;
            _men = m;
            _cl = c;
            _cl.Balance_Zero += _bank_Balance_Zero;
        }

        private void _bank_Balance_Zero(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"================  Collector \"{ID_Collector}\" get massege!===================\n\n"+e.Message +"\n"+ _bank.ToString());
            //throw new NotImplementedException();
        }
    }
}
