using ContactBookMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookMVC.Controller
{
    public class ContactController
    {
        private List<Contact> contactsList { get; set; }
        public ContactController(List<Contact> contactsList)
        {
            this.contactsList = contactsList;
        }
        public ContactController()
        {
            this.contactsList = new List<Contact>();
            this.contactsList.Add(new Contact("Alice","Shevchuk","Topol 1",new List<string> { "0985486059"}));
            this.contactsList.Add(new Contact("Mark", "Shevchuk", "Topol 3", new List<string> { "09857854567" }));
        }
        public void AddContact(Contact contact)
        {
            contactsList.Add(contact);
        }
        public void DeleteContact(Contact contact)
        {
            contactsList.Remove(contact);
        }
        public List<Contact> GetContacts()
        {
            return contactsList;
        }
    }
}
