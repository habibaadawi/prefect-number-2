class project2 {

static void Main(string[] args)
{
        // Declare the variables
        int n1, n2;

        // Ask user to enter n1
        Console.WriteLine("Enter n1: ");
        n1 = int.Parse(Console.ReadLine());

        // Ask user to enter n2
        Console.WriteLine("Enter n2: ");
        n2 = int.Parse(Console.ReadLine());

        // Print display message
        Console.WriteLine($"\nPrfect numbers between {n1} and {n2} are: ");

        for (int x = n1; x < n2; x++)
                {
            if (IsPerfect(x))
            Console.WriteLine(x );
                }

       Console.ReadLine();
}

   static bool IsPerfect(int num)
  {
    int sum = 0;
    for (int i = 1; i < num; i++)
    {
        if (num % i == 0)
            sum += i;
    }

    return sum == num;
  }

 }
