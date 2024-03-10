using System;

class MainClass
{
    static void Main(string[] args)
    {

    }
    
    static void InputData() 
    {
        (string name, string lastName, byte age, Boolean isPet, string[] pets, int numPets, int numFlowers, string[] flowers) anketa;

        Console.WriteLine("Введите имя");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        anketa.lastName = Console.ReadLine();

        Console.WriteLine("Введите возраст");
        anketa.age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Есть ли питомец? (1 - есть, 0 - нет)");
        anketa.isPet = Boolean.Parse(Console.ReadLine());

        if (anketa.isPet )
        {
            Console.WriteLine("Введите количество питомцев");
            anketa.numPets = Int32.Parse(Console.ReadLine());


        }
    }
}