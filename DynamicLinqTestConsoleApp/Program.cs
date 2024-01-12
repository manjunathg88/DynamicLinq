using Hogwards.Models;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

var studentData = new StudentData();
var students = studentData.GetStudents();

//House.Name != null && House.Name == "RavenClaw"
Console.WriteLine("----Where condition on property under a sub object----");
Console.WriteLine("----House.Name == RavenClaw----");
Console.WriteLine("----Not null check using np() function----");

var studentByHouseResult = students
    .Where("np(House.Name) == \"Ravenclaw\"")
    .ToList();

foreach (var student in studentByHouseResult)
{
    Console.WriteLine("{0}\t\t{1}\t{2}", student.Name, student.House?.Name, student.Age);
}



//Dynamically creating lambda expressions
Console.WriteLine("\n----Dynamic Lambda----");
Console.WriteLine("----Students older than 14----");

Expression<Func<Student, bool>> itExpression = DynamicExpressionParser
    .ParseLambda<Student, bool>(new ParsingConfig(), true, "House.Name == @0", "Hufflepuff");

Expression<Func<Student, bool>> ageExpression = DynamicExpressionParser
    .ParseLambda<Student, bool>(new ParsingConfig(), true, "Age >= @0", 14);

var conditionCheck = "age";
var lambdaResult = students
    .Where("@0(it)", conditionCheck == "house" ? itExpression : ageExpression)
    .ToList();

foreach (var student in lambdaResult)
{
    Console.WriteLine("{0}\t\t{1}\t{2}", student.Name, student.House?.Name, student.Age);
}



//Group sort
Console.WriteLine("\n----Group Sort----");
Console.WriteLine("----Sort by house by descending order, then sort the students starting from elder to younger under each house----");

var groupSortResult = students
        .OrderBy("np(House.Name, \"\") asc, age desc")
        .ToList();

foreach (var student in groupSortResult)
{
    Console.WriteLine("{0}\t\t{1}\t{2}", student.Name, student.House?.Name, student.Age);
}



//Selecting Data Using Dynamic LINQ
//public List<Student> GetStudents() =>
//    students
//        .Select(s => new Student
//        {
//            Name = s.Name,
//            age = s.Age,
//            House = s.House.House,
//        })
//        .ToList();

Console.WriteLine("\n----Selecting Data Using Dynamic LINQ----");

var selectStudents = students
                        .Select("new {Name, Gender, np(House.Name, \"\") as House}")
                        .ToDynamicList();

foreach (var student in selectStudents)
{
    Console.WriteLine("{0}\t\t{1}\t{2}", student.Name, student.Gender, student.House);
}

Console.WriteLine("\n");