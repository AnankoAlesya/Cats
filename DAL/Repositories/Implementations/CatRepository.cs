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
        List<Cat> cats = [];
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
                if (c.Name == cat.Name) { cats.Remove(cat); }
                else { Console.WriteLine("Такого кота не существует!"); }
            }
           
        }


        public void Update(Cat cat, int ID)
        {
            Cat c = GetID(ID);
            c.Name = cat.Name;
            c.Age = cat.Age;
            c.Poroda = cat.Poroda;
            c.Adress = cat.Adress;
        }
    }
}
