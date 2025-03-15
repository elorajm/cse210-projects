public class SimpleGoal : Goal
{
    // Default constructor for SimpleGoal
    public SimpleGoal()
    {
    }

    // Constructor to initialize the SimpleGoal with provided values
    public SimpleGoal(string _goalName, string _goalDescription, int _goalValueInPoints, bool _completed, int _earnedPoints) 
        : base(_goalName, _goalDescription, _goalValueInPoints, _completed, _earnedPoints)
    {
    }

    // Method to create a new SimpleGoal by prompting the user for input
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine()); // Set the goal name
        Console.WriteLine("What is the description of this goal?");
        SetDescription(Console.ReadLine()); // Set the goal description
        Console.WriteLine("How many points do you want to set for this goal? ");
        SetDesiredPoints(Convert.ToInt32(Console.ReadLine())); // Set the goal points
    }

    // Record an event for this goal (mark it as completed)
    public override void RecordEvent()
    {
        SetCompleted(true); // Simple goal is completed once it's recorded
        SetEarnedPoints(GetDesiredPoints()); // Earn points for completing this goal
    }

    // Print whether the goal is complete or not
    public override string PrintIsComplete()
    {
        if (GetCompleted())
        {
            return "[X]"; // Display "X" if goal is completed
        }
        else
        {
            return "[ ]"; // Display empty box if goal is not completed
        }
    }
}