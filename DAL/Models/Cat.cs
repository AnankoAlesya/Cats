using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Poroda { get; set; }
        public string Adress { get; set; }

        public Cat(int ID, string Name, int Age, string Poroda, string Adress)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
            this.Poroda = Poroda;
            this.Adress = Adress;
        }

        public override string ToString()
        {
            return ID + "\n" + Name + " \n" + Age + " \n" + Poroda + " \n" + Adress;
        }
    }
}
