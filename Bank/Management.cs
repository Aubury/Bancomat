using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public delegate void ColorMessage(object sender, string me);
   // public delegate Action<object,string> ColorMessage(object sender, string me);
    class Management
    {

        public event ColorMessage colormess;
        public string Name { get; set; }
        public Management(string name) { Name = name; }
     
        public void Message(object sender,string me)
        {
            colormess(this,$"--------------Management \"{Name}\" get massege.---------------\n" + me);
        }

    }
}
