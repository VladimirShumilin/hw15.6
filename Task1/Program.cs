var classes = new[]
          {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
var allStudents = GetAllStudents(classes);

Console.WriteLine(string.Join(" ", allStudents));

static string[] GetAllStudents(Classroom[] classes)
{
    return classes.SelectMany(s => s.Students).ToArray();
}