// Программа поиска наибольшего и наименьшего, из двух введенных чисел
Console.WriteLine("Введите число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В = ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Максимальное число=  {numberA}");
}
else
{
    Console.WriteLine($"Максимальное число=  {numberB}");
}