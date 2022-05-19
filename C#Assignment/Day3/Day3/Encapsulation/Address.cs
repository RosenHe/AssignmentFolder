using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Encapsulation
{
    internal class Address
    {
        public string Name { get; set; }
        public string Street1 {get; set; }
        public  string Street2 {get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string postalCode { get; set; }
        public string Country { get; set; }
    }
}
