namespace SecretaryProblem1;

public class Friend
{
    //private readonly List<Contender> _rejectedContenders = new List<Contender>();
    private int _maxValue = Int32.MinValue;

    public void RememberContender(Contender contender)
    {
        var currentContenderValue = contender.GetValue();
        if (_maxValue < currentContenderValue)
        {
            _maxValue = currentContenderValue;
        }
        //_rejectedContenders.Add(contender);
    }

    public bool IsBetterThanOthers(Contender contender)
    {
        return contender.GetValue() > _maxValue;
    }
}