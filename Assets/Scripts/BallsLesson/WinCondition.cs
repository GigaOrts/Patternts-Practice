using System.Collections.Generic;

public abstract class WinCondition
{
    public readonly IReadOnlyList<Ball> Balls;
    
    public WinCondition(IEnumerable<Ball> balls)
    {
        Balls = new List<Ball>(balls);
    }

    public abstract bool IsConditionCompleted();
}
