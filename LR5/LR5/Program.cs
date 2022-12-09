using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = "C:\\Labs\\AllLabs\\LR5\\LR5\\AllValues.txt"; 
            
            string[] input = File.ReadAllLines(path); //чтение массива строк
            for (int i = 0; i < input.Length; ++i)
            {
                Regex regex = new Regex(@"([A-Z]|[a-z])+\s([A-Z]|[a-z])+\s([A-Z]|[a-z])+\W\s(\d){1,}\s([A-Z]|[a-z])+(\W)\s(g)(\W)([A-Z]|[a-z])+\W");
                if (regex.IsMatch(input[i])) 
                {
                    Console.WriteLine(regex.Match(input[i]));
                    Console.WriteLine(regex.Match(@"^"));
                }
                else
                {
                    Console.WriteLine("Не найдено");
                }
            }  
        }
    }
}
//Ответы 
/* 
1.
A)@"^[a]$" 
B)@"[a]{4,}[^ ]"
C)@"[a]{1}\s[a]{2}\s[a]{1}"
2.@"(\d|[a-z]){5,}"
3.@"[a-z]+[^ ]\W[^ ][a-z]+[^ ]\W[a-z]+"
 */