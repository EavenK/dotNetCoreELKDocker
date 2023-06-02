// See https://aka.ms/new-console-template for more information
//Top Level Statement
global using EcommerceConsoleApp.Models;
using System.Data.Common;

Console.WriteLine("Hello, World! .Net Core 7");

//instance for Category
var electronicCategory = new Category
{
    CategoryId = new Random().NextInt64(10000),
    CategoryName = "Electronics",
    CreatedBy = "User1",
    CreatedDate = new DateTime(2023, 1, 1),
    IsActive = true
};

//init cannot
//set
electronicCategory.IsActive = false;
electronicCategory.ModifiedBy = "user2";
electronicCategory.ModifiedDate = new DateTime(2023, 5, 5);


var furnitureCategory = electronicCategory with 
{
    CategoryId = new Random().NextInt64(20000),
    CategoryName = "Furniture"

};

Console.WriteLine($"Eletronic Category {electronicCategory}");

Console.WriteLine($"Furniture Category {furnitureCategory}");


var elecCategory = new Category1
(
    new Random().NextInt64(10000),
    "Electronics",
    "User1",
    DateTime.Now
);
//immutability - cannot be mutable with this () of declaration in Models 
//elecCategory.CreatedBy = "user2";
Console.WriteLine($"Elec Category {elecCategory}");

//Line Feed 
long month = new Random().NextInt64(11);
Console.WriteLine($"Month is {month}");
string Season = $"The season is { month switch
{ 
    1 or 2 or 12 => "winter",
    >2 and <6 => "spring",
    >5 and <9 => "summer",
    >8 and <12 => "autumn",
    _ => "Unknown. Wrong Month Number",

}}";

Console.WriteLine(Season);

Console.ReadKey();
