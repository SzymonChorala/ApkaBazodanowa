﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Waluta
    {
        public string disclaimer { set; get; }
        public string license { set; get; }
        public int timestamp { set; get; }
        public string Base { set; get; }
        public Dictionary<string, float> rates { set; get; }


    }
}
