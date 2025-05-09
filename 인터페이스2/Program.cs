using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스2
{
    // interface는 설계 즉, 전체 그림만 그리고 구현은 하지 않음
    public interface ICamera
    {
        void Camera();
    }
    public interface ICallPhone
    {
        void CallPhone();
    }
    public interface INetwork
    {
        void Network();
    }

    // 상속 받은 interface는 전부 SmartPhone에서 구현해야 함
    public class SmartPhone : ICamera, ICallPhone, INetwork
    {
         virtual public void Camera()
        {
            Console.WriteLine("카메라 기능 구현!");
        }

        virtual public void CallPhone()
        {
            Console.WriteLine("전화 기능 구현!");
        }

        virtual public void Network()
        {
            Console.WriteLine("네트워크 기능 구현!");
        }
    }

    public class Samsung : SmartPhone
    {

    }

    public class Apple : SmartPhone
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
