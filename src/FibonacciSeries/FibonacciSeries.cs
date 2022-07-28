class FibonacciSeries
{
    public void Fibonacci()
    {
        Console.WriteLine("Sequence length: ");
        if(int.TryParse(Console.ReadLine(), out int sequenceNumber))
        {
            for(int i = 0; i < sequenceNumber; i++)
                Console.Write(CalculateNumber(i)+ " ");
        }
        Console.WriteLine();
    }

    int CalculateNumber(int n) => n <= 1 ? 1 : CalculateNumber(n - 1) + CalculateNumber(n - 2); 
    
}