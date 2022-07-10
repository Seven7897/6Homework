Console.WriteLine("Введите количество чисел");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i <= number; i++)
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber > 0)
    {
        count += + 1; 
    }
}
Console.WriteLine( " количество положительных чисел : " + count );