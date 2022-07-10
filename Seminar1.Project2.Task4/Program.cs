Console.WriteLine("Введете первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > num1 && num2 > num3) max = num2;
if (num3 > num1 && num3 > num2) max = num3;
else num1 = max;

Console.WriteLine("Наибольшее число " + max);