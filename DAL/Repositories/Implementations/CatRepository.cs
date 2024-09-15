using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations
{
    public class CatRepository:ICatRepository
    {
        private readonly List<Cat> cats = [];
        public void Add(Cat cat)
        {
            foreach (Cat c in cats)
            {
                if (c.Name == cat.Name)
                {
                    Console.WriteLine("Кот с такой кличкой уже есть!");
                }
            }
            cats.Add(cat); 
        }

        public List<Cat> GetAll()
        {
            return cats;
        }

        public Cat GetID(int ID)
        {
            foreach(Cat c in cats) {
                if (c.ID == ID) { return c; }
                
            }
            return null;
        }

        public void Remove(Cat cat)
        {
            foreach (Cat c in cats)
            {
                if (c.Name == cat.Name) cats.Remove(cat);
            }
            Console.WriteLine("Такого кота не существует!");
        }


        public void Update(int ID, Cat cat)
        {
            Cat c = cat;
        }
    }
}
