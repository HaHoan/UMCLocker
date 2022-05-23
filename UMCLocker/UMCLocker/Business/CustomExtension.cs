using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMCLocker.Business
{
    public static class CustomExtension
    {
        public static string ToCompleteString(this string str)
        {
            if(str.Length < 5)
            {
                var needAddZero = 5 - str.Length;
                var zero = "";
                for(int i = 0; i < needAddZero; i++)
                {
                    zero += "0";
                }
                str = zero + str;
            }
            return str;
        }
    }
}
