/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введиетуе целые числа через пробел: ");
string data = Console.ReadLine();

string[] dataList = data.Split(" ");
Console.WriteLine(data);
int[] intList = new int[dataList.Length];

for (int i=0; i<dataList.Length; i += 1){
    intList[i] =(Convert.ToInt32(dataList[i]));
    Console.WriteLine(dataList[i]);
}  

int max = intList[0];
for (int i=0; i<dataList.Length; i += 1)
     if (max < intList[i]) max = intList[i];

Console.WriteLine("Максимальное число из {0} будет - {1}", data, max);

// if(numberOne > numberTwo)
//    Console.Write("Число {0} больше числа {1}", numberOne, numberTwo);
// else if (numberOne == numberTwo) Console.Write("Число {0} равно числу {1}", numberOne, numberTwo);
// else Console.Write("Число {1} больше числа {0}", numberOne, numberTwo);