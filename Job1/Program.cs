/* Задача 13: Напишите программу,
 которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

Console.Write("Введите число: ");
string number = Console.ReadLine();
Task1(number);

void Task1(string currentNumber)
{ 
    if(currentNumber.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else Console.WriteLine(currentNumber[2]);
}





