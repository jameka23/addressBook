using System;
using System.Collections.Generic;

namespace AddressBook{
    public class AddressBook{
        public void AddContact(Contact contact){
            try{
                contacts.Add(contact.Email, contact);
            }
            catch(ArgumentException ex){
                Console.WriteLine($" An item with the same key has already been added.");
            }
        }
        public Contact GetByEmail(string searchEmail){
            return contacts[searchEmail];
        }
        public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
    }
}