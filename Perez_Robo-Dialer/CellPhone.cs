using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Perez_Robo_Dialer
{
    internal class CellPhone :Phone
    {
        
        public CellPhone(string name, string phoneNumber, string type) : base(name, phoneNumber, type)
        {
            
        }

        public override string dial()
        {
            return Company + " is being dialed using +1" + PhoneNumber+"...";
            
        }

       
    }
}
