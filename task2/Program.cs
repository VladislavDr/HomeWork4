// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber (string messageToUser){
Console.WriteLine(messageToUser);
return Convert.ToInt32(Console.ReadLine());
}

int SumToA(int a){
    int division = 0;
    int sum = 0;
    for (int i = 0; a >= 1; i++){
        division = a % 10;
        sum = sum + division;
        a = a / 10;
    }
    return sum;
}

int number = ReadNumber("Введите числ А");
int result = SumToA(number);
Console.WriteLine(result);