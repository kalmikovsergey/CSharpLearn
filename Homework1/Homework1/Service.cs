using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public  class Service : IService
    {
        public List<Person> Bank = new List<Person>();
        public virtual decimal GetMoney(string name, decimal amount)
        {
            decimal returnAmount = 0;
           
            foreach(Person person in Bank)
            {              
                if (person.Name == name)
                {
                    if(person.Balance >= amount)
                    {
                        returnAmount = amount;
                    }
                    
                }              
            }
            return returnAmount;
        }

        public int GetPersonID(string name)
        {
            var id = 0;
            foreach (Person person in Bank)
            {
                ++id;
                if (person.Name == name)
                {
                    break;
                }
            }
            return id;

        }
    }
}
