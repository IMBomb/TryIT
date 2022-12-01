using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class TGeneric<T>
    {
        public TGeneric(T something)
        {
            Something = something;
        }

        T Something { get; set; }

        public Type TypeIs() {
            Console.WriteLine(Something.GetType().ToString());
            return Something.GetType();
        }


    }
}
