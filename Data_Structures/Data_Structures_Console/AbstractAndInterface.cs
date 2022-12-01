using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class AbstractAndInterface
    {
        public abstract class Work// 
        {
            public int StartTime { get; set; }
            public int StopTime { set; get; }
            public Type NewTask<T>(T Condition) 
            {
                Console.WriteLine("Task {0} Seted", Condition.ToString());
                return Condition.GetType(); 
            }
            abstract public string IsWorkExcepted();
        }

        interface IMoodToExceptTask { };
        interface IPushFromBoss { 
            public static int Amount { get; set; }
            public void GiveAPush();
        };

        public class Worker: Work, IMoodToExceptTask, IPushFromBoss
        {
            public string name { get; set; }
            public int MinimalPushAmountToStartWork;

            //int IPushFromBoss.Amount { get; set; }
            //int CompareTo(Т other);

            public void GiveAPush()  { IPushFromBoss.Amount = 6; }//  push.Amount = 6; 

            public override string IsWorkExcepted()
            {
                if (MinimalPushAmountToStartWork <= IPushFromBoss.Amount) return "Task Excepted";
                return "Task is NOT Excepted";
            }

        }
    }
    //{
    //    // общий код для всех животных
    //    public abstract class АбстрактноеЖивотное // Objavlyau Abstract ()
    //    {
    //        public int Возраст { get; protected set; }
    //        public int Вес { get; protected set; }
    //        public bool Спит { get; protected set; }
    //        public void ПодатьГолос()
    //        {
    //            if (!Спит && Возраст > ВозрастПрорезанияГолоса)
    //                РеализацияПодатьГолос();
    //        }

    //        abstract protected void РеализацияПодатьГолос();
    //        protected int ВозрастПрорезанияГолоса;
    //    }

    //    interface IЖивотное // Objavlyau Interface
    //    {
    //        int ИнвентарныйНомер { get; }
    //    }

    //    interface IPersone
    //    {
    //        int ZP { get; set; }
    //        string Fire();
    //    }

    //    class Собака : АбстрактноеЖивотное
    //    {
    //        override protected void РеализацияПодатьГолос()
    //        {
    //            Гав();
    //        }
    //        public void Гав()
    //        {
    //            // реализация
    //        }
    //        public Собака() { ВозрастПрорезанияГолоса = 2; }
    //    }

    //    class Кошка : АбстрактноеЖивотное
    //    {
    //        override protected void РеализацияПодатьГолос()
    //        {
    //            Мяу();
    //        }
    //        public void Мяу()
    //        {
    //            // реализация
    //        }
    //        public Кошка() { ВозрастПрорезанияГолоса = 1; }
    //    }


    //    public abstract class ОбитательЗоопарка
    //    {
    //    }
    //    /////////////////////////////////
    //    ///

    //    class Лев : ОбитательЗоопарка, IЖивотное
    //    {
    //        public int ИнвентарныйНомер => 1;//throw new NotImplementedException();
    //    }

    //    class Зебра : ОбитательЗоопарка, IЖивотное
    //    {
    //        public int ИнвентарныйНомер => 2;//=> throw new NotImplementedException();
    //    }

    //    class Сторож : ОбитательЗоопарка, IPersone
    //    {
    //        public Сторож(int zp)
    //        {
    //            ZP = zp;
    //        }
    //        string IPersone.Fire() => {
    //            Console.WriteLine("How dere you!!?");
    //            string answer = "You can`t fire Сторож";
    //        return answer;
    //    }

    //        public int ZP { get; set; }
    //    }
    //    class Director : ОбитательЗоопарка, IPersone
    //    {
    //        string IPersone.Fire() => "You can`t fire Director";
    //        public Director(int zp) { IPersone.ZP = zp; }
    //        //public Director(int zp)
    //        //{
    //        //    ZP = zp;
    //        //}
    //        //public int ZP { get; }
    //    }

    //    // ...
    //    public LinkedList<ОбитательЗоопарка> Инвентаризация()
    //    {

    //        LinkedList<ОбитательЗоопарка> обитатели = new LinkedList<ОбитательЗоопарка>();
    //        ///Napolnit` obitatelyami raznyh klassov zapisyvaya ih inventarnyi nomer

    //        foreach (var обитатель in обитатели)
    //            if (обитатель is IЖивотное) // отделяем животных от неживотных
    //                ДобавитьЖивотное((IЖивотное)обитатель);
    //            else AddEmploee(обитатель);     
    //        return обитатели;
    //    }

    //    void ДобавитьЖивотное(IЖивотное животное) // сюда сможет попасть только животное
    //    {    //Schitaem skolko nabralos`
    //        Console.WriteLine(животное.ИнвентарныйНомер.ToString() + "Animal");
    //    }

    //    void AddEmploee(ОбитательЗоопарка emploee)
    //    {   //Schitaem skolko nabralos` i dolznost` }
    //        //emploee
    //        Console.WriteLine(emploee.ИнвентарныйНомер.ToString() + "");
    //    }

    //    void FullfillZoo()
    //    {
    //        AddEmploee()
    //    }

   // }
}
