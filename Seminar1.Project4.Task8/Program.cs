// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введете положительное число");
int num = Convert.ToInt32(Console.ReadLine());

int evennumber = 1;

while (evennumber <= num)
{
    if (evennumber % 2 == 0)
    {
        Console.WriteLine(evennumber);
        evennumber ++;   
    }
    else
    {
        evennumber ++;
    }
}