using System.Collections.Generic;
using System.Linq;

public class AllBallsBrokenWinCondition : IWinCondition
{
    private IEnumerable<Ball> _balls;

    public AllBallsBrokenWinCondition(IEnumerable<Ball> balls)
    {
        _balls = balls;
    }

    public bool IsPlayerWin()
    {
        return _balls.Count(ball => ball.gameObject.activeSelf) == 0;
    }
}
