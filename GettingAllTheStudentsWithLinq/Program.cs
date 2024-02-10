namespace GettingAllTheStudentsWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
                new Classroom { Students = {"Bulat", "Alex", "Galina"} }
            };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(String.Join(" ", allStudents));
        }

        static String[] GetAllStudents(Classroom[] classes) =>
            classes.SelectMany(x => x.Students).ToArray();
    }

    public class Classroom
    {
        public List<String> Students = new List<String>();
    }
}