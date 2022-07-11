namespace Task.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Article { get; set; }
        public string Image { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
