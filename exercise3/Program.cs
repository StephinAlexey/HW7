// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы

//Пример
//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


void Main()
{
    int Size = GetArraySizeFromUser();
    (int MinVal,int MaxVal) MinMaxVal = GetMinMaxValFromUser();
    int[] Array = InitIntArray(Size,MinMaxVal.MinVal,MinMaxVal.MaxVal);
    ArrayDisplay(Array,"The original Array is:");
    ReverseArrayDisplay(Array, "The reverse Array is:");
}



int[] InitIntArray(int Size, int MinVal, int MaxVal)
{
    Random rnd = new();
    int[] IntArray = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        IntArray[i] = rnd.Next(MinVal, MaxVal);
    }
    return IntArray;
}
(int MinVal, int MaxVal) GetMinMaxValFromUser()
{
    int MinVal = GetNumFromUser("Please enter the minimum value for random ");
    int MaxVal;
    while (true)
    {
        MaxVal = GetNumFromUser("Please enter the maximum value for random ");
        if (MaxVal > MinVal)
            break;
        else
            System.Console.WriteLine($"The maximum value must be bigger than {MinVal} ");
    }
    return (MinVal, MaxVal);
}
void ArrayDisplay(int[] IntArray, string DisplayText)
{
    System.Console.WriteLine(DisplayText);
    foreach (int item in IntArray)
    {
        System.Console.Write(item + " ");

    }
    System.Console.WriteLine();
}
void ReverseArrayDisplay(int[] IntArray, string DisplayText)
{
    System.Console.WriteLine(DisplayText);
    RecursiveArrayDisplay(IntArray,IntArray.Length-1);
}
void RecursiveArrayDisplay(int[] Array,int begin_index)
{
    if(begin_index<0)
    return;
    System.Console.Write(Array[begin_index]+ " ");
    RecursiveArrayDisplay(Array,begin_index-1);
}
int GetNumFromUser(String TextForUser)
{
    while (true)
    {
        try
        {
            Console.WriteLine(TextForUser);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;

        }
        catch (FormatException)
        {
            Console.WriteLine("You must enter a valid iteger number");
        }
    }
}
int GetArraySizeFromUser()
{
    int Size;
    while (true)
    {
        Size = GetNumFromUser("Please enter array length");
        if (Size > 0)
            return Size;
        else
            System.Console.WriteLine("Size of array is not valid");
    }
}
Main();