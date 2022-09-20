namespace SecretaryProblem1
{
    static class Program
    {
        static void Main(string[] args)
        {
            var secretaryManager = new SecretaryManager();
            var result = secretaryManager.NewTry();
            Console.WriteLine($@"Result: {result}");
        }
    }
}

