using System.Collections.Generic;
using System.Linq;

public class OneColorBallsBrokenWinCondition : IWinCondition
{
    private IEnumerable<Ball> _balls;
    private BallColor _color;

    public OneColorBallsBrokenWinCondition(IEnumerable<Ball> balls, BallColor color)
    {
        _balls = balls;
        _color = color;
    }

    public bool IsPlayerWin()
    {
        return _balls.Count(ball => ball.Color == _color && ball.gameObject.activeSelf) == 0;
    }
}
