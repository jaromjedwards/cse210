using System;

public class Assignment
{
    private string studentName;
    private string course;
    private double textbookSection;

    private double firstQuestion;
    private double lastQuestion;

    public Assignment(string studentName, string course, double textbookSection, double firstQuestion, double lastQuestion)
    {
        this.studentName = studentName;
        this.course = course;
        this.textbookSection = textbookSection;
        this.firstQuestion = firstQuestion;
        this.lastQuestion = lastQuestion;
    }

    public string showAssignment()
    {
        return $"Student: {studentName}\nCourse: {course}\nSection: {textbookSection}\nQuestions: {firstQuestion}-{lastQuestion}\n";
    }

}