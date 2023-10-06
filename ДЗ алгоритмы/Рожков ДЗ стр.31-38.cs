//стр.31 задание 2
double distance = 10;
double dailyIncrease = 0.10;
int totalDays = 0;
Console.Write("Введите количество дней пробежки: ");
if (int.TryParse(Console.ReadLine(), out totalDays) && totalDays > 0)
{
    double totalDistance = 0;
    for (int day = 1; day <= totalDays; day++)
    {
        totalDistance += distance;
        distance += distance * dailyIncrease;
    }
    Console.WriteLine($"Спортсмен пробежит невероятные {totalDistance:F2} км за {totalDays} дней.");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}

//стр.31 задание 3
//Console.Write("Введите количество часов, кратное трём (ну или не кратное, программа не сломается): ");
//int n = int.Parse(Console.ReadLine());
//int amebaCount = 1;
//for (int hours = 3; hours <= n; hours += 3)
//{
//    amebaCount *= 2;
//}
//Console.WriteLine($"Через {n} часов будет {amebaCount} амёб(ы-а).");

//стр.31 задание 5
//int totalLegs = 64;
//for (int numGoose = 0; numGoose <= totalLegs / 2; numGoose++)
//{
//    int numRabbits = (totalLegs - (numGoose * 2)) / 4;
//    int remainingLegs = totalLegs - (numGoose * 2) - (numRabbits * 4);
//    if (remainingLegs == 0)
//    {
//        Console.WriteLine($"Гуськов: {numGoose}, Кролей: {numRabbits}");
//    }
//}
//Console.Write("Можно 5, пожалуйста :)   ну ради вовчата 0-0");

//стр.38 задание 1
//Console.Write("Есть последовательность чисел 7, 79, 4, 3 - ");
//int[] sequence = { 7, 79, 4, 3 };
//int sum = 0;
//foreach (int number in sequence)
//{
//    sum += number;
//}
//Console.WriteLine($"Сумма элементов последовательности: {sum}");

//стр.38 задание 4
//Console.Write("Есть последовательность чисел 4, 2, 6, 7, 8, 9, 9, 3, 1, 2, 2 - ");
//int[] sequence = { 4, 2, 6, 7, 8, 9, 9, 3, 1, 2, };
//int targetNumber = 0;
//int count = 0;
//foreach (int number in sequence)
//{
//    if (number == targetNumber)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Число {targetNumber} встречается в последовательности {count} раз(а).");

//стр.38 задание 6
//Console.Write("Есть последовательность чисел 59, 4, 2, 42 - ");
//int[] sequence = { 59, 4, 2, 42 };
//int product = 1;
//foreach (int number in sequence)
//{
//    product *= number;
//}
//Console.WriteLine($"произведение её элементов равно: {product}");