using Day3.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Abstraction
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public string Email { get; set; }

        public Address[] Addresses;

        public string phoneNumber {  get; set; }

        public DateTime? JoinDate { get; set; }
        public abstract int doSomething();
    }
}
