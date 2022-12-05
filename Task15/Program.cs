// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите день недели: ");
Console.Write("Введите день недели (1...7): ");
int day = Convert.ToInt32(Console.ReadLine());

bool Weekend(int week)
{
    return week == 6 || week == 7;
}

// Функция
bool result = Weekend(day);
Console.Write($"{day} -> ");
Console.WriteLine(result ? "Да" : "Нет");
