using System.Collections.Generic;
using System.Linq;

public class WinConditionColorBallsBroken : WinCondition
{
    private readonly BallColor _pickedBallColor;

    public WinConditionColorBallsBroken(IEnumerable<Ball> balls, BallColor ballColor) : base(balls)
    {
        _pickedBallColor = ballColor;
    }

    public override bool IsConditionCompleted()
    {
        bool IsAllCorrectBallsBroken = Balls.Any(ball => ball.CurrentBallColor == _pickedBallColor && ball.gameObject.activeSelf ) == false;
        
        return IsAllCorrectBallsBroken;
    }
}
