using System;

public class SimpleGoal : Goal{

    public override string GetGoal(){
        return $"{goalType},{goalName},({goalDescription}),{goalPoints}";
    }

}