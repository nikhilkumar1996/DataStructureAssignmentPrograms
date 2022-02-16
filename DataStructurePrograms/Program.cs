using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure Program");
            Console.WriteLine("1.Balanced Parentheses" +
                              "\n2.Exit");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Program");
                int choose=Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        char[] arr = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
                        BalancedParentheses.StackOperations stackOperations = new BalancedParentheses.StackOperations();
                        bool balanced = stackOperations.Balanced(arr);
                        if (balanced)
                        {
                            Console.WriteLine("Parantheses are Balanced");
                        }
                        else
                        {
                            Console.WriteLine("Parantheses are not Balanced");
                        }
                        break;

                    case 2:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
