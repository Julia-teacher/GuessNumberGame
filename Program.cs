Random random = new Random();
int number = random.Next(1, 101);
Console.WriteLine("Угадай число от 1 до 100!");
while (true)
{
    int guess = int.Parse(Console.ReadLine());
    if (guess == number) { Console.WriteLine("Поздравляем, вы угадали!"); break; }
    else if (guess < number) Console.WriteLine("Больше!");
    else Console.WriteLine("Меньше!");
}
