using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public class CollectionService
    {
        private readonly List<Person> people;

        public CollectionService(List<Person> people)
        {
            this.people = people;
        }

        public int GetTotalPeopleCount()
        {
            return people.Count;
        }

        public IEnumerable<string> GetAllNames()
        {
            var Name = people.Select(i => i.Name);
            return Name;

        }

        public IEnumerable<string> GetAllNamesNoDuplicates()
        {
            return GetAllNames().Distinct()   ;
        }

        public IEnumerable<Person> GetPeopleEligibleToDrive()
        {
            return people.Where(i => i.Age >= 18);
        }

        public IEnumerable<Person> GetPeopleOrderedByAge()
        {
            return people.OrderBy(i => i.Age);
        }

        public IEnumerable<Person> GetPeopleWithInvalidEmails()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeopleWithFuckYouEmailProvider()
        {
            return people.Where(item => item.Email.EndsWith("@fuck.you"));        }

        public IEnumerable<Person> GetAllSluts()
        {
            return people.Where(item => item.Name.Contains("slut", StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<string> GetSlutsPhoneNumbers()
        {
            return GetAllSluts().Select(item => item.Phone);
        }

        public IEnumerable<Person> GetAllSlutsFromMenchester()
        {
            return GetAllSluts().Where(item => item.City=="Menchester");
        }
    }
}