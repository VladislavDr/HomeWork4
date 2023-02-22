// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber (string messageToUser){
Console.WriteLine(messageToUser);
return Convert.ToInt32(Console.ReadLine());
}

int DegreeA (int a, int b){
    int degree = a;
    for (int i = b; i > 1; i--){
        degree = degree*a;
    }
    return degree;
}
bool examination(int b){
    if(b <= 0){
        Console.WriteLine("Число В должно быть больше 0");
        return false;
    }
    return true;
}

int numberA = ReadNumber("Введите число А");
int numberB = ReadNumber("Введите число В");
if (examination(numberB)){
    int result = DegreeA(numberA, numberB);
    Console.WriteLine(result);
}