using System.ComponentModel;

namespace WebApplication3HtmlHelperClasses.Models
{
    public class Student
    {
        [DisplayName("Student Id")]
        public int Id { get; set; }
        [DisplayName("Enter Full Name")]
        public string Name { get; set; }
        public string Address { get; set; }

        [DisplayName("Date of Birth")]
        public DateOnly Dob { get; set; }
        public string Email { get; set; }
    }
}
