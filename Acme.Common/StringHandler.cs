using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// bir dize her büyük harften önce boşluk ekler
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces( this string source)
        {
            string result=string.Empty;
            if(!string.IsNullOrEmpty(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }
                    result += letter;
                }
            }
            //result=result.Trim();
            //result += " ";
            return result;  
        }
    }
}
