using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class AccountInfoAttribute : Attribute 
    {
        public string DeveloperName { get; }
        public string OrganizationName { get; }

        public AccountInfoAttribute(string developerName, string organizationName)
        {
            DeveloperName = developerName;
            OrganizationName = organizationName;
        }
    }
}

