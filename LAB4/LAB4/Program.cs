using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class list
    {
        public struct Owner
        {
            public readonly long id;
            public string name;
            public string organization;

            public Owner(long ID)
            {
                id = ID.GetHashCode();
                name = "Цыганок Илья";
                organization = "БГТУ";
            }

            public override string ToString()
            {
                return $"[{id}] {name} из {organization}";
            }
        }


        public class Date
        {
            public DateTime date { get; set; }

            public Date()
            {
                date = DateTime.Now.Date;
            }

            public override string ToString()
            {
                return $"Дата: {date.ToShortDateString()}";
            }
        }

        public Owner owner;
        public Date cDate;

        public List First { get; set; }

        public int Lenght
        {
            get
            {
                int pos = 0;
                List p = First;
                while (p != null)
                {
                    p = p.Next;
                    pos++;
                }
                return pos;
            }

        }
        public list()
        {
            cDate = new Date();
            owner = new Owner(cDate.date.Millisecond);
            First = new List(FUN.rand.Next(-500, 500));
        }

        public list(int z) : this()
        {
            List p = First;
            while (z > 0)
            {
                p.Next = new List(FUN.rand.Next(-500, 500));
                p = p.Next;
                z--;
            }
        }

        public List GetLast()
        {
            List last = First;
            while (last.Next != null)
            {
                last = last.Next;           
            }
            return last;
        }
        public static list operator +(list left, list right)
        {
            list result = (list)left.Clone();
            List p = result.First, rightp = right.First;
            while (p != null && rightp != null)
            {
                p.Next = new List(rightp.Value, p.Next);
                rightp = rightp.Next;
                p = p.Next.Next;
            }
   
            p = result.GetLast();

            while (rightp != null)
            {
                p.Next = new List(rightp.Value);
                rightp = rightp.Next;
                p = p.Next;
            }
            return result;
        }
        public static bool operator ==(list left, list right)
        {
            if (left.Lenght != right.Lenght)
            {
                return false;
            }
            List leftp = left.First, rightp = right.First;
            while (leftp != null && rightp != null)
            {
                if (leftp.Value != rightp.Value)
                {
                    return false;
                }
                leftp = leftp.Next;
                rightp = rightp.Next;
            }
            return true;
        }
        public static bool operator !=(list left, list right)
        {
            return !(left == right);
        }
        public static list operator -(list left)
        {
            list result = (list)left.Clone();
            List p = result.First;
            left.First = p.Next;
            return left;
        }
        public static bool operator ~(list left)
        {

            if(left.Lenght == 0)
            {
                return true;
            }
            return false;
        }
        public object Clone()
        {
            list clone = new list();
            List clonep = clone.First, p = First;
            while (p != null)
            {
                clonep.Value = p.Value;
                if (p.Next != null)
                {
                  clonep.Next = new List(p.Next.Value);
             }
              clonep = clonep.Next;
              p = p.Next;
            }
            return clone;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            string result = string.Empty;
            List p = First;
            while (p != null)
            {
                result += '\t' + p.Value.ToString();
                p = p.Next;
            }
            return result;
        }
    }
}


