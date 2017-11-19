using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
  // public delegate void ColorMessage(object sender, string me);
   // public delegate Action<object,string> ColorMessage(object sender, string me);
    class Management
    {
        Bancomat _bank;
        Client _client;
        //public event ColorMessage colormess;
        public string Name { get; set; }
        public Management(string name, Bancomat b,Client c)
        {
            Name = name;
            _bank = b;
            _client = c;
            _bank.Adding += _bank_Adding;
            _client.Withdrawn += _client_Withdrawn;

        }

        private void _client_Withdrawn(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"-------------Management\"{Name}\" get massage---------------\n\n" + _bank.ToString()+ $"\nClient {_client.Name} withdraw money \n");
           // Console.WriteLine($"Client {_client.Name} withdraw money" );
            // throw new NotImplementedException();
        }

        private void _bank_Adding(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"-------------Management\"{Name}\" get massage---------------\n" + sender.ToString());
            //throw new NotImplementedException();
        }

        //public void Message(object sender,string me)
        //{
        //    colormess(this,$"--------------Management \"{Name}\" get massege.---------------\n" + me);
        //}

    }
}
