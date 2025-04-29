using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLovelyFirstConsole
{
    internal class Program
    {
        // enum
        enum Origin { East = 100, West, South, North };

        // 구조체
        // C#에서는 기본 접근지정자가 private이므로
        // public으로 사용하고 싶으면 반드시 명시해야함
        // 캡슐화를 원하면 멤버함수 만들어주기
        struct Book
        {
            public string name;
            public int price;
        }

        static void Main(string[] args)
        {
            /*
            // while문
            Console.WriteLine("hello :)");

            int i = 1;
            int sum = 0;

            while (sum < 100) {
                sum += i;
                i++;
            }
            Console.WriteLine("합이 100을 넘는 최초의 수 = {0}", i);
            */

            /*
            // for문
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("0부터 100까지 누적 합은? {0}입니다 :)", sum);
            */

            /*
            // 구구단 2단 출력
            for (int i = 1; i < 10; i++) {
                Console.WriteLine("2 * {0} = {1}", i, 2*i);
            }
            */

            /*
            // 단수를 입력 받고, 해당 구구단 출력하기
            // 사용자로부터 입력받는 함수 -> Console.ReadLine();
            // ReadLine으로 입력 받으면 전부 string type !
            Console.WriteLine("몇 단을 출력할까요? >> ");
            string str = Console.ReadLine();
            int dan = int.Parse(str);

            Console.WriteLine("{0}단을 출력합니다 !", dan);

            for (int i = 1; i < 10; i++) {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan*i);
            }
            */

            /*
            // foreach문 -> 1차원
            int[] ar = {9, 1, 2, 3, 4, 5};
            int Max = 0;

            Console.WriteLine("배열 출력 시작!");

            foreach (int i in ar)
            {
                if (i > Max)
                {
                    Max = i;
                }

                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("배열의 값 중 최대 값은? {0}입니다", Max);
            */

            /*
            // 다차원 배열
            int[,] ar =
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            Console.WriteLine("다차원 배열 출력 시작!");
            foreach (int i in ar)
            {
                Console.Write("{0} ",i);
            }
            */

            /*
            int[] arr = new int[5];
            
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            // for문
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            // foreach문
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            */

            // int[] arr = { 1, 2, 3, 4, 5, 6 };

            /*
            // enum 출력
            Console.WriteLine((int)Origin.South);
            */

            /*
            // struct 기본 사용 예시
            Book book = new Book();
            book.name = "C#";
            book.price = 1000;

            Console.WriteLine(book.name);
            Console.WriteLine(book.price);
            */

            /*
            // ref 참조형
            // C++의 & 참조변수 -> C#의 ref 참조형
            int a = 123;

            // b가 a의 메모리를 공유하겠다는 의미
            ref int b = ref a;

            b = 34;

            // b에 34를 대입함으로써, a와 b값 모두 34로 바뀜 -> 메모리 공유
            Console.WriteLine(a);
            Console.WriteLine(b);
            */
        }
    }
}
