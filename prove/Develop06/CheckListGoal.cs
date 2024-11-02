public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string  name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus; 
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int pointsEarned = _points;

            if (_amountCompleted == _target)
            {
                pointsEarned += _bonus;
            }
            return pointsEarned;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Completed {_amountCompleted}/{_target}, Points: {_points}, Bonus {_bonus})";
    }
}
