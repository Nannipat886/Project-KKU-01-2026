# Project-KKU-01-2026
นันท์นิพัทธ์ อ่วมอินทร์
683450431-9

classDiagram
    class Program {
        + Main(args)
    }

    class VendingMachine {
        - int water
        - int coffee
        - int milk
        - int chocolate

        + VendingMachine(water, coffee, milk, chocolate)
        + ShowStock()

        + MakeBlackCoffee(amount) bool
        + MakeMocha(amount) bool
        + MakeLatte(amount) bool
        + MakeChocolate(amount) bool

        + RefillWater(amount)
        + RefillCoffee(amount)
        + RefillMilk(amount)
        + RefillChocolate(amount)
    }

    Program --> VendingMachine : uses
