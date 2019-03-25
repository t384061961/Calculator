using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Formula
    {
        private static string[] op = { "+", "-", "*", "/" };
        public static string MakeFormula()
        {
            StringBuilder build = new StringBuilder();
            Random random = new Random();
            int count = random.Next(1, 3);//设置运算符个数
            int number = random.Next(0, 100);//设置数字0-100之间
            int start = 0;
            build.Append(number);
            while (start <= count)
            {
                int opreation = random.Next(0, 4);
                int otherNumber = random.Next(0, 100);
                build.Append(op[opreation]).Append(otherNumber);//利用stringbuilder类中的Append方法来生成表达式
                start++;
            }
            return build.ToString();
        }
    }
}
