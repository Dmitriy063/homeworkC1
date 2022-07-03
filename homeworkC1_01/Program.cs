// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int n = Prompt("Введите пятизначное число N = ");
int temp = n;
int a = 0;
int b = 0;
        while (Convert.ToBoolean(n))
        {
            a = n % 10;  
            n = n / 10; 
            b = b * 10 + a; 
        }
        if (temp == b) 
                {
            Console.WriteLine("Число палиндром");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }

