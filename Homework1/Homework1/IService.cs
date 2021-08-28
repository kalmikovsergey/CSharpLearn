using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public interface IService
    {
         public decimal GetMoney(string name, decimal amount);
         public int GetPersonID(string Name);

    }
}
