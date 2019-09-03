using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
       

            static Stack s1 = new Stack();
            static void Main(string[] args)
            {


                Console.WriteLine("please enter a palindrome word and i will see if it is or not");
                string input = Console.ReadLine();
                BuildWordStack(input);
                string reversed = ReverseWord();
                Console.ReadLine();




            }




            public static void BuildWordStack(string insert)
            {
                char[] word = insert.ToLower().ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != ' ')
                        s1.Push(word[i]);
                }
                /*Remove spaces and ignore caps*/
            }

            public static string ReverseWord()
            {
                string temp = "";
                int end = s1.Count;
                for (int i = 0; i < end; i++)    //this reveses the word
                {
                    temp += s1.Pop();

                }

                return (temp);
            }


            public static void PalindromeCheck(string input1, string input2)
            {
                if (input1 == input2)
                {
                    Console.WriteLine("this word is a palindrome");      // this block is to take word in check if its a palindrome if it is it will return a message say it is a palindrome if it is not then a message will say it is not a palindrome
                }
                else
                {

                    Console.WriteLine("this word is not a palindrome");
                }



            }

        }
    
}
