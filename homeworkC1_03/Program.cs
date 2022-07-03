// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.;
int Prompt(string message)
{
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}
int power(int a)
{
    int result = 1;
    int index = 1;
    while (index<=a)
    {
        result = a*a*a;
        index++;
    }
    return (result);
}
int n = Prompt("Введите N: ");
int index = 1;
while (index <= n )
{
    Console.Write(power(index) + " ");
    index++;
}