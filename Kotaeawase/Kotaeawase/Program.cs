using System;
using static System.Console;

namespace kotaeawase
{
    class Program
    {
        static void Main(string[] args)
        {
            string? subject;
            WriteLine("答え合わせシステムへようこそ!");
            bool complete = false;
            while (complete == false)
            {
                WriteLine("教科を選んでください");
                WriteLine("数学・国語");
                subject = ReadLine();
                if (subject == "数学")
                {
                    complete = true;
                }
                else if (subject == "国語")
                {
                    complete = true;
                }
                else
                {
                }
            }
            WriteLine("ご利用ありがとうございました。");
            ReadKey();
        }
    }
}