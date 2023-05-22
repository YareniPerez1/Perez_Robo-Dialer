using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Perez_Robo_Dialer
{
    internal class Phone
    {
        private string _name;
        private string _phoneNumber;
        private string _Type;
        public Phone(string name, string phoneNumber, string type)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _Type = type;
        }

        public virtual string dial ()
        {
            return _name + " is being dialed using " + _phoneNumber +"...";
        }

        public string Company
        {
            get { return _name; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

    }
}
