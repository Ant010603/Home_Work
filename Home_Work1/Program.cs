/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int numberOne = 0;
int numberTwo = 0;
while (true){
    try{
        Console.Write("Введите первое число: ");
        numberOne = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        numberTwo = int.Parse(Console.ReadLine());
        break;
    }
    catch
    {
        Console.Write("Введено некоректное число: ");
    }
}

if(numberOne > numberTwo) Console.Write("Число {0} больше числа {1}", numberOne, numberTwo);
else if (numberOne == numberTwo) Console.Write("Число {0} равно числу {1}", numberOne, numberTwo);
else Console.Write("Число {1} больше числа {0}", numberOne, numberTwo);