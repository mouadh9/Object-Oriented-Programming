using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StackOfStrings
{
    public class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            this.data = new List<string>();
        }

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            var element = this.data.Last();
            this.data.Remove(element);
            return element;
        }

        public string Peek()
        {
            return this.data.Last();
        }

        public bool IsEmpty() => !data.Any() ? true : false;
    }
}