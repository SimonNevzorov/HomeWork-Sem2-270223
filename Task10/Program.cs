Random rand = new Random();
int number = rand.Next(100, 1000);

Console.WriteLine("Случайное число = " + number);
// numberA = number / 
Console.WriteLine("Его вторая цифра = " + ((number / 10) % 10) );

