using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
namespace Compare
{
    
    class Program
    {
        //Читает весь файл с папки загрузки в public строку текста.
        //При надобности заменить путь до файла в File.ReadAllText(" *требуемый путь* ");
        static public string text = File.ReadAllText("D:\\Downloads\\test1.txt");
        static void Main(string[] args)
        {
            Console.WriteLine("Method 1 Time Elapsed (ms): {0}", TimeMethod(List));
            Console.WriteLine("Method 2 Time Elapsed (ms): {0}", TimeMethod(LinkedList));
        }
        
        //Вычисляет затраченное время полученного метода.
        static double TimeMethod(Action methodToTime)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            methodToTime();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
        
        //Метод 1.
        static void List()
        {
            var list = new List<string>();
            list.Add(text);
        }
        
        //Метод 2.
        static void LinkedList()
        {
            var linkedlist = new LinkedList<string>();
            linkedlist.AddFirst(text);
        }
    }
}
//Created by SkreimOF.
