using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class EnumerateChars
    {
        public EnumerateChars(string word)
        {
            Word = word;
        }
        public string Word { get; set; }

        public void One()
        {
            IEnumerator wordCharEnumerator = Word.ToCharArray().GetEnumerator(); // получаем IEnumerator
            while (wordCharEnumerator.MoveNext())   // пока не будет возвращено false
            {
                char item = (char)wordCharEnumerator.Current; // получаем элемент на текущей позиции
                Console.WriteLine(item);
            }
            wordCharEnumerator.Reset(); // сбрасываем указатель в начало массива
        }
    }
}

