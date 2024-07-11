// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = TakeNumFromUser("Please insert a first natural number");
    int N = TakeNumFromUser("Please insert a second natural number");
    System.Console.WriteLine("Natural numbers between two entered numbers is: ");
    PrintNumsBetween2Numbers(M, N);
}


int TakeNumFromUser(String TextForUser)
{
    while (true)
    {
        try
        {
            Console.WriteLine(TextForUser);
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
                Console.WriteLine("You must enter a number greater than 0");
            else
                return num;

        }
        catch (FormatException)
        {
            Console.WriteLine("You must enter a valid iteger number");
        }
    }
}
void PrintNumsBetween2Numbers(int M, int N)
{
    if (M == N)
    {
        System.Console.WriteLine(M);
    }
    else
    if (M > N)
    {
        System.Console.Write(N + ", ");
        PrintNumsBetween2Numbers(M, N + 1);
    }
    else
    {
        System.Console.Write(M + ", ");
        PrintNumsBetween2Numbers(M + 1, N);
    }

}





Main();