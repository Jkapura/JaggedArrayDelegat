using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesJA
{
    public class CompareBy
    {
        public static int CompareBySum(int[] a, int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            if (a.Sum() > b.Sum())
                return 1;
            else if (a.Sum() < b.Sum())
                return -1;
            else
                return 0;
        }
        public static int CompareByMax(int[] a, int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            if (a.Max() > b.Max())
                return 1;
            else if (a.Max() < b.Max())
                return -1;
            else
                return 0;
        }
        public static int CompareByMin(int[] a, int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            if (a.Min() > b.Min())
                return 1;
            else if (a.Min() < b.Min())
                return -1;
            else
                return 0;
        }
    }
}
