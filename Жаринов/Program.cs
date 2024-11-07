using System;

class Program
{
    static void Main()
    {
        // Запрашиваем ФИО
        Console.Write("Введите ФИО: ");
        string fullName = Console.ReadLine();

        // Запрашиваем дату рождения
        Console.Write("Введите дату рождения (дд.мм.гггг): ");
        string birthDateInput = Console.ReadLine();

        DateTime birthDate;
        while (!DateTime.TryParseExact(birthDateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
        {
            Console.Write("Некорректный формат даты. Пожалуйста, введите дату рождения (дд.мм.гггг): ");
            birthDateInput = Console.ReadLine();
        }

        // Запрашиваем номер телефона
        Console.Write("Введите номер телефона: ");
        string phoneNumber = Console.ReadLine();

        // Запрашиваем почту
        Console.Write("Введите почту: ");
        string email = Console.ReadLine();

        // Вычисляем возраст
        int age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now < birthDate.AddYears(age)) age--;

        // Выводим приветственное сообщение
        Console.WriteLine("\nПривет, {0}!", fullName);
        Console.WriteLine("Дата рождения: {0:dd.MM.yyyy}", birthDate);
        Console.WriteLine("Возраст: {0} лет", age);
        Console.WriteLine("Номер телефона: {0}", phoneNumber);
        Console.WriteLine("Почта: {0}", email);
    }
}