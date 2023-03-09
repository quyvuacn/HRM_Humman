namespace HRM_Humman.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { set; get; }
        public DateTime JoinDate { get; set; }

    }
}
