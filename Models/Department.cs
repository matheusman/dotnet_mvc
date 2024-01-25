namespace Course_Aspnetcore_mvc.Models
{
    public class Department
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Department(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}