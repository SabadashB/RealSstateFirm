using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RealEstate
    {
        private string _address;
        private string _number;
        private string _location;
        private decimal _coast;
        private Type _type;
        private bool _isArended = false;

        public RealEstate(string address, string number, string location, decimal coast, Type type, bool isArended)
        {
            _address = address;
            _number = number;
            _location = location;
            _coast = coast;
            _type = type;
            _isArended = isArended;
        }

        public override string ToString() => $"m {_location} {_address} number: {_number} | {_coast}$ |  {_type} |  {_isArended}";
    }
}
