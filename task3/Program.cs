// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int ReadNumber(string messageToUser){
// Console.WriteLine(messageToUser);
// return Convert.ToInt32(Console.ReadLine());
// }


// int GenArray (int min, int max){
//     int[] array = new int [8];
//     for(int i = 0; i < array.Length; i++){
//         array[i] = Random.Shared.Next(min, max+1);
//     }
//     return array;

// }


// int min = ReadNumber("Введите минимальное значение массива");
// int max = ReadNumber("Введите максимально значение массива");
// int result = GenArray(min, max);
// Console.WriteLine(result);


int GetRandom(){
    Random rnd = new Random();
    int a = rnd.Next();
    return a;
}

int[] array = new int [8];
for (int i = 0; i < array.Length; i++){
    array[i] = GetRandom();
}
Console.WriteLine($"[{string.Join(" , ", array)}]");