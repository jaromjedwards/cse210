using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Person person1 = new Person();
        person1._familyName = "Edwards";
        person1._givenName = "Jarom";
        person1.ShowEasternName();

        Person person2 = new Person();
        person2._familyName = "Edwards";
        person2._givenName = "Kayla";
        person2.ShowEasternName();

        Window kitchen = new Window();
        kitchen._width = 5;
        kitchen._height = 4;
        kitchen._color = "Transparent";
        kitchen.DisplayMeasurements("Kitchen");

        Window livingRoom = new Window();
        livingRoom._width = 6;
        livingRoom._height = 4;
        livingRoom._color = "Transparent";
        livingRoom.DisplayMeasurements("Living Room");

        House edwardsHouse = new House();
        edwardsHouse._owner = "Edwards";
        edwardsHouse._blinds.Add(kitchen);
        edwardsHouse.DisplayOwner();

    }
}




public class Person
{
    public string _givenName = "";
    public string _familyName = "";

    public Person()
    {
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName}, {_familyName}");
    }
}

public class Window
{
    public double _width;
    public double _height;
    public string _color;

    public double GetArea(){
        return _width * _height;
    }

    public void DisplayMeasurements(string room)
    {
        Console.WriteLine($"{room}\nWidth: {_width}\nColor: {_color} \nArea: {GetArea()}\n");
    }
}

public class House{
    public string _owner;
    public List<Window> _blinds = new List<Window>();

    public void DisplayOwner(){
        Console.WriteLine($"{_owner}");
    }
}