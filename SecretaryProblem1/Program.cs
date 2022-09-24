namespace SecretaryProblem1
{
    static class Program
    {
        static void Main(string[] args)
        {
            var secretaryManager = new SecretaryManager();
            uint triesAmount = 10000;
            var result = secretaryManager.GetAvgInTries(triesAmount);
            Console.WriteLine($@"Avg score in {triesAmount} tries: {result}");
        }
    }
}
