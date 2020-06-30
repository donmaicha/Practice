using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数字を入力してくれ");
            try
            {
                string input = Console.ReadLine();
                Answers answers = new Answers();
                answers.OutputEvenOrOdd(int.Parse(input));
            }
            catch
            {
                Console.WriteLine("数字を入力しろと言ったはずだが???");
            }

        }
        class Answers
        {
            /* No.40 整数値を入力させ、その値が偶数ならばeven、奇数ならばoddと表示するプログラムを作成せよ。*/
            /// <summary>
            /// 入力値が偶数の場合、「Even」、奇数の場合「Odd」と出力する
            /// </summary>
            /// <param name="input">入力値</param>
            public void OutputEvenOrOdd(int input)
            {
                bool result = JudgeEvenNum(input);
                Console.WriteLine(result ? "Even" : "Odd");
            }

            /// <summary>
            /// 入力値が偶数か判定する
            /// </summary>
            /// <param name="target">入力値</param>
            /// <returns>true:偶数 false:奇数</returns>
            private bool JudgeEvenNum(int target)
            {
                return target % 2 == 0;
            }
        }
    }
}
