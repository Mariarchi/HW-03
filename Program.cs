using System;

class MainClass
{
    static void Main(string[] args)
    {
        var user = EnterUser();
        ShowUser(user.name, user.lastName, user.age, user.isPet, in user.pets, in user.flowers);
    }

    static (string name, string lastName, byte age, bool isPet, string[] pets, string[] flowers) EnterUser()
    {
        (string name, string lastName, byte age, bool isPet, string[] pets, string[] flowers) anketa;

        Console.WriteLine("Введите имя");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        anketa.lastName = Console.ReadLine();

        do
        {
            Console.WriteLine("Введите возраст");
        } while (CheckNum(Console.ReadLine(), out anketa.age));

        Console.WriteLine("У вас есть домашние животные? (true - есть, false - нет)");
        //bool.TryParse(Console.ReadLine(), out anketa.isPet);
        anketa.isPet = checked (Convert.ToBoolean(Console.ReadLine()));
        if (anketa.isPet)
        {
            anketa.pets = CreateArrayPets();
        }
        else
        {
            anketa.pets = new string[0];
        }

        anketa.flowers = CreateArrayFlower();
        return anketa;
    }

    static string[] CreateArrayPets()
    {
        int numPets = 0;
        do
        {
            Console.WriteLine("Введите количество питомцев");
        } while (CheckNum(Console.ReadLine(), out numPets));

        var result = new string[numPets];

        Console.WriteLine("Введите клички питомцев:");

        for (int i = 0; i < numPets; i++)
        {
            Console.WriteLine($"Кличка питомца № {i + 1}");
            result[i] = Console.ReadLine();
        }

        return result;
    }

    static string[] CreateArrayFlower()
    {
        int numFlowers = 0;
        do
        {
            Console.WriteLine("Введите количество любимых цветов");
        } while (CheckNum(Console.ReadLine(), out numFlowers));

        var result = new string[numFlowers];

        Console.WriteLine("Введите название своих любимых цветов:");

        for (int i = 0; i < numFlowers; i++)
        {
            Console.WriteLine($"Любимый цветок № {i + 1}");
            result[i] = Console.ReadLine();
        }

        return result;
    }

    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        } 
        
        corrnumber = 0;
        return true;
        
    }

    static bool CheckNum(string number, out byte corrnumber)
    {
        if (byte.TryParse(number, out byte intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }

        corrnumber = 0;
        return true;

    }

    static void ShowUser(string name, string lastName, byte age, bool isPet, in string[] pets, in string[] flowers)
    {
        Console.WriteLine("Данные пользователя:");
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Фамилия: " + lastName);
        Console.WriteLine("Возраст: " + age);
        if (isPet)
        {
            for (int i = 0; i < pets.Length; i++)
            {
                Console.WriteLine($"Питомец № {i + 1}: {pets[i]}");
            }
        }
        for (int i = 0; i < flowers.Length; i++)
        {
            Console.WriteLine($"Любимый цветок № {i + 1}: {flowers[i]}");
        }
    }
}
