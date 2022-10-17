using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        private string _name;
        private string _sername;
        private string _phone;
        private string _pasportData;
        private int _bankNumber;
        public Client(){}
        public Client(string name, string sername, string phone, string pasportData, int bankNumber)
        {
            _name = name;
            _sername = sername;
            _phone = phone;
            _pasportData = pasportData;
            _bankNumber = bankNumber;
        }

        public override string ToString() => $"{_name}{_sername} | {_phone} | {_pasportData} |  {_bankNumber}";
    }
}
