// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning03 World!");
//         Random rng = new Random();
//         List <int> ints = new List<int>();

//         Fraction fraction = new Fraction(1, 2);
//         Console.WriteLine(fraction.Display());

//         Fraction fraction2 = new Fraction();
//         Console.WriteLine("enter top");
//         int top = int.Parse(Console.ReadLine());
//         fraction2.SetTop(top);

//         Console.WriteLine("enter bottom");
//         int bottom = int.Parse(Console.ReadLine());
//         fraction2.SetBottom(bottom);

//         Console.WriteLine(fraction2.Display());

//     }
// }

// public class Fraction
// {
//     private int top;
//     private int bottom;

//     public Fraction(){
//     }

//     public Fraction(int top, int bottom){
//         this.top = top;
//         this.bottom = bottom;
//     }

//     public void SetTop(int top){
//         this.top = top;
//     }

//     public void SetBottom(int bottom){
//         this.bottom = bottom;
//     }

//     public int GetBottom(){
//         return bottom;
//     }

//     public string Display(){
//         return $"{top}/{bottom}";
//     }

// }