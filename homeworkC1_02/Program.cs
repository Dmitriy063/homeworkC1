// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Prompt(string message)
{
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int x1 = Prompt("Введите x1: ");
int y1 = Prompt("Введите y1: ");
int z1 = Prompt("Введите z1: ");
int x2 = Prompt("Введите x2: ");
int y2 = Prompt("Введите y2: ");
int z2 = Prompt("Введите z2: ");
double dist = Math.Sqrt (Math.Pow (x2-x1, 2) + Math.Pow(y2-y1, 2)+Math.Pow(z2-z1,2));
Console.WriteLine ($"Расстояние между координатами равно {dist}");