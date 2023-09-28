Console.WriteLine("Введите оценку: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.Write("Плохо");
        break;
    case 2:
        Console.Write("Неудоволетворительно");
        break;
    case 3:
        Console.Write("Удоволетворительно");
        break;
    case 4:
        Console.Write("Хорошо");
        break;
    case 5:
        Console.Write("Отлично");
        break;
}
Console.ReadKey(true);