using System;

public class ChecklistGoal : Goal{

    protected int bonusPoints;


    public int GetBonusPoints(){
        return bonusPoints;
    }

    public void SetBonusPoints(int bonusPoints){
        this.bonusPoints = bonusPoints;
    }

    public override string GetGoal(){
        return $"{goalType},{goalName},({goalDescription}),{goalPoints},{goalIntegral},{amountToCompleteGoal},{bonusPoints}";
    }

}