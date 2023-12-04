using System;

public class Person{

    private string firstName;
    private string lastName;
    private string gender;

    private int age;

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

    public string getGender(){
        return gender;
    }

    public void setGender(string gender){
        this.gender = gender;
    }

    public int getAge(){
        return age;
    }

    public void setAge(int age){
        this.age = age;
    }

}