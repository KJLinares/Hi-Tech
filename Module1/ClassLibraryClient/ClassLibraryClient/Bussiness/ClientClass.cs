using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClient.Bussiness
{
    public class ClientClass
    {
        public int ClientID{ get; set; }
        public string  Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int MaxCredits { get; set; }
    }
}
