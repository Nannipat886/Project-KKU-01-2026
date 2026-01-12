using System;

namespace ConsoleApp_VendingMachine
{
    public class VendingMachine
    {
        // วัตถุดิบ (กรัม)
        int water;
        int coffee;
        int milk;
        int chocolate;

        // constructor
        public VendingMachine(int water, int coffee, int milk, int chocolate)
        {
            this.water = water;
            this.coffee = coffee;
            this.milk = milk;
            this.chocolate = chocolate;
        }

        // แสดงสต๊อก
        public void ShowStock()
        {
            Console.WriteLine("=== Current Stock ===");
            Console.WriteLine($"Water: {water} g");
            Console.WriteLine($"Coffee: {coffee} g");
            Console.WriteLine($"Milk: {milk} g");
            Console.WriteLine($"Chocolate: {chocolate} g");
            Console.WriteLine("=====================");
        }

        // ===== เมธอดชงเครื่องดื่ม =====

        public bool MakeBlackCoffee(int amount)
        {
            int needWater = 300 * amount;
            int needCoffee = 20 * amount;

            if (water >= needWater && coffee >= needCoffee)
            {
                water -= needWater;
                coffee -= needCoffee;
                return true;
            }
            return false;
        }

        public bool MakeMocha(int amount)
        {
            int needWater = 300 * amount;
            int needCoffee = 20 * amount;
            int needChocolate = 10 * amount;

            if (water >= needWater && coffee >= needCoffee && chocolate >= needChocolate)
            {
                water -= needWater;
                coffee -= needCoffee;
                chocolate -= needChocolate;
                return true;
            }
            return false;
        }

        public bool MakeLatte(int amount)
        {
            int needWater = 300 * amount;
            int needCoffee = 20 * amount;
            int needMilk = 10 * amount;

            if (water >= needWater && coffee >= needCoffee && milk >= needMilk)
            {
                water -= needWater;
                coffee -= needCoffee;
                milk -= needMilk;
                return true;
            }
            return false;
        }

        public bool MakeChocolate(int amount)
        {
            int needWater = 300 * amount;
            int needChocolate = 20 * amount;

            if (water >= needWater && chocolate >= needChocolate)
            {
                water -= needWater;
                chocolate -= needChocolate;
                return true;
            }
            return false;
        }

        // ===== เติมน้ำ (โค้ดเพิ่มสต๊อก) =====
        public void RefillWater(int amount)
        {
            water += amount;
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine($"Add Water {amount} g Confirm");
        }
        public void RefillCoffee(int amount)
        {
            coffee += amount;
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine($"Add Coffee {amount} g Confirm");
        }
        public void RefillMilk(int amount)
        {
            milk += amount;
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine($"Add Milk {amount} g Confirm");
        }
        public void RefillChocolate(int amount)
        {
            chocolate += amount;
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine($"Add Chocolate {amount} g Confirm");
        }
    }
}
