// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    System.Console.Write("Вы ввели отрицательное число или 0");
}
int index = 1;
while(index <= number)
{
    System.Console.Write(index*index*index + ", ");
    index++;  
}

