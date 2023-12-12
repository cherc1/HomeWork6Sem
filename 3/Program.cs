Console.Write("Введите строку: ");
string? stroka = Console.ReadLine();
Console.WriteLine($" {stroka}");

int size = stroka.Length;
int i = 0;
while(i < size)
{
    foreach(char n in stroka)
    if(n == size - i)
    {
        i++;
    }
    else 
    {
        Console.WriteLine("Строка не полиндром");
        break;
    }
}
Console.WriteLine("Строка полиндром");
