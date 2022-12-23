namespace SecretaryProblem1
{
    static class Program
    {
        static void Main()
        {
            var secretaryManager = new SecretaryManager();
            int iterations = 1000;
            double result = secretaryManager.GetAvgInTries(iterations);
            Console.WriteLine($@"iterations: {iterations}, avg score: {result}");
        }
    }
}
