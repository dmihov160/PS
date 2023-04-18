using DataLayer.Database;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories;

public class StudentRepository
{
    private StudentContext _context;
    
    private bool _disposed = false;

    private static StudentRepository _instance;

    private StudentRepository(StudentContext context)
    {
        _context = context;
    }

    public static StudentRepository getInstance()
    {
        if (_instance == null)
        {
            _instance = new StudentRepository(new StudentContext());
            return _instance;
        }

        return _instance;
    }
    
    public IEnumerable<DatabaseStudent> GetStudents()
    {
        return _context.DatabaseStudents.ToList();
    }
    public DatabaseStudent GetStudentByID(int id)
    {
        return _context.DatabaseStudents.Find(id);
    }

    public void InsertStudent(DatabaseStudent student)
    {
        _context.DatabaseStudents.Add(student);
    }

    public void DeleteStudent(int studentID)
    {
        DatabaseStudent student = _context.DatabaseStudents.Find(studentID);
        _context.DatabaseStudents.Remove(student);
    }
    
    public void Save()
    {
        _context.SaveChanges();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        this._disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}