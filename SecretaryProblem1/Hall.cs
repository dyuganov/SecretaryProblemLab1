namespace SecretaryProblem1;

public class Hall
{
    private Stack<Contender> _contenders;

    public Hall(List<Contender> contenders)
    {
        _contenders = new Stack<Contender>(contenders);
    }

    public Contender NextContender()
    {
        return _contenders.Pop();
    }

    public Contender PeekContender()
    {
        return _contenders.Peek();
    }
}