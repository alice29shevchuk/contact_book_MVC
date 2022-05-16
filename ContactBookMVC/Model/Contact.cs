﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookMVC.Model
{
    public class Contact
    {
        public Contact(string name, string surname, string address, List<string> numbers)
        {
            Name = name;
            Surname = surname;
            Address = address;
            this.numbers = numbers;
        }
        public Contact()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Address = string.Empty;
            this.numbers = new List<string>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public List<string> numbers { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}|{2}",this.Name,this.Surname,this.Address);
        }
    }
}