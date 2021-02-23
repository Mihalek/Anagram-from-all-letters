using System;
using System.Collections;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first word");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Write second word");
            string secondWord = Console.ReadLine();
            firstWord =firstWord.Replace(" ","");
            secondWord=secondWord.Replace(" ","");
            Stack<char> stack = new Stack<char>();
            List<char> list = new List<char>();
            
            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    stack.Push(firstWord[i]);
                    list.Add(secondWord[i]);
                }

                for(int i=0; i < secondWord.Length; i++)
                {
                    char letterFromStack = stack.Pop();
                    int indexLetterToDelete =list.IndexOf(letterFromStack);
                    if(indexLetterToDelete >=0)
                    {
                        list.RemoveAt(indexLetterToDelete);
                    }
                    else
                    {
                        Console.WriteLine("No Anagram");
                        break;
                    }
                }

                if (list.Count == 0 && stack.Count==0)
                {
                    Console.WriteLine("Anagram");
                }            
            }
            else
            {
                Console.WriteLine("No Anagram");
            }
        }
    }
}
