using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class User
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        private Guid Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }

    }
}
