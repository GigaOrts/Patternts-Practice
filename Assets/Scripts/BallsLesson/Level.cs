using System;

public class Level
{
    private readonly WinCondition _winCondition;
    private bool _isLevelCompleted;

    public event Action Completed;

    public Level(WinCondition winCondition)
    {
        _winCondition = winCondition;

        foreach (var ball in _winCondition.Balls)
        {
            ball.Clicked += CheckConditionCompleted;
        }
    }

    private void CheckConditionCompleted()
    {
        if (_isLevelCompleted)
            return;

        if (_winCondition.IsConditionCompleted())
        {
            Completed?.Invoke();
            _isLevelCompleted = true;
        }
    }
}
