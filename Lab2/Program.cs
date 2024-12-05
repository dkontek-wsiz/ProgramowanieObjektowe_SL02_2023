// See https://aka.ms/new-console-template for more information
/*
using Lab2.Models;

Console.WriteLine("Hello, World!");


Person os = new Person();

os.Welcome();
os.Welcome("DD");

var n = new User { UserName = "Test" };
n.UserName = "Test2";


var os2 = Person.MapUser(n);


Console.WriteLine(os2.Name);

var sum = new Sumartor(new[] { 10, 20, 30, 40 });

Console.WriteLine(sum.Count());
Console.WriteLine(sum.SumDiv3());
Console.WriteLine(sum.Sum());
sum.Display(1, 2);

*/


/*
Shape rec = new Rectangle();
var rec2 = new Rectangle();


var shapes = new List<Shape>()
{
    rec,
    rec2,
    new Shape()
};
*//*shapes.Add(rec);
shapes.Add(rec2);
shapes.Add(new Shape());*//*

foreach (var shape in shapes)
{
    shape.Draw();
}
*/

/*
using Lab2.Models;

var person = new Person();

person.SetName("name");
person.SetSurname("name");
person.SetPesel("02261072763");

Console.WriteLine(person.GetGender());
Console.WriteLine(person.GetAge());*/



using Lab2;
using Lab2.Lab5;
using Lab2.Lab6;

//Shape shape = new Shape();
Shape shape = new Square() {X = 5 };

Console.WriteLine(shape.CalulateArea());


IVehicle car = new Car();

try
{

    car.Start();

    car.Stop();
}
catch(NotImplementedException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

var book = new Book();

Helper.SetCreationUser(book);