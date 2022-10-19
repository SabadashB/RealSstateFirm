using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CreateEntity
    {
        public static Client CreateClient(string name, string sername, string phone, string pasportData, string bankNumber)
            => new Client(name, sername, phone, pasportData, bankNumber);

        public static RealEstate CreateEstate(string address, string number, string location, decimal coast, Type type, bool isArended)
            => new RealEstate(address, number, location, coast, type, isArended);
    }
}
