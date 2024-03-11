using System.Threading.Tasks.Dataflow;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi there");
        int[] tab = { 1, 2, 3, 4, 5 };
        Srednia(tab);
        Maks(tab);
    }

    public static void Srednia(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum = sum + num;
        }
        Console.WriteLine(sum/arr.Length);
    }
    public static void Maks(int[] tab)
    {
        int maks = 0;
        foreach (int num in tab)
        {
            if (maks < num)
                maks = num;
        }
        Console.WriteLine(maks);
    }
}