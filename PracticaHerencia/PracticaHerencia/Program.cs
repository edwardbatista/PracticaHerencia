namespace PracticaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tipo de hamburguesa quiere? ");
            Console.WriteLine("1) Normal  2) Premium  3) Light");
            Console.WriteLine("Tenga en cuenta que la hamburguesa premium no permite ingredientes adicionales.");
            int input = Convert.ToInt32(Console.ReadLine());


            if (input == 1)
            {
                Burger burger = new Burger("", "", 0);
                burger.PrecioT();
            }

            if (input == 2)
            {
                BurgerPremium burgerPremium = new BurgerPremium("", "", 0);
                burgerPremium.PrecioT();
            }

            if (input == 3)
            {
                BurgerLight burgerLight = new BurgerLight("", "", 0);
                burgerLight.PrecioT();
            }


        }

    }
}
