using System;
using DAL;

namespace BL
{
    public class EntityService
    {
        public static void AddClient(string file, string name, string sername, string phone, string pasportData, string bankNumber)
            => EntityContext<Client>.WriteInFile(file, CreateEntity.CreateClient(name, sername, phone, pasportData, bankNumber));

        public static void AddEstate(string file, string address, string number, string location, decimal coast, DAL.Type type, bool isArended)
            => EntityContext<RealEstate>.WriteInFile(file, CreateEntity.CreateEstate(address, number, location, coast, type, isArended));
    }
}
