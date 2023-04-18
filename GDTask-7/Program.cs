foreach (var el in schitalka(20))
{
    Console.Write($"{el} ");
}
static int[] schitalka(int num)
{
    int a = 0;
    int b = 0;
    int c = 0;

    for (int i = 1; i < num; i++)
    {
        if (i % 3 == 0 && i % 5 != 0)
        {
            a++;
        }
        else if (i % 5 == 0 && i % 3 != 0)
        {
            b++;
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            c++;
        }
    }
    
    return new[] { a, b, c };
}