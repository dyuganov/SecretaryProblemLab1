namespace SecretaryProblem1;

public class Princess
{
    private readonly Friend _friend;
    private uint _skippedContendersCnt = 0;
    private const int ContendersToSkip = 7;

    public Princess(Friend friend)
    {
        _friend = friend;
    }
    
    // null == skip, contender == choose this 
    public Contender? MakeChoice(Contender contender)
    {
        if (_skippedContendersCnt < ContendersToSkip)
        {
            _friend.RememberContender(contender);
            ++_skippedContendersCnt;
            return null;
        }

        if (_friend.IsBetterThanOthers(contender)) return contender;
        _friend.RememberContender(contender);
        ++_skippedContendersCnt;
        return null;
    }
}