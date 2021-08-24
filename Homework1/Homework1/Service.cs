using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Service : IService
    {
        public List<Person> Bank = new List<Person>();
        public decimal GetMoney(string name, decimal amount)
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
    }
}
