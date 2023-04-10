using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Meat { get; set; }
        public int Price { get; set; }
        public List<(string ingrediente, int priceI)> ingredientes;


        public Burger(string bread, string meat, int price)
        {
            Bread = "Blanco Tradicional";
            Meat = "Angus";
            Price = 250;
            ingredientes = new List<(string, int)>();
        }
        public void AddI(string ingrediente, int priceI)
        {
            if (ingredientes.Count < 4)
            {
                ingredientes.Add((ingrediente, priceI));
            }
            else
            {
                Console.WriteLine("No se pueden agregar más");
            }
        }
        public void PrecioT()
        {
            int total = Price;
            int precioI = 0;

            Console.WriteLine("Cuantos ingredientes desea agregar? (máximo 4) ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            if (input1 > 4)
            {
                Console.WriteLine("No puede agregar más de 4 ingredientes");
            }
            else
            {
                Console.WriteLine("Escriba sus ingredientes");

                for (int i = 0; i < input1; i++)
                {
                    string ingrediente = Console.ReadLine();
                    AddI(ingrediente, 15);
                    precioI += 15;
                }
            }

            Console.WriteLine($"Selecciono una hamburguesa con pan {Bread}, carne {Meat}, y con los siguientes toppings: ");
            foreach ((string ingrediente, int priceI) in ingredientes)
            {
                Console.WriteLine($"{ingrediente} (${priceI})");
                total += priceI;
            }

            Console.WriteLine($"Precio base: ${Price}");
            Console.WriteLine($"Precio de ingredientes: ${precioI}");
            Console.WriteLine($"Su total es: ${total}");
        }

    }
}
