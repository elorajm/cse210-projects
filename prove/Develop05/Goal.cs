// Abstract base class for all goal types
public abstract class Goal
{
    // Protected fields to store goal information that can be accessed by derived classes
    protected string _goalName; // Name of the goal
    protected string _goalDescription; // Description of the goal
    protected int _goalValueInPoints; // Points assigned to the goal
    protected bool _completed = false; // Tracks if the goal is completed or not
    protected int _earnedPoints; // Points earned based on the goal completion

    // Default constructor - for when we want to create an empty goal object
    public Goal() { }

    // Constructor with parameters to initialize a goal with a name, description, point value, completion status, and earned points
    public Goal(string name, string description, int goalValue, bool completed, int earnedPoints)
    {
        _goalName = name;
        _goalDescription = description;
        _goalValueInPoints = goalValue;
        _completed = completed;
        _earnedPoints = earnedPoints;
    }

    // Constructor with just the name and description for creating a goal with the completion status defaulted to false
    public Goal(string name, string description, bool completed)
    {
        _goalName = name;
        _goalDescription = description;
        _completed = completed;
    }

    // Protected setter for the goal's name - allows derived classes to set the name of the goal
    protected void SetGoalName(string name)
    {
        _goalName = name;
    }

    // Protected setter for the goal's description - allows derived classes to set the description
    protected void SetDescription(string description)
    {
        _goalDescription = description;
    }

    // Protected setter for the goal's point value - allows derived classes to set the point value
    protected void SetDesiredPoints(int points)
    {
        _goalValueInPoints = points;
    }

    // Protected setter for the completion status - allows derived classes to mark the goal as complete or not
    protected void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    // Protected setter for earned points - allows derived classes to set how many points were earned
    protected void SetEarnedPoints(int earnedPoints)
    {
        _earnedPoints = earnedPoints;
    }

    // Getter for the goal's name
    public string GetGoalName() => _goalName;

    // Getter for the goal's description
    public string GetDescription() => _goalDescription;

    // Getter for the goal's point value
    public int GetDesiredPoints() => _goalValueInPoints;

    // Getter for the completion status of the goal
    public bool GetCompleted() => _completed;

    // Getter for the earned points for the goal
    public int GetEarnedPoints() => _earnedPoints;

    // Abstract method for creating a goal. This will be implemented in the derived classes.
    public abstract void CreateGoal();

    // Abstract method for recording an event related to the goal. This will also be implemented in derived classes.
    public abstract void RecordEvent();

    // Abstract method to print if the goal is complete or not. Derived classes will define the exact behavior.
    public abstract string PrintIsComplete();
}