public class ChecklistGoal : Goal
{
    private int _desiredCompletions;  // How many times goal must be accomplished for a bonus
    private int _desiredBonusPoints;  // Bonus points for completing the goal a certain number of times
    private int _progress;           // Tracks the number of times the goal has been completed

    public ChecklistGoal(string _goalName, string _goalDescription, int progress, int desiredCompletions, int desiredBonus, bool _completed, int _goalValueInPoints, int _earnedPoints)
        : base(_goalName, _goalDescription, _goalValueInPoints, _completed, _earnedPoints)
    {
        _desiredCompletions = desiredCompletions;
        _desiredBonusPoints = desiredBonus;
        _progress = progress;
    }

    // Increase progress when goal is completed
    public void SetProgress()
    {
        _progress++;
    }

    // Get the current progress of the goal
    public int GetProgress()
    {
        return _progress;
    }

    // Set how many completions are needed for a bonus
    public void SetDesiredCompletions(int desired)
    {
        _desiredCompletions = desired;
    }

    // Get the number of completions needed for a bonus
    public int GetDesiredCompletions()
    {
        return _desiredCompletions;
    }

    // Set the bonus points
    public void SetBonus(int desired)
    {
        _desiredBonusPoints = desired;
    }

    // Get the bonus points
    public int GetBonus()
    {
        return _desiredBonusPoints;
    }

    // Default constructor for ChecklistGoal
    public ChecklistGoal()
    {
    }

    // Method to create a new goal by prompting user for input
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is the description of this goal?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetDesiredPoints(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        SetDesiredCompletions(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("What is the bonus for completing it many times?");
        SetBonus(Convert.ToInt32(Console.ReadLine()));
    }

    // Record an event for this goal (increment progress)
    public override void RecordEvent()
    {
        SetProgress();
        SetEarnedPoints(GetDesiredPoints());

        // If goal is completed a required number of times, mark as complete and apply bonus
        if (GetProgress() == GetDesiredCompletions())
        {
            SetCompleted(true);
            SetEarnedPoints(GetBonus());
        }
    }

    // Print if goal is complete or not
    public override string PrintIsComplete()
    {
        if (GetCompleted())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
}