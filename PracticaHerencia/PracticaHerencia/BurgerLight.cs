using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    public class BurgerLight : Burger
    {
        public BurgerLight(string bread, string meat, int price) : base(bread, meat, price)
        {
            Bread = "Integral";
            Meat = "Alternativa Saludable";
            Price = 300;
        }
        public new void AddI(string ingrediente, int priceI)
        {
            if (ingredientes.Count < 6)
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

            Console.WriteLine("Cuantos ingredientes desea agregar? (máximo 6) ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            if (input1 > 4)
            {
                Console.WriteLine("No puede agregar más de 6 ingredientes");
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
