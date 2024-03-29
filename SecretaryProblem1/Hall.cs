﻿namespace SecretaryProblem1;

public class Hall //: //IEnumerable<Contender>
{
    private readonly Queue<Contender> _contenders;

    public Hall(List<Contender> contenders)
    {
        _contenders = new Queue<Contender>(contenders);
    }

    public Contender NextContender()
    {
        return _contenders.Dequeue();
    }
}