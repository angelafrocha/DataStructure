using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1List
{
    internal class Exercise1
    {
        public static List<string> FilterSize(List<string> words, int size)
        {
            List<string> returnedList = new List<string>();

            foreach (var item in words)
            {
                if (item.Length >= size)
                {
                    returnedList.Add(item);
                }
            }


            return returnedList.ToList();
        }
    }
}
