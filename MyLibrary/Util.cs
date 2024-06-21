﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Util
    {
        static public int GetDigit()
        {
            Console.WriteLine("숫자를 입력하세요");
            string val = Console.ReadLine();
            return ConvertString2Int(val);

        }

        static public int ConvertString2Int(string str)
        {
            int result = 0;
            bool ret = int.TryParse(str, out result);
            if (ret)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
