namespace SecretaryProblem1;

public class SecretaryManager
{
    public int NewTry()
    {
        const int contendersAmount = 100;
        var contenderGenerator = new ContenderGenerator();
        var hall = new Hall(contenderGenerator.GenerateContenders(contendersAmount));
        var friend = new Friend();
        var princess = new Princess(friend);
        for (int i = 0; i < contendersAmount; ++i)
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

    private int GetFinalScore(Contender contender)
    {
        const int looseValue = 0;
        const int thresholdValue = 51;
        var contenderValue = contender.GetValue();
        return contenderValue >= thresholdValue ? contenderValue : looseValue;
    }
}