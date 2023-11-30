using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static void Main(string[] args)
    {
        string userChoice = "0";
        string fileName = "goals.txt";

        LoadGoals();


        while (userChoice != "6")
        {
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit \nSelect a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
                string goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    SimpleGoal simpleGoal1 = new SimpleGoal();
                    simpleGoal1.SetGoalType("Simple Goal:");

                    Console.WriteLine("What is your simple goal? ");
                    string name = Console.ReadLine();
                    simpleGoal1.SetGoalName(name);

                    Console.WriteLine("What is the description of the goal?");
                    string description = Console.ReadLine();
                    simpleGoal1.SetGoalDescription(description);

                    Console.WriteLine("What is the amount of points you will receive for the goal?");
                    int points = Convert.ToInt32(Console.ReadLine());
                    simpleGoal1.SetGoalPoints(points);

                    simpleGoal1.SetAmountToCompleteGoal(1);
                    goals.Add(simpleGoal1);
                }

                if (goalType == "2")
                {
                    EternalGoal eternalGoal1 = new EternalGoal();
                    eternalGoal1.SetGoalType("Eternal Goal");

                    Console.WriteLine("What is your simple goal? ");
                    string name = Console.ReadLine();
                    eternalGoal1.SetGoalName(name);

                    Console.WriteLine("What is the description of the goal?");
                    string description = Console.ReadLine();
                    eternalGoal1.SetGoalDescription(description);

                    Console.WriteLine("What is the amount of points you will receive for the goal?");
                    int points = Convert.ToInt32(Console.ReadLine());
                    eternalGoal1.SetGoalPoints(points);

                    eternalGoal1.SetAmountToCompleteGoal(0);
                    goals.Add(eternalGoal1);
                }

                if (goalType == "3")
                {
                    ChecklistGoal checklistGoal1 = new ChecklistGoal();
                    checklistGoal1.SetGoalType("Checklist Goal");

                    Console.WriteLine("What is your simple goal? ");
                    string name = Console.ReadLine();
                    checklistGoal1.SetGoalName(name);

                    Console.WriteLine("What is the description of the goal?");
                    string description = Console.ReadLine();
                    checklistGoal1.SetGoalDescription(description);

                    Console.WriteLine("What is the amount of points you will receive for the goal?");
                    int points = Convert.ToInt32(Console.ReadLine());
                    checklistGoal1.SetGoalPoints(points);

                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    checklistGoal1.SetAmountToCompleteGoal(amount);

                    Console.WriteLine("What is the bonus for when this goal is completed?");
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    checklistGoal1.SetBonusPoints(bonus);
                    goals.Add(checklistGoal1);
                }
            }
            else if (userChoice == "3")
            {
                int index = 0;

                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    foreach (Goal g in goals)
                    {
                        string goal = g.GetGoal();
                        outputFile.WriteLine($"{goal}");
                    }
                }
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Which goal did you make progress on?");
            }
        } 
        static void LoadGoals()
        {
            string fileName = "goals.txt";
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines){
                string[] elements = line.Split(":");
                
                string a = elements[0];
                string b = elements[1];

                if (a == "Simple Goal"){
                    SimpleGoal simpleGoal1 = new SimpleGoal(b);
                    simpleGoal1.SetGoalType("Checklist Goal");

                    goals.Add(simpleGoal1);
                    
                }

                // line index 0 = typepf goal
                // line index 1 = the rest

            }

        
            // string fileName = "goals.txt";
            // string[] lines = File.ReadAllLines(fileName);
            // foreach (string line in lines)
            // {
            //     Console.WriteLine(line);
            // }
        }
    }
}
