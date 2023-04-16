using System.Collections;

Console.WriteLine("Введите фамилию человек, чей адрес почты вы хотите получить!");
string fam = Console.ReadLine();
Hashtable email = new Hashtable()
{
    ["Крючков"] = "janekruchkov@bk.ru",
    ["Манера"] = "maneraXxX@manera.int",
    ["Бочаров"] = "usatayabubna@srya.com",
    ["Афонин"] = "afoninje@morph.leave"
};

if (email.ContainsKey(fam))
{
    Console.WriteLine($"Адрес почты {email[fam]}");
}

else
{
    Console.WriteLine("Такого человека не существует!");
}