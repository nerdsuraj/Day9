using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ManipulateContact
    {
        List<AddressContact> AddressBookList = new List<AddressContact>();
        public void AddingContact
            (
            string Name,
            string Address,
            string City,
            string State,
            string ZipCode,
            string PhoneNumber,
            string Email
            )
        {
            AddressBookList.Add
                (new AddressContact()
                {
                    Name = Name,
                    Address = Address,
                    City = City,
                    State = State,
                    ZipCode = ZipCode,
                    PhoneNumber = PhoneNumber,
                    Email = Email
                }
            );
            Console.WriteLine($"{Name} is added___________");
        }
    }
}
