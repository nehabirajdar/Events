using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEvent
{
    public delegate void MyDelegate();
    public class Bank
    {
        public event MyDelegate NoBalance;
        public event MyDelegate LowBalance;


        private double balance;
        public Bank(double balance)
        {
            this.balance = balance;
        }
        public void Credit()
        {
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine(balance);


        }
        public void Debit(double debitamt)
        {


            if (debitamt > balance)
            {
                NoBalance();

            }
            if ((balance - debitamt) < 3000)
            {
                LowBalance();

            }


        }
    }
        public class Program
        {
           
            static void Message2()
            {
                Console.WriteLine("No balance");
            }
            static void Message3()
            {
                Console.WriteLine("Low balance");

            }
            static void Main(string[] args)
            {
                Bank bank = new Bank(1000);

                bank.NoBalance += new MyDelegate(Message2);
                bank.LowBalance += new MyDelegate(Message3);

                bank.Credit();
                bank.Debit(500);
            }
        }
    }
