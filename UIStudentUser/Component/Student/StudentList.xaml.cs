﻿using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using DataLayer.Model;
using DataLayer.Services;

namespace UIStudentUser.Component.Student;

public partial class StudentList : UserControl
{
    private StudentService _studentService;
    
    public StudentList()
    {
        InitializeComponent();
        _studentService = new StudentService();
        InitStudents();
        var list = _studentService.GetAllStudents();
        students.DataContext = list;
    }

    private void InitStudents()
    {
        for (int i = 1; i <= 10; i++)
        {
            DatabaseStudent student = new DatabaseStudent();
            student.FullName = "Ivan Ivanov Ivanov";
            student.Course = 3;
            _studentService.InsertStudent(student);
        }
        _studentService.SaveContext();
    }
}