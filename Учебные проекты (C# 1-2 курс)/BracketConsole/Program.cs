using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BracketConsole
{
    internal class Program
    {
        static Stack<char> brackets = new Stack<char>();

        static bool IsCorrect(char symbol)
        {
            switch (symbol)
            {
                // в стек записываются закрывающте скобки, которые должны последовать
                case '(': brackets.Push(')'); return true;
                case '[': brackets.Push('['); return true;
                case '{': brackets.Push(')'); return true;

                case ')':
                case ']':
                case '}':
                    if (brackets.Count == 0 || brackets.Peek() != symbol) return false;
                    brackets.Pop();
                    return true;
                default: return true;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string text = Console.ReadLine();
                if (text.Length > 0)
                {
                    foreach (char symbol in text)
                    {
                        if (IsCorrect(symbol))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // выделяет красным неправильные символы
                            Console.Write(symbol);
                        }
                    }

                    if (brackets.Count > 0) // добавить закрывающие скобки при необходимости
                    {
                        foreach(char bracket in brackets)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(bracket);
                        }
                    }
                }

            }
        }
    }

}

