using System;

public class SimpleGoal : Goal{

    public override string GetGoal(){
        return $"{goalType},{goalName},({goalDescription}),{goalPoints}";
    }

    public SimpleGoal(){
        
    }
    public SimpleGoal(string b)
    {
        string[] peices = b.Split(",");

        goalName = peices[0];
        goalDescription = peices[1];

        // Error-checking and handling for goalPoints conversion
        try
        {
            goalPoints = Convert.ToInt16(peices[2]);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Error converting '{peices[2]}' to Int16 for goalPoints.");
            // Set a default value or handle the error as needed.
            goalPoints = 0; // or some other default value
        }
    }

}