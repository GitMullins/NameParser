using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser
{
    public class Parser
    {
        public Name ParseName(string nameToParse)
        {
            return new Name();
        }

        public class Name
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
