using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class는 확장하는 것
// interface는 새로 구현 하는 것

// 다중 상속 여부
// 객체지향 프로그래밍에서 다중 상속(multiple inheritance)은 하나의 클래스가 둘 이상의 클래스(또는 인터페이스)로부터 상속을 받는 것
namespace 인터페이스
{
    public interface IUnit
    {
        void Attack();
        void Move();
    }
    public class Zergling : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("저글링 : 공격한다");
        }

        public void Move()
        {
            Console.WriteLine("저글링 : 이동한다");
        }
    }

    public class Sunhee : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("서니 : 공격한다");
        }

        public void Move()
        {
            Console.WriteLine("서니 : 이동한다");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Zergling zergling = new Zergling();
            zergling.Attack();
            zergling.Move();

            Sunhee sun = new Sunhee();
            sun.Attack();
            sun.Move();
        }
    }
}
