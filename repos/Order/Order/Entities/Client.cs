using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Order.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, string birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + " ("
                + BirthDate.ToShortDateString() + ") - "
                + Email;
        }
    }
}
