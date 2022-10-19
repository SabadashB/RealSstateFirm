using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RemoveProvider
    {
        public static void RemoveClient(string filename, string pasportData)
        {
            List<Client> clienList = EntityContext<Client>.ReadFile(filename);
            for (int i = 0; i < clienList.Capacity; ++i)
            {
                if (clienList[i]._pasportData == pasportData)
                {
                    clienList.RemoveAt(i);
                    break;
                }
            }
            EntityContext<Client>.ClearFile(filename);
            foreach (Client client in clienList)
            {
                EntityContext<Client>.WriteInFile(filename, client);
            }
        }
    }
}
