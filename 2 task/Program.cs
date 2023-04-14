//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 4; N = 8. -> 30

System.Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

int getsum(int number1,int number2)
{
    if(number2 == number1)
    {
        return number2;
    }
    return number2 + getsum(number1,number2-1);
    
    

}

int result = getsum(number1,number2);

System.Console.Write(result);