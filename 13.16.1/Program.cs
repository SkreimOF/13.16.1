using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
namespace Compare
{
    
    class Program
    {
        static public string text = File.ReadAllText("D:\\Downloads\\test1.txt");
        static void Main(string[] args)
        {
            // читаем весь файл с папки загрузки в строку текста
           

            Console.WriteLine("Method 1 Time Elapsed (ms): {0}", TimeMethod(List));
            Console.WriteLine("Method 2 Time Elapsed (ms): {0}", TimeMethod(LinkedList));

        }
        static double TimeMethod(Action methodToTime)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            methodToTime();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        static void List()
        {
            var list = new List<string>();
            list.Add(text);
        }
        
        static void LinkedList()
        {
            var linkedlist = new LinkedList<string>();
            linkedlist.AddFirst(text);
        }
    }
}