using System;
using System.Linq;
using static System.Console;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
//using static Data_Structures_Console.AbstractAndInterface;
//using static Data_Structures_Console.AbstractAndInterface;

namespace Data_Structures_Console
{

    class Program
    {
        private enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        //     return 0;
        // }
        private static string result;
        static async Task<string> SaySomething()//Asyncronnaya funkciya vozvraschaet string
        {// Большинство программистов ожидают, что функция будет выполняться от начала до конца или до return.
         // Это не относится к функциям async. Они выполняются только до первого await, а затем возвращаются к вызывающему объекту.
         // Функция, вызванная await (в данном случае Task.Delay), выполняется асинхронно, а строка после оператора ожидания не сигнализируется для выполнения, пока Task.Delay не завершится (через 5 миллисекунд).
             //await Task.Delay(5);// dohodit suda i poka ne vypolnitsya uslovie, vypuskaet is funkcii async razreshaet vypolnyat` osnovnoi kod. A kak vypolnitsa await prodolzaet pod nim. 

            Thread.Sleep(5);//Prosto priostanavlivaet na 5 milisec i idet dalshe
            result = "Hello world!";
            return "Something";
        }


        public static void Main(string[] args)
        {
            //Act S = new Act();
            //S.Interacting();

            //wr  MySort.StringChallenge("abcabc");
            //MySort.MathChallenge(78543573);
            //MySort a = new MySort();
            //int fact = MySort.FirstFactorial(5);

            //WriteLine(fact.ToString());
            int[] array2 = new int[10000000];
            for (int i = 0; i < 10000000; i++)
            {
                Random sluchainaya_velichina = new Random(); //обращение к классу случайных величин
                array2[i] = sluchainaya_velichina.Next(1, 10);
            }

            Stack<int> stk = new Stack<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                stk.Push(array2[i]);
            }

            //int []array = { 121, 432, 564, 23, 1, 45, 788 };
            ////int[] array = { 23, 1, 45};
            List<int> list2 = array2.ToList();
            MySort MyNumbs = new();
            Sorting numbs = new Sorting();

            DateTime T1 = DateTime.Now;
            MyNumbs.DoMySort(array2);
            //MyNumbs.DoMySort(stk);
            DateTime T2 = DateTime.Now;
            numbs.radixsort(array2, array2.Length);
            DateTime T3 = DateTime.Now;
            list2.Sort();
            DateTime T4 = DateTime.Now;
            ////foreach(int num in list2)
            ////{
            ////    Console.WriteLine(num.ToString() + "\n");
            ////}
            WriteLine("Listsort: " + (T4-T3).ToString() + " redix: " + (T3 - T2).ToString() + " MySort: " + (T2 - T1));
            //numbs.printArray(array2, array2.Length);



            Function[] func = new Function[3];
            func[0] = new Line(1, 2);
            func[1] = new Kub(3, 4, 5);
            func[2] = new Hyperbola(2, 3);
            double x = 11;
            foreach (Function f in func)
                Console.WriteLine("значение функции {0} для x = {1} равно {2}", f.GetType(), x, f.Count(x));
            Array.Sort(func);
            foreach (Function f in func)
                Console.WriteLine("значение функции {0} для x = {1} равно {2}", f.GetType(), x, f.Count(x));
            Console.ReadLine();






            AbstractAndInterface.Worker worker1 = new();
            worker1.NewTask<string>("'Dig'");
            worker1.StartTime = 8;
            worker1.MinimalPushAmountToStartWork = 5;
            WriteLine( worker1.IsWorkExcepted());
            worker1.GiveAPush();
            WriteLine("Push!");
            WriteLine( worker1.IsWorkExcepted());

            _Delegate.action2();
            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            {
                Debug.WriteLine(eventArgs.Exception.ToString());
            };


            _Delegate.Print_Deligates();

            SaySomething();
            Console.WriteLine(result);


            try
            {
                int t = 0;

                int[] ar = new int[] { 1, 2, 3, 4, 5 };
                //var[] ar2 = new int[5] { 1, 2, 3, 4, 5 };
                //ar[10] = 0;
            }
            catch (System.IndexOutOfRangeException ex) when (ex.Message == "Index was outside the bounds of the array.")
            {
                Console.WriteLine("TUT"); 
            }

            catch { Console.WriteLine("A teper TUT"); }

            finally
            {
                //   return 0;//error
            } 
        

            //a1(5);
            Console.WriteLine(OddEven.find_total(new int []{ 15,25,35}).ToString());
            //AbstractAndInterface Zoo = new AbstractAndInterface();
            //LinkedList<ОбитательЗоопарка> items = Zoo.Инвентаризация();
            WriteLine();

            Inharitance_PolimorfismOverriding.Animal myAnimal = new Inharitance_PolimorfismOverriding.Animal();  // Create a Animal object
            Inharitance_PolimorfismOverriding.Animal myPig = new Inharitance_PolimorfismOverriding.Pig();  // Create a Pig object
            Inharitance_PolimorfismOverriding.Animal myDog = new Inharitance_PolimorfismOverriding.Dog();  // Create a Dog object
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();


            TGeneric<string> Var1 = new TGeneric<string>("Dmytro");
            Var1.TypeIs();
            TGeneric<int> Var2 = new TGeneric<int>(71);
            Var2.TypeIs();

            EnumerateChars spellOneBy = new EnumerateChars("Dmytro");
            spellOneBy.One(); //

            //Console.WriteLine("Hello World!");
            BinaryTreeNode<int> Node1 = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> Node2 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> Node3 = new BinaryTreeNode<int>(8);

            if(Node1.CompareNode(Node2) >= 0)
            {
                Node1.Left = Node2;
            }
            else
            {
                Node1.Right = Node2;
            }

            if (Node1.CompareNode(Node3) >= 0)
            {
                Node1.Left = Node3;
            }
            else
            {
                Node1.Right = Node3;
            }

            Console.WriteLine("Left child of the Rute Node 5: {0}", Node1.Left.Value);
            Console.WriteLine("Right child of the Rute Node 5: {0}", Node1.Right.Value);

            Fibonacci instance = new Fibonacci();
            for (int n = 0; n < 10; n++)
            {
                int f = instance.FibonacciCalc(n);
                Console.WriteLine(f.ToString());
            }

            //int[] numbers = { 2, 3, 4, 5 };
            //var squaredNumbers = numbers.Select(x => x * x);
            //Console.WriteLine(string.Join(" ", squaredNumbers));

            TLinkedList<string> linkedList = new TLinkedList<string>();
            linkedList.Add("Dog");
            linkedList.Add("Cat");
            linkedList.Add("Fish");

            //foreach(var animal in linkedList) // Error w/out GetEnumerator implemented for TLinkedList

            WriteLine(linkedList.Count.ToString());
            linkedList.Remove("Dog");

            WriteLine( linkedList.Contains("Dog").ToString());
            WriteLine(linkedList.Count.ToString());

        }
    }
}
//7.Сравните структуры и классы в C#. Что они имеют общего? Как они отличаются?
//Ответ:

//Классы и структуры в C# имеют несколько общих черт, а именно:

//Являются составными типами данных
//Могут содержать методы и события
//Могут поддерживать интерфейсы
//Но есть ряд различий. Вот сравнение:

//Классы:

//Поддерживают наследование
//Ссылочные типы
//Ссылка может быть нулевой
//Могут занимать больше памяти
//Структуры:

//Не поддерживают наследование
//Типы значений
//Передаются по значению (например, целые числа)
//Не могут иметь нулевую ссылку (если не используется Nullable)
//Нет места в памяти для instance




//Кстати, если писать как настоящий мидл, то Main() должен быть примерно таким (Zadanie pro anketirovanie)
//static void Main(string[] args)
//{

//    UserInterface ui =
//        new UserInterface(
//            new ApplicationServices(
//                new DomainServices(
//                    new UserRepository(),
//                    new ProductRepository())));

//    while (ui.ReadCommand())
//    {
//        ui.ExecuteCommand();
//    }
//}