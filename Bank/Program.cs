//Содать класс Банкомат.
//У него должны быть свойства:
//- Номер
//- Адрес
//- текущий остаток денег

//Методы:
//для пополнения и снятия денег

//События:
//- денег меньше определенного порога
//- попытка снять больше, чем есть остаток

//Обработчики событий:
//- отправка уведомления менеджменту
//- отправка уведомления в службу инкассации
//- отображение информации на дисплее(тольк в случае нехватки денег)

//Обработчики событий должны быть условными - только вывод на консоль соотв текста.
//Текст должен содержать номер и адрес банкомата, сумму денег на остатке - эти данные должны приходить как параметры событий

//В качестве делегатов использовать Func и/или Action



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
      
        static void Main(string[] args)
        {
           
            Bancomat account = new Bancomat(456,"str.Lubarskogo, 65");
            Client client = new Client("Bob",account);
            Management manag = new Management("Tom",account,client);
            Collector collect = new Collector(1,account,manag,client);

            account.Put_money(1000);
            Console.WriteLine("=============================================================================\n\n");
            account.Withdraw(500);
            Console.WriteLine("==============================================================================\n\n");
            account.Withdraw(200);
            Console.WriteLine("===============================================================================\n\n");
            account.Withdraw(300);
            Console.WriteLine("===============================================================================\n\n");
            account.Put_money(500);
            Console.WriteLine("===============================================================================\n\n");
            account.Withdraw(550);

            Console.ReadLine();
        }
     
    }
}
