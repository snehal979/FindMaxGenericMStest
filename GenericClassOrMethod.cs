using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    internal class GenericClassOrMethod<T> where T : IComparable
    {
        T a;
        T b;
        T c ;
        //Refactor
        public GenericClassOrMethod()
        {
            this.a = a; this.b = b; this.c = c; 
        }

        // class of generic
        public T GenericClass(T a, T b, T c) 
        {
            if (a.CompareTo(b)>0 && a.CompareTo(c)>0)
            {
                return a;

            }
            else if (b.CompareTo(c)>0 && b.CompareTo(c)>0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }




    }
}
