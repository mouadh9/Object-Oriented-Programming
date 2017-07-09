using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zoo
{
    public class RandomList : ArrayList
    {
        private Random rnd;
        private List<string> data;
        public RandomList()
        {
            this.rnd = new Random();
            this.data = new List<string>();
        }

        public object RandomString()
        {
            int element = rnd.Next(0, data.Count - 1);
            string str = data[element];
            data.Remove(str);
            return str;
        }
    }
}