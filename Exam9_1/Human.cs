﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Human : Animal
    {
        public string Name { get; set; }
        public string Address {  get; set; }
        public string cellPhone { get; set; }

        public Human()
        {
            Console.WriteLine("Human" + this.ToString());
        }
        public void Drawing()
        {

        }
        public void Study()
        {

        }
    }
    
}
