using System;

public abstract class Goal{

    protected string goalName;
    protected string goalDescription;
    protected int goalPoints;
    protected int amountToCompleteGoal;
    protected int goalIntegral;

    protected string goalType;

    public string GetGoalType()
    {
        return goalType;
    }

    public void SetGoalType(string goalType)
    {
        this.goalType = goalType;
    }

    // protected int goalComplete;

    public int GetIntegral(){
        return goalIntegral;
    }

    public void SetIntegral(int goalIntegral){
        this.goalIntegral = goalIntegral;
    }


    public int GetAmountToCompleteGoal()
    {
        return amountToCompleteGoal;
    }

    public void SetAmountToCompleteGoal(int amountToCompleteGoal)
    {
        this.amountToCompleteGoal = amountToCompleteGoal;
    }

    public string GetGoalName()
    {
        return goalName;
    }

    public void SetGoalName(string goalName)
    {
        this.goalName = goalName;
    }

    public string GetGoalDescription()
    {
        return goalDescription;
    }

    public void SetGoalDescription(string goalDescription)
    {
        this.goalDescription = goalDescription;
    }

    public int GetGoalPoints()
    {
        return goalPoints;
    }

    public void SetGoalPoints(int value)
    {
        goalPoints = value;
    }

    // public string IsGoalComplete(bool complete){
    //     if (complete){
    //         return "[✔️]";
    //     } else {
    //         return "[ ]";
    //     }
    // }

    public abstract string GetGoal();

}