using System;
using System.Collections.Generic;
namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //write down your heroes here...
            List<string> heroes = new List<string>();
            heroes.Add("Thor");
            heroes.Add("Iron Man");
            heroes.Add("Hulk");
            heroes.Add("Quicksilver");
            heroes.Add("Hercules");

            //show your heroes to console
            foreach(string heroe in heroes){
                Console.WriteLine(heroe);
            }

            //lets create your own Generic Class
            Food mieayam = new Food("mie ayam pangsit", 14000);
            Food bakso = new Food("bakso", 15000);
            Drink esDoger = new Drink("es doger", 8000);
            Bowl<Food> mangkok1 = new Bowl<Food>(mieayam);
            Bowl<Food> mangkok2 = new Bowl<Food>(bakso);
            Bowl<Drink> mangkok3 = new Bowl<Drink>(esDoger);

            Console.WriteLine("mangkok1 menu {0} harganya {1}", mangkok1.value.title, mangkok1.value.price);
            Console.WriteLine("mangkok2 menu {0} harganya {1}", mangkok2.value.title, mangkok2.value.price);
            Console.WriteLine("mangkok3 menu {0} harganya {1}", mangkok3.value.title, mangkok3.value.price);

        }
    }
}
