using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        protected int eyes, nose, mouth, ears;
        protected string kinds;

        public virtual void bark() {
            Console.WriteLine("강아지가 멍멍 짖어요 :)");
        }
        public void run() {
            Console.WriteLine("강아지가 쌩쌩 달려요!");
        }

        public Dog ()
        {
            eyes = 2;
            nose = 1;
            mouth = 1;
            ears = 2;
        }
    }

    public class Poodle : Dog
    {
        public Poodle()
        {
            base.eyes = 2;
            base.nose = 1;
            base.mouth = 1;
            base.ears = 2;
            base.kinds = "푸들";
        }
        
        public override void bark()
        {
            Console.WriteLine("푸들이 왈왈하고 짖어요");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.bark();

            Poodle myPoodle = new Poodle();
            myPoodle.bark();

            Dog newDog = new Poodle();
            newDog.bark();
            newDog.run();
        }
    }
}
