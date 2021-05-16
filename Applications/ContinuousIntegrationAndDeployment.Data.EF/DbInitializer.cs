using ContinuousIntegrationAndDeployment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousIntegrationAndDeployment.Data.EF
{
    public static class DbInitializer
    {
        public static void Initialize(PeopleContext context)
        {
            if (context.People.Any())
            {
                return;
            }

            var people = new Person[] {
                new Person{ FirstName="Santosh", LastName="Raju" },
                new Person{ FirstName="Imar", LastName="Spaanjaar"}
            };

            context.AddRange(people);
            context.SaveChanges();
        }
    }
}
