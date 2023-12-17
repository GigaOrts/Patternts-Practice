using System.Collections.Generic;

public class WinConditionPicker
{
    private readonly Dictionary<GameMode, WinCondition> _winConditions;

    public WinConditionPicker(IEnumerable<Ball> balls, BallColor ballColor)
    {
        _winConditions = new Dictionary<GameMode, WinCondition>()
        {
            { GameMode.AllBallsBroken, new WinConditionAllBallsBroken(balls) },
            { GameMode.ColorBallsBroken, new WinConditionColorBallsBroken(balls, ballColor) }
        };
    }

    public WinCondition GetWinCondition(GameMode gameMode)
    {
        return _winConditions[gameMode];
    }
}
