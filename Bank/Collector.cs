using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Collector
    {
      //  public event ColorMessage colormess;
        Bancomat _bank;
        Management _men;
        
        public int ID_Collector { get; set; }
        public Collector(int id,Bancomat b, Management m)
        {
            ID_Collector = id;
            _bank = b;
            _men = m;

           
        }
     
        //public void Message(object sender, string me)
        //{
        //    colormess(this,$"-----------------Collector \"{ID_Collector}\" get massege!-------------------\n" + me);
        //}
    }
}
