using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class BankingCashCounter
    {
        public int bankBalance = 1500;
        public void QueueOperations()
        {
            Console.WriteLine("Enter the number of persons in Queue");
            int persons = Convert.ToInt32(Console.ReadLine());
            Queue<int> list = new Queue<int>();
            for (int i = 1; i <= persons; i++)
            {
                Console.WriteLine("Person in Queue {0} ", i);
                list.Enqueue(i);
                WithdrawalAndDeposit();
                list.Dequeue();
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue is not empty");
            }
            Console.WriteLine("Current Balance : " + bankBalance);
        }
        public void WithdrawalAndDeposit()
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Withdrawal cash");
                Console.WriteLine("2.Deposit Cash");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter amount to withdrawal");
                        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                        bankBalance = bankBalance - withdrawalAmount;
                        Console.WriteLine("Bank balance is {0}", bankBalance);

                        break;
                    case 2:
                        Console.WriteLine("Enter amount to deposit");
                        int amountDeposit = Convert.ToInt32(Console.ReadLine());
                        bankBalance = bankBalance + amountDeposit;
                        Console.WriteLine("Bank balance is {0}", bankBalance);
                        break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }

        }
    }
}
