public class EternalGoal : Goal
{
    // Default constructor for EternalGoal
    public EternalGoal()
    {
    }

    // Constructor for creating a new EternalGoal with the provided parameters
    public EternalGoal(string _goalName, string _goalDescription, int _goalValueInPoints, bool _completed, int _earnedPoints) 
        : base(_goalName, _goalDescription, _goalValueInPoints, _completed, _earnedPoints)
    {
    }

    // Method to create an EternalGoal by prompting the user for input
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine()); // Set the goal name
        Console.WriteLine("What is the description of this goal?");
        SetDescription(Console.ReadLine()); // Set the goal description
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetDesiredPoints(Convert.ToInt32(Console.ReadLine())); // Set the goal points
    }

    // Record an event for this goal (just mark it as completed)
    public override void RecordEvent()
    {
        SetCompleted(true); // An Eternal goal is completed once, immediately
        SetEarnedPoints(GetDesiredPoints()); // Earn points once the goal is recorded as completed
    }

    // Print whether the goal is complete or not
    public override string PrintIsComplete()
    {
        if (GetCompleted())
        {
            return "[X]"; // If goal is completed, show "X"
        }
        else
        {
            return "[ ]"; // Otherwise show empty box
        }
    }
}