using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class StringExt
    {
        public static string Clear(this string str)
        {
            StringBuilder sb = new StringBuilder();

            //Формирование новой строки с содержанием только (a-z,A-Z,0-9)
            foreach (char c in str)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    //Удаление лишних пробелов в тексте
                    if (sb.Length > 0)
                    {
                        if (!( c == sb[^1] && char.IsWhiteSpace(c)))
                        {
                            sb.Append(c);
                        }
                    }
                    //Первое удаление, когда sb.Length ещё 0
                    else
                    {
                        sb.Append(c);
                    }
                }
            }
            return sb.ToString().Trim();
        }
    }
}
