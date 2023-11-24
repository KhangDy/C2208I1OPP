using OPP;

//object by constructor
//Student stu1= new Student(1, "dy", true, new DateTime(2004, 08, 03));
//Student stu2= new (1, "dy", true, new DateTime(2004, 08, 03));
Student stu3 = new()
{
    Id = 3,
    Gender = false,
    Fullname = "trong",
    Dob =DateTime.Now,
};
Console.WriteLine(stu3);