using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class Inharitance_PolimorfismOverriding
    {

        public class Animal  // Base class (parent) //VIRTUAL !!!!!!!!!!!!!!!!!!!!  //Prodected riched from it salf and from derived (childs)
        {
            public virtual void animalSound() 
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        public class Pig : Animal  // Derived class (child) //OVERRIDE !!!!!!!!!!!!!!!!!!!!
        {
            public override void animalSound() 
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        public class Dog : Animal  // Derived class (child)  //OVERRIDE !!!!!!!!!!!!!!!!!!!!
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }








        class A
        {
            public virtual void Foo()
            {
                Console.Write("Class A");
            }
        }
        class B : A
        {
            public override void Foo()
            {
                Console.Write("Class B");
            }
        }


        public void print()
        {
            //B obj1 = new A(); //Error
            //obj1.Foo();

            B obj2 = new B();//Will print "Class B"
            obj2.Foo();

            A obj3 = new B();//Will print "Class B"
            obj3.Foo();
        }
    }
}

