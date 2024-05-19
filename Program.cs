string[] Array = new string[4] {"1234", "1567", "-2", "computer science"};
string[] newArray = new string[Array.Length];
void myArray(string[] Array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
    if(Array[i].Length <= 3)
        {
        newArray[i] = Array[i];
        count++;
        }
    }
} 
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
myArray(Array, newArray);
PrintArray(newArray);  