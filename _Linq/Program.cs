using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 52, 41, 58, 5 };
            int[] arr = new int[] { 5, 4, 2, 3, 6, 5, 8, 15, 254, 78, 5,1767 };
            string[] arr1 = new string[] { "galevon", "lek", "kkakle", "hahahlekkk", "lea", "glevkk","jjj","tar","jjalevv","leh","ley","jajleya" };
            var result2 = arr1.Where(x=>x.StartsWith("Le")).OrderBy(x=>x).Take(5);
            var result = list.Where<int>(x => x > 3);
            var result3 = arr1.Where(x => x.Contains("le")).OrderBy(x => x);
            var result1 = arr.Take<int>(3);
            var result5 = arr.Except<int>(list);
            var result6 = arr.DefaultIfEmpty<int>(22);
            var result7 = arr.GroupBy(x=>x>22); 
        }
    }
}
