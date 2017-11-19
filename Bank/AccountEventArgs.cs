using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class AccountEventArgs
    {
        public string Message { get; }
        public decimal Sum { get; }
        public decimal Rest { get; }
        public AccountEventArgs(string mess, decimal sum, decimal rest)
        {
            Message = mess;
            Sum = sum;
            Rest = rest;
        }
    }
}
