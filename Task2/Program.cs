
Console.WriteLine($"Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(number);
if(NumberText.Length > 2)
{
    Console.WriteLine(NumberText[2]);
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
