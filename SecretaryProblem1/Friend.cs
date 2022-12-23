namespace SecretaryProblem1;

public class Friend
{
    private readonly List<Contender> _rejectedContenders = new List<Contender>();
    private int _maxValue = Int32.MinValue;
    private Contender? _bestContender = null;

    public void RememberContender(Contender contender)
    {
        _bestContender ??= contender;
        if (contender.GetValue() > _maxValue)
        {
            _maxValue = contender.GetValue();
            _bestContender = contender;
        }
        _rejectedContenders.Add(contender);
    }

    public bool IsBetterThanOthers(Contender contender)
    {
        return contender.GetValue() > _maxValue;
    }

    public int CountBetterContenders(Contender contender)
    {
        var comparedContenderResult = contender.GetValue();
        return _rejectedContenders.Count(rejectedContender => comparedContenderResult < rejectedContender.GetValue());
    }

    public bool IsNPointsWorthThanBest(int n, Contender contender)
    {
        return (_maxValue - contender.GetValue()) == n;
    }
}