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



/*using Lab2;
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

Helper.SetCreationUser(book);*/

using Lab2.Interfaces;
using Lab2.Lab6;

IBookRepository bookRepository = new BookRepository();
IPersonRepository personRepository = new PersonRepository();

foreach(var item in bookRepository.GetAll())
{
    Console.WriteLine(item.Title);
}

var book = bookRepository.Get(1);

personRepository.Create(new Person()
{
    Id = 1,
    FirstName = "Test",
    LastName = "Test",
});

personRepository.BorrowBook(1, book);
personRepository.BorrowBook(1, book);

var person = personRepository.Get(1);
Console.WriteLine($"Książki wypożyczone przez {person.FirstName} {person.LastName}");
foreach(var item in personRepository.GetBorrowedBook(person.Id))
{
    Console.WriteLine(item.Title);
}


List<int> list = new List<int>() { 0, 1, 1 };


Console.WriteLine(list.Any(x => x > 0)); // true jesli dowolny element jest wiekszy od 0
Console.WriteLine(list.All(x => x > 0)); // true jesli wszystkie elementy są wieksze od 0

list.AddRange([10, 11]); // dodanie do listy liczb 10, 11

var listof1 = list.Where(x => x == 1); //Ograniczenie listy tylko do elementów równych 1

Console.WriteLine(list.Count()); // zliczenie elementów

var arr = list.Distinct().ToArray(); // lista bez duplikatów

Console.WriteLine(list.Contains(1)); // true jeśli lista zawiera 1
Console.WriteLine(list.FirstOrDefault(x => x == 1)); // pierwszy element listy równy 1 lub null
Console.WriteLine(list.First(x => x == 1)); // pierwszy element listy równy 1 lub błąd
Console.WriteLine(list.Last()); //ostani element listy
Console.WriteLine(list.Count());
