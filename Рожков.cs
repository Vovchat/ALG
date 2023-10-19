//Стр.38 Зад.1
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//double x;
//x = 6 + 2 + 5 + 3 + 1;
//Console.WriteLine($"Сумма элементов последовательности: {x}");

//Стр.38 Зад.4
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//int[]sequence = {6, 2, 5, 3, 1};
//int targetNumber = 1;
//int count = 0;
//foreach (int number in sequence)
//{
//    if(number == targetNumber)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Число {targetNumber} встречается в последовательности {count} раз(а).");

//Стр.38 Зад.6
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//double x;
//x = 6 * 2 * 5 * 3 * 1;
//Console.WriteLine($"Произведение элементов последовательности {x}");

//Стр.38 Зад.7
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//double x;
//double q = 6;
//double w = 2;
//double e = 5;
//double r = 3;
//double t = 1;
//x = Math.Abs(q) + Math.Abs(w) + Math.Abs(e) + Math.Abs(r) + Math.Abs(t);
//Console.WriteLine($"Сумма модулей элементов последовательности: {x}");

//Стр.38 Зад.9
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//double x;
//double q = 6;
//double w = 2;
//double e = 5;
//double r = 3;
//double t = 1;
//x = q * q + w * w + e * e + r * r + t * t;
//Console.WriteLine($"Сумма квадратов элементов последовательности: {x}");

//Стр.38 Зад.10
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//double x;
//double q = 6;
//double w = 2;
//double e = 5;
//double r = 3;
//double t = 1;
//x = (q + w + e + r + t) / 5;
//Console.WriteLine($"Среднее арифметическое элементов последовательности: {x}");

//Стр.38 Зад.12
//Console.WriteLine("Есть последовательность чесел: 6 2 5 3 1");
//double x;
//double q = 6;
//double w = 2;
//double e = 5;
//double r = 3;
//double t = 1;
//x = Math.Abs(q) * Math.Abs(w) * Math.Abs(e) * Math.Abs(r) * Math.Abs(t);
//Console.WriteLine($"Произведение модулей элементов последовательности: {x}");

//Стр.33 Зад.3
//Console.WriteLine("Введите значение N");
//int n = int.Parse(Console.ReadLine());
//double result = 1;
//for (double i = 1; i <= n; i += 2)
//result *= (i / (i + 1));
//Console.WriteLine($"Произведение первых N сомножителей = {result}");

//Стр.36 Зад.1(б)
//Console.WriteLine("Введите значение eps=");
//double eps = double.Parse(Console.ReadLine());
//double summa = 0;
//int d = 1;
//double a;
//do
//{
//    a = 1.0 / (Math.Pow(2.0, d)) + 1.0 / (Math.Pow(3.0, d));
//    summa += a;
//    d++;
//}
//while (Math.Abs(a) >= eps);
//Console.WriteLine($"Сумма последовательности summa={summa}");

//Стр.41 Зад.1
//int n, x = 0, y, nn, summa;
//Console.WriteLine("Введите значение n ");
//n = Convert.ToInt32(Console.ReadLine());
//nn = n;
//while (n != 0)
//{
//    if (n / 10 == 0)
//        x = n;
//    n /= 10;
//}
//y = nn % 10;
//summa = x + y;
//Console.WriteLine($"Сумма первой и последней цифры числа = {summa}");

//Стр.43 Зад.1
//Console.WriteLine("Введите значение N");
//int N = int.Parse(Console.ReadLine());
//HashSet<int> digits = new HashSet<int>();
//int count = 0;
//do
//{
//    digits.Add(N % 10);
//    N /= 10;
//    count++;
//}
//while (N != 0);
//Console.WriteLine("Цифры различны: " + (count == digits.Count));