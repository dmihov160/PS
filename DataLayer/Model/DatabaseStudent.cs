using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model;
[Table("DatabaseStudent")]
public class DatabaseStudent
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string FullName { get; set; }
    public string? Faculty { get; set; }
    public string? Speciality { get; set; }
    public string? EducationLevel { get; set; }
    public string? FacultyNumber { get; set; }
    public int? Course { get; set; }
    public int? Potok { get; set; }

    public DatabaseStudent(string fullName, string faculty, string speciality, string educationLevel, string facultyNumber, int course, int potok)
    {
        FullName = fullName;
        Faculty = faculty;
        Speciality = speciality;
        EducationLevel = educationLevel;
        FacultyNumber = facultyNumber;
        Course = course;
        Potok = potok;
    }

    public DatabaseStudent()
    {
    }
}