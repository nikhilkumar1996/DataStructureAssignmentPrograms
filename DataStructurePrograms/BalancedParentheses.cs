using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class BalancedParentheses
    {
        public class StackOperations
        {
            char[] item=new char[100];
            int top = -1;
            
            public bool Push(char element)
            {
                if (top == item.Length)
                {
                    return false;
                }
                else
                {
                    item[++top] = element;
                    return true;
                }
            }
            
            public char Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack Cannot be -ve");
                    return '\0';
                }
                else
                {
                    char element = item[top];
                    top--;
                    return element;
                }
            }
            
            public bool ComparingParentheses(char elem1, char elem2)
            {
                if (elem1 == '[' && elem2 == ']')
                    return true;
                else if (elem1 == '{' && elem2 == '}')
                    return true;
                else if (elem1 == '(' && elem2 == ')')
                    return true;
                else
                    return false;
            }
            
            public bool Balanced(char[] array)
            {
                item = new char[array.Length];
                bool flag = true;
                if (array.Length == 0)
                    return true;

                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] == '{' || array[i] == '(' || array[i] == '[')
                    {
                        Push(array[i]);
                        flag = false;
                    }
                    if (array[i] == '}' || array[i] == ']' || array[i] == ')')
                    {
                        if (ComparingParentheses(Pop(), array[i]))
                            flag = true;
                        else
                            return false;
                    }
                }
                return flag;
            }
        }
    }
}
