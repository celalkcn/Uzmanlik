/* LINQ (Language Integrated Query): c# programlama dilinde veri sorgulama ve dönüştürme işlemlerini Basitleştiren
çok güçlü bir özelliktir.Amaç : farklı veri kaynaklarından sorgulama yapmayı kolaylaştırarak standart ve daha okunabilir hale getirmektedir
 
 TEMEL ÖZELLİKLER : 
 1 - Syntax (Söz dizimii) Bütünlüğü
 2 - Tip Güvenliği  
 3 - görece Performans Artışı

 *** NOT: Bazı durumlar için LINQ tercih edilmez.
 LINQ Türleri :
 1) LINQ to Objects
 2) LINQ to Entities
 3) LINQ to XML
 4) LINQ to Dataset


*/ 

// Method Syntax

// int[] numbers = [10,2,3,4,5,6,7,8,9,1];

// var result1 = numbers.Where(x=>x%2==0);
// var result2 = numbers.OrderBy(x=> x);
// var result3 = numbers.Select(x=> x*x);


// foreach (var number in  result2)
// {
//     System.Console.WriteLine(number);
// }

// // Query Syntax

// var result4 = from number  in numbers 
//               where number % 2 == 0
//               select number;


// Lınq to objects
List<Student>students=[
    new Student{Id=1,Name ="Ayşen", Age = 18 ,Grade = 85},
    new Student{Id=1,Name ="Mehmet", Age = 25 ,Grade = 65},

    new Student{Id=1,Name ="ceren", Age = 19 ,Grade = 100},

    new Student{Id=1,Name ="selim", Age = 20 ,Grade = 95},

];
// Grade değeri 90 ve üzeri olanları filtrelemek istiyoruz
// 1 ) Method Syntax
var result = students.Where(x=> x.Grade>= 90)
                     .OrderBy(x=>x.Name);

// foreach (var s in result)
// {
//     System.Console.WriteLine($"{s.Name}: {s.Grade}");
// }

// 2 ) Query Syntax 

var resultQuery = from student in students 
                  where student.Grade >=90
                  orderby student.Name 
                  select student;

//     foreach (var s in resultQuery)
// {
//     System.Console.WriteLine($"{s.Name}: {s.Grade}");
// }




class Student {
public int Id { get; set; }
public string Name { get; set; }

public int Age { get; set; }
public int Grade { get; set; }

}