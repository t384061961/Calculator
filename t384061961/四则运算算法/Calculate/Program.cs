using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            string formula = Formula.MakeFormula();
            Console.WriteLine("formula:"+formula);
           // Queue<string> a = jisuan.SplitExpress("(1+2)/3*5-2*(1+3)-(1*5-6)+4/2");
            Queue<string> a = calculate.SplitExpress(formula);
            //int c = a.Count;
            //for (int i = 0; i < c; i++)
            //{
            //    Console.Write("{0}  ", a.Dequeue());
            //}
            Console.Write("-------------------------------------\r\n");
            List<string> b = calculate.InorderToPostorder(a);
            if (b != null)
            {
                //foreach (var item in b)
                //{
                //    Console.Write("{0}  ", item);
                //}
            }
            else
            {
                Console.Write("错误");
            }
            Console.Write("\r\n");
            decimal result;
            if (calculate.IsResult(b,out result))
            {
                Console.Write("{0}", "result:"+result);
            }
            else
                Console.Write("错误的表达式");

            Console.ReadKey();
        }
    }
}
