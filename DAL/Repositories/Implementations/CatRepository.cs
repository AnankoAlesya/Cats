using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.Implementations
{
    public class CatRepository : ICatRepository
    {
        private readonly List<Cat> cats = [];

        public void Add(Cat cat)
        {
            foreach (Cat c in cats)
            {
                if (c.Name.Equals(cat.Name)) Console.WriteLine("Кот с такой кличкой уже есть!");
            }

            cats.Add(cat); 
        }

        public List<Cat> GetAll() => cats;

        public Cat GetById(int Id)
        {
            foreach(Cat c in cats)
            {
                if (c.ID == Id) return c;  
            }

            return null;
        }

        public void Remove(Cat cat)
        {
            cats.Remove(cat);

            Console.WriteLine("Такого кота не существует!");
        }


        public void Update(int Id, Cat cat)
        {
            Cat cat0 = GetById(Id);
            cat0.Name = cat.Name;
            cat0.Age = cat.Age;
            cat0.Poroda = cat.Poroda;
            cat0.Adress = cat.Adress;
        }
    }
}
