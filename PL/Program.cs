using DAL.Models;
using DAL.Repositories.Implementations;
using System.ComponentModel;
using System.Data.Common;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat(0, "Tim", 9, "Scotish fold", "Slonim");
            Cat cat2 = new Cat(1, "Sheri", 8, "Scotish straid", "Slonim");
            CatRepository repository = new CatRepository();
            repository.Add(cat1);
            repository.Add(cat2);
            List<Cat> cats = repository.GetAll();
            foreach (Cat c in cats)
            {
                Console.WriteLine(c);
            }
            Cat cat3 = new Cat(2, "Snejok", 2, "Dvorovoj", "Borisov");
            repository.Remove(cat3);
            foreach (Cat c in cats)
            {
                Console.WriteLine(c);
            }
            Cat cat5 = repository.GetID(15);
            Console.WriteLine(cat5);
            Cat cat6 = repository.GetID(-5);
            Console.WriteLine(cat6);
            Cat cat0 = repository.GetID(0);
            Console.WriteLine(cat0);
            Cat cat4 = new Cat(0, "Tim", 0, "Scotish fold", "Grodno");
            repository.Update(cat4,0);
            foreach (Cat c in cats)
            {
                Console.WriteLine(c);
            }
            Cat cat7 = new Cat(0, "Tim", 0, "Scotish fold", "Grodno");
            repository.Add(cat7);
            foreach (Cat c in cats)
            {
                Console.WriteLine(c);
            }
        }
    }
}
