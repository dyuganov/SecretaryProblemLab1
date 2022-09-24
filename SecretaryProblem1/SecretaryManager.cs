namespace SecretaryProblem1;

public class SecretaryManager
{
    private const int ContendersAmount = 100;

    private int NewTry()
    {
        var contenderGenerator = new ContenderGenerator();
        var hall = new Hall(contenderGenerator.GenerateContenders(ContendersAmount));
        var friend = new Friend();
        var princess = new Princess(friend);
        for (int i = 0; i < ContendersAmount; ++i)
        {
            var currentContender = princess.MakeChoice(hall.NextContender());
            if(null != currentContender)
            {
                return GetFinalScore(currentContender);
            }
        }
        const int contenderNotFoundValue = 10;
        return contenderNotFoundValue;
    }

    public double GetAvgInTries(uint amount)
    {
        long scoreSum = 0;
        for (uint i = 0; i < amount; ++i)
        {
            scoreSum += NewTry();
        }
        return (scoreSum == 0 || amount == 0) ? (0) : (scoreSum / amount);
    }

    private int GetFinalScore(Contender contender)
    {
        const int looseValue = 0;
        const int thresholdValue = 51;
        var contenderValue = contender.GetValue();
        return contenderValue >= thresholdValue ? contenderValue : looseValue;
    }
}