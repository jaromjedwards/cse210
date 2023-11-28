using System;

public class EternalGoal : Goal{

    public override string GetGoal(){
        return $"{goalType},{goalName},({goalDescription}),{goalPoints}";
    }
}