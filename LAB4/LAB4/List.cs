using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    public class List
    {
        public long Value { get; set; }
        public List Next { get; set; }
        public List Prev { get; set; }

        public List()
        {
            Value = default;
            Next = null;
            Prev = null;
        }

        public List(long value, List next = null, List prev = null) : this()
        {
            Value = value;
            Next = next;
            Prev = prev;
        }

    }
}
