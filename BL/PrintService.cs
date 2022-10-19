using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PrintService
    {
        public static StringBuilder StringObjects(string filename)
        {
            StringBuilder clientstrings = new StringBuilder();
            foreach (var item in ReadWriteProvider.ReadClient(filename))
            {
                clientstrings.Append(item.ToString() + "\n");
            }
            return clientstrings;
        }
    }
}
