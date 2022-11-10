
/*
Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

int lenArray = 8;

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


