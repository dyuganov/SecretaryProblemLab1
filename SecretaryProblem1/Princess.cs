namespace SecretaryProblem1;

public class Princess
{
    private readonly Friend _friend;
    private const int ContendersToSkip = 57;
    private uint _skippedContendersCnt = 0;
    private const int BetterContendersToSkip = 2;

    public Princess(Friend friend)
    {
        _friend = friend;
    }
    
    // null == skip, contender == choose this 
    public Contender? MakeChoice(Contender? contender)
    {
        if (contender == null) return null;
        if (_skippedContendersCnt < ContendersToSkip)
        {
            _friend.RememberContender(contender);
            ++_skippedContendersCnt;
            return null;
        }
        return _friend.CountBetterContenders(contender) == BetterContendersToSkip ? contender : null;
    }
}