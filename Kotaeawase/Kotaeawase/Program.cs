using System;
using static System.Console;

namespace kotaeawase
{
    class Program
    {
        static void Main()
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
                    string que;
                    int quenum = 1;
                    bool comp = false;
                    int canswer;
                    bool correct;
                    int? answer;
                    while (quenum <= 2)
                    {
                        correct = false;
                        answer = null;
                        if (quenum == 1)
                        {
                            que = "P.10 ①";
                            canswer = +9;
                        }
                        else if (quenum == 2)
                        {
                            que = "P.10 ②";
                            canswer = -9;
                        }
                        else
                        {
                            que="エラー";
                            correct = true;
                            canswer = 0;
                        }
                        while (correct == false)
                        {
                            WriteLine(que);
                            answer = int.Parse(ReadLine());
                            if (answer == canswer)
                            {
                                WriteLine("正解");
                                correct = true;
                                quenum++;
                            }
                            else
                            {
                                WriteLine("不正解");
                            }
                        }
                    }
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