
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Количество букв");
    Console.WriteLine($"2) Количество согласных");
    Console.WriteLine($"3) Количество гласных");
    Console.WriteLine($"4) Вся информация");
    Console.WriteLine();
}
void Menu()
{
    Console.WriteLine($"Для правильной работы программы пожалуйста используйте строчные буквы");
    Console.WriteLine($"Введите одно или несколько слов");
    string check = Console.ReadLine();
    GetMenu();
    string choic = Console.ReadLine();
    bool choi=int.TryParse(choic,out var choice);
    Console.WriteLine();
    if (choice == 1)
    {
        NumberOfCharacters(check);
    }
    else if(choice == 2)
    {
        Consonants(check);
    }
    else if (choice == 3)
    {
        Vowels(check);
    }
    else if (choice == 4)
    {
        GetInfo(check);
    }
    else
    {
        Console.WriteLine($"Выберите пункт меню");
    }
}
void Vowels(string check)//гласные
{
    char[] vowels = new char[] { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е', 'a', 'e', 'i', 'o', 'u', 'y' };
    int a = 0;
    foreach(char ch in check)
    {
        foreach(char ch2 in vowels)
        {
            if(ch == ch2)
            {
                a++;
            }
        }
    }
    Console.WriteLine($"Количество гласных букв: {a}");
}
void Consonants( string check)//согласные
{
    char[] consonants = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с','т','ф','х','ц','ш','щ','b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
    int character = 0;
    foreach (char consonant in check)
    {
        foreach(char consonan in consonants)
        {
            if(consonan == consonant)
            {
                character++;
            }
        }
    }
    Console.WriteLine($"Количество согласных букв: {character}");
}
void NumberOfCharacters(string check)
{
    bool b = false;
    int k = 0;
    char[] numbers = new char[] { '!', '?', '.', ',', ' ', '_', '-' };
    foreach (char word in check)
    {
        foreach (char c in numbers)
        {
            if (word == c)
                b = true;
        }
        if (b == false && char.IsLetter(word))
        {
            k++;
        }
        b = false;
    }
    Console.WriteLine($"Количестро букв: {k}");
    Console.WriteLine();
}
void GetInfo(string check)
{
    Vowels(check);
    Consonants(check);
    NumberOfCharacters(check);
}
while (true)
{
Menu();
}


