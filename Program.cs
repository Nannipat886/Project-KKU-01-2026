using System;

namespace ConsoleApp_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine(2000, 500, 200, 200);
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n----- Automatic Hot Coffee Maker -----");
                vm.ShowStock();
                Console.WriteLine("Select menu");
                Console.WriteLine("1: Black coffee");
                Console.WriteLine("2: Mocha");
                Console.WriteLine("3: Latte");
                Console.WriteLine("4: Chocolate");
                Console.WriteLine("9: Refill stock");
                Console.WriteLine("0: Exit");
                Console.Write("Select menu: ");

                string menu = Console.ReadLine();

                // ===== ออกจากระบบ =====
                if (menu == "0")
                {
                    running = false;
                    continue;
                }

                // ===== เมนูเติมสต๊อก =====
                if (menu == "9")
                {
                    Console.WriteLine("\n=== Refill Menu ===");
                    Console.WriteLine("1: Coffee");
                    Console.WriteLine("2: Milk");
                    Console.WriteLine("3: Chocolate");
                    Console.WriteLine("4: Water");
                    Console.WriteLine("0: Back");
                    Console.Write("Select: ");

                    string refillMenu = Console.ReadLine();

                    if (refillMenu == "0")
                        continue;

                    Console.Write("Input amount to refill: ");
                    int refill = int.Parse(Console.ReadLine());

                    switch (refillMenu)
                    {
                        case "1": vm.RefillCoffee(refill); break;
                        case "2": vm.RefillMilk(refill); break;
                        case "3": vm.RefillChocolate(refill); break;
                        case "4": vm.RefillWater(refill); break;
                        default:
                            Console.WriteLine("Wrong refill menu");
                            continue;
                    }

                    vm.ShowStock();
                    continue;
                }

                // ===== สั่งเครื่องดื่ม =====
                Console.Write("Input amount to order: ");
                int amount = int.Parse(Console.ReadLine());

                bool result = false;

                switch (menu)
                {
                    case "1": result = vm.MakeBlackCoffee(amount); break;
                    case "2": result = vm.MakeMocha(amount); break;
                    case "3": result = vm.MakeLatte(amount); break;
                    case "4": result = vm.MakeChocolate(amount); break;
                    default:
                        Console.WriteLine("Wrong menu");
                        continue;
                }
                if (result)
                    Console.WriteLine("=====================");
                if (result)
                    Console.WriteLine("Order success!");
                if (result)
                    Console.WriteLine("=====================");
                else
                    Console.WriteLine("Not enough stock");

                vm.ShowStock();
            }

            Console.WriteLine("System closed");
        }
    }
}

