using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串以逗號分隔的整數數字字串："); string str= Console.ReadLine();
            Console.WriteLine($"輸入序列順序：{str}");
            //序列倒置
            int[] arrInt = Array.ConvertAll(str.Split(','), s => int.Parse(s));
            var arrReverse= arrInt.Reverse();
            Console.Write($"序列倒置結果：");
            foreach ( int i in arrReverse) 
            {
                Console.Write(i+", ");
            }

            //奇偶數判斷
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            Console.WriteLine(Environment.NewLine + Environment.NewLine + $"奇偶判斷：");
            foreach( int i in arrInt)
            {
                if (i % 2 == 0) 
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            IEnumerable<int> ResultsOdd = odd.OrderBy((x) => x); Display("奇數", ResultsOdd);
            IEnumerable<int> ResultsEven = even.OrderBy((x) => x); Display("偶數", ResultsEven);


            Console.ReadKey();
        }

        public static void Display(string str, IEnumerable<int> list)
        {
            Console.Write(Environment.NewLine + $"{str}：");
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
        }

    }
}
