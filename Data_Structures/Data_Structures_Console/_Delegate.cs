using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    public class _Delegate
    {
        delegate void Printer(); //Shablon Delegata bez parametrov i bez vozvraschenii

        public static Action action2 = new(delegate { Console.WriteLine("123456789"); }); // Prisvaivau peremennoi tipa action nekii metod

        internal static void Print_Deligates()
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });// dobavlyau 10 novyh ekzemplyarov funkcii tipa "delegate void Printer();" napolnyaya ih telami { Console.WriteLine(i); }
            }

            foreach (var printer in printers)
            {
                printer();
            }


            Func<bool> f = () => true;// Example of function that always return true "function of TRUTH"
            f();

            //Analog, but with list of  "Action" delegats
            //List<Action> actions = new List<Action>();
            //for (var count = 0; count < 10; count++)
            //{
            //    actions.Add(() => Console.WriteLine(count));
            //}
            //foreach (var action in actions)
            //{
            //    action();
            //}

            Action action3 = new(delegate { Console.WriteLine("987654321"); }); // Prisvaivau peremennoi tipa action nekii metod
            action3 = new(delegate { Console.WriteLine("1111111111"); }); //Zamenyau drugim
            action3();
        }





        delegate double calc1(double r); //Diclaration
        internal static double Circumferance(double r)
        {
            //exemple 1 with declaration outside function
            calc1 c1 = new calc1(r => 2 * Math.PI * r);

            Console.WriteLine(c1(r));

            //exemple 2: inline declaration and body fulfillment
            Func<double, double> calc2 = r => 2 * Math.PI * r;

            Console.WriteLine(calc2(r));

            return calc2(r);
        }
    }
}
//Ответ:

//Эта программа выведет число «10» десять раз.
//И вот почему: delegate добавляется циклически, однако параметр i передаётся по ссылке.
//Поэтому, по окончании цикла i равно 10, и при каждом запуске delegate будет выводиться работать с этим значением