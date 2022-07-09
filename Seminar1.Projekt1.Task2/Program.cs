Console.WriteLine("Введете первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > num1)
{
    Console.WriteLine("Наибольшее число: " + num2 + ", наименьшее число: " + num1);
}
else
    if (num1 > num2)
    {
    Console.WriteLine("Наибольшее число: " + num1 + ", наименьшее число: " + num2);
    }
    else
    {
    Console.WriteLine(num1 + " = " + num2);
    }