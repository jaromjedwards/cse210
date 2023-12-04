using System;

public class Person{

    private string firstName;
    private string lastName;
    private char gender;

    public string getFirstName(){
        return firstName;
    }

    public void setFirstName(string firstName){
        this.firstName = firstName;
    }

    public string getLastName(){
        return lastName;
    }

    public void setlastName(string lastName){
        this.lastName = lastName;
    }

    public char getGender(){
        return gender;
    }

    public void setGender(char gender){
        this.gender = gender;
    }

}