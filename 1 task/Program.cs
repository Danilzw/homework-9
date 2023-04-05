//Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.

System.Console.Write("Введите первое число:");
int numberfirst = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число:");
int numbersecond = int.Parse(Console.ReadLine());

void number(int number1,int number2)
{
    int result = 0;
    if(number2<number1)
    {
        return;
    }
    number(number1,number2-1);
    if(number2 % 2 == 0)
    {
        System.Console.Write(number2);
    }
    
    
}

number(numberfirst,numbersecond);

