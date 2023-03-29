using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void MyDelegate();
    public class User
    {
        public event MyDelegate LessAge; //event declaration
        public event MyDelegate ValidAge;
        public void AcceptAge(int age)
        {
            if (age < 18)
            {
                LessAge();  // call to a event
            }
            else
            {
                ValidAge();
            }
        }
    }
    public class Program
    {
        static void Message1()
        {
            Console.WriteLine("Your age is less than 18");
        }
        static void Message2()
        {
            Console.WriteLine("Your age is valid");
        }
        static void Main(string[] args)
        {
            User user = new User();
            user.LessAge += new MyDelegate(Message1);
            user.ValidAge += new MyDelegate(Message2);
            user.AcceptAge(22);
        }
    }


   
}
