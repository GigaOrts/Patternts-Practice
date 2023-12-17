using System.Collections.Generic;
using System.Linq;

public class WinConditionAllBallsBroken : WinCondition
{
    public WinConditionAllBallsBroken(IEnumerable<Ball> balls) : base(balls)
    {
    }

    public override bool IsConditionCompleted()
    {
        return Balls.Any(ball => ball.gameObject.activeSelf) == false;
    }
}
