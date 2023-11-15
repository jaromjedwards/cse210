using System;
class Program{

    static void Main(string[] args){
        
    Job job1 = new Job();
    job1._company = "Pizza Hut";
    job1._title = "Delivery Driver";
    job1._startYear = 2023;
    job1._endYear = 2024;
    // Step 5
    job1.DisplayJobInformation();

    Resume person1 = new Resume();
    person1._fullName = "Jarom Edwards";
    person1._jobs.Add(job1);

    person1.DisplayResume();

    }

}