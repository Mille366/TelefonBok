using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonbok.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }

        public User(string name, string email, string adress, string zipCode, string postCode, string phoneNumber)
        {
            Name = name;
            Email = email;
            Adress = adress;
            ZipCode = zipCode;
            PostCode = postCode;
            PhoneNumber = phoneNumber;
        }
    }

    
}
