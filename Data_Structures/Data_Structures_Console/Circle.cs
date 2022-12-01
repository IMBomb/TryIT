using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    //Напишите код на C# для вычисления окружности, без изменения класса circle

    public sealed class _Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {//Calculator prinimaet funkciu kak type parametra 'op' (fakticheski op- funkciya s signaturoi <double, double>).
            return op(radius);// funkciya op prinimaet vnutrennii parametr radius.
        }


        public double solution()
        {
            //_Circle c = new _Circle(); // Esli iz drugogo klassa vyzyvat`
            //reshen`e 1
            var circumference = Calculate(r => 2 * Math.PI * r);
            //reshen`e 2
            //var radius = Calculate(r => r);
            //var circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
