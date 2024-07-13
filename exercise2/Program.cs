// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// A(m, n) = 
// {
//     n + 1,                 если m = 0;
//     A(m - 1, 1),           если m > 0 и n = 0;
//     A(m - 1, A(m, n - 1)), если m > 0 и n > 0.
// }


// Пример
// m = 2, n = 3 -> A(m,n) = 9

void Main()
{
    int M = TakeNumFromUser("Please insert a first not negative number");
    int N = TakeNumFromUser("Please insert a second not negative number");
    System.Console.WriteLine($"The Akkerman function result is: {A(M,N)}");

}

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return A(m - 1, 1);
    if (m > 0 && n > 0)
        return A(m - 1, A(m, n - 1));
    else
    return 0;
}

int TakeNumFromUser(String TextForUser)
{
    while (true)
    {
        try
        {
            Console.WriteLine(TextForUser);
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
                Console.WriteLine("You must enter not negative number");
            else
                return num;

        }
        catch (FormatException)
        {
            Console.WriteLine("You must enter a valid iteger number");
        }
    }
}
Main();