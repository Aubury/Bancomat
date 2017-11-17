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
            Management manag = new Management("Tom");
            Collector collect = new Collector(1);
            Bancomat account = new Bancomat(456,"str.Lubarskogo, 65");

           // account.Adding += Show_Message;
            account.Adding += manag.Message;

            manag.colormess += ColorDisplay;
            collect.colormess += _ColorDisplay;


            //account.Withdrawn += Show_Message;
            account.Withdrawn += collect.Message;
            account.Withdrawn += manag.Message;




            account.Put_money(1000);
           // Console.WriteLine(account);
            account.Withdraw(150);
            account.Withdraw(500);
            account.Withdraw(600);
            Console.ReadLine();
        }
        static void ColorDisplay(object sender,string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void _ColorDisplay(object sender, string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Show_Message(object sender,String message)
        {
            Console.WriteLine(message);
        }
    }
}
