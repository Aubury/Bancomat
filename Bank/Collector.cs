using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Collector
    {
        public event ColorMessage colormess;
        public int ID_Collector { get; set; }
        public Collector(int id) { ID_Collector = id; }
        public void Message(object sender, string me)
        {
            colormess(this,$"-----------------Collector \"{ID_Collector}\" get massege!-------------------\n" + me);
        }
    }
}
