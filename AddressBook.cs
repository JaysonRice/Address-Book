using System;
using System.Collections.Generic;
namespace TryCatch
{
    public class AddressBook
    {

        private Dictionary<string, string> _contactAddress = new Dictionary<string, string>();

        public void AddContact(Contact contact)
        {
            _contactAddress.Add("Name", contact.FirstName);
            _contactAddress.Add("Email", contact.Email);
        }
    }
}