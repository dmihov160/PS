using DataLayer.Model;
using DataLayer.Repositories;

namespace DataLayer.Services;

public class StudentService
{
    private StudentRepository _studentRepository;

    public StudentService()
    {
        _studentRepository = StudentRepository.getInstance();
    }

    public IEnumerable<DatabaseStudent> GetAllStudents()
    {
        return _studentRepository.GetStudents();
    }

    public DatabaseStudent GetStudentById(int id)
    {
        return _studentRepository.GetStudentByID(id);
    }

    public void InsertStudent(DatabaseStudent student)
    {
        _studentRepository.InsertStudent(student);
    }

    public void DeleteUser(DatabaseStudent student)
    {
        _studentRepository.DeleteStudent(student.Id);
    }
    
    public void SaveContext()
    {
        _studentRepository.Save();
    }
}