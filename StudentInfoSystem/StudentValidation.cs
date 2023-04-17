using System;

namespace StudentInfoSystem;

public class StudentValidation
{
    public Student GetStudentDataByUser(User user)
    {
        StudentData data = new StudentData();
        Student student = data.TestStudents.Find(student => 
            student.FacultyNumber.Equals(user.FacultyNumber)
            );
        if (user.FacultyNumber == null || student == null)
            throw new Exception("Missing fnum or no available student");
        return student;
    }
}