using System;

public class SimpleGoal : Goal{

    public override string GetGoal(){
        return $"{goalType},{goalName},({goalDescription}),{goalPoints}";
    }

    public SimpleGoal(string b){

        string[] peices = b.Split(",");

        goalName = peices[0];
        goalDescription = peices[1];
        goalPoints = Convert.ToInt16(peices[2]);
        
    }

}