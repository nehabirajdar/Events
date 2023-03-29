using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EventName
{
    public delegate void MyDelegate();
    public class Name
    {
        public event MyDelegate NameRequired;
        public event MyDelegate NameValid;

        public void accept(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                NameRequired();
            }
            else
            {
                NameValid();
            }
        }

        public class Progarm
        {
            static void Message1()
            {
                Console.WriteLine("Name is required");
            }
            static void Message2()
            {
                Console.WriteLine("Name is valid");
            }

            static void Main(string[] args)
            {

                Name n = new Name();
                n.NameRequired += new MyDelegate(Message1);
                n.NameValid += new MyDelegate(Message2);
                n.accept("");

            }
        }
    }
}