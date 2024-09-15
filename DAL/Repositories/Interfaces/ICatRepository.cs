using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    internal interface ICatRepository
    {
        void Add(Cat cat);
        void Update(int ID, Cat cat);
        void Remove(Cat cat);
        List<Cat> GetAll();
        Cat GetID(int ID);
    }
}
