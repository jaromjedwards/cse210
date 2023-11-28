using System;


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.SetWidth(3);
            rectangle1.SetHeight(5);
            rectangle1.SetColor("Gold");

            Square square1 = new Square();
            square1.SetSide(4);
            square1.SetColor("Purple");

            Circle circle1 = new Circle();
            circle1.SetRadius(6);
            circle1.SetColor("Fire");

            List<Shapes> shapes = new List<Shapes>();

            shapes.Add(rectangle1);
            shapes.Add(square1);
            shapes.Add(circle1);

            foreach (Shapes sha in shapes){
                float area = sha.GetArea();
                Console.WriteLine($"The area of the {sha} is {area}");
                
            }

        }
    }




































// namespace employee_demo{

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             HourlyEmployee hourlyEmployee1 = new HourlyEmployee();
//             hourlyEmployee1.SetName("John");
//             hourlyEmployee1.SetIdNumber("123abc");
//             hourlyEmployee1.SetPayRate(15);
//             hourlyEmployee1.SetHoursWorked(8);

//             SalaryEmployee salaryEmployee1 = new SalaryEmployee();
//             salaryEmployee1.SetName("Peter");
//             salaryEmployee1.SetIdNumber("fh747");
//             salaryEmployee1.SetSalary(70000);

//             DisplayEmployeeInformation(hourlyEmployee1);
//             DisplayEmployeeInformation(salaryEmployee1);

//             List<Employee> employees = new List<Employee>();
//             employees.Add(salaryEmployee1);
//             employees.Add(hourlyEmployee1);

//             foreach (Employee emp in employees){
//                 float pay = emp.GetPay();
//                 Console.WriteLine(pay);
//             }


//         }

//         public static void DisplayEmployeeInformation(Employee employee){
            
//             string name = employee.GetName();
//             float pay = employee.GetPay();
//             Console.WriteLine($"{name} will be payed ${pay}");
            
//         }

//     }
// }

