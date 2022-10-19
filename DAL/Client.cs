using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class Client
    {
        public string _name;
        public string _sername;
        public string _phone;
        public string _pasportData;
        public string _bankNumber;
        public Client(){}
        public Client(string name, string sername, string phone, string pasportData, string bankNumber)
        {
            _name = name;
            _sername = sername;
            _phone = phone;
            _pasportData = pasportData;
            _bankNumber = bankNumber;
        }
        public override string ToString() => $"{_name} {_sername} | {_phone} | {_pasportData} |  {_bankNumber}";
    }
}
