using System.Windows.Controls;
using DataLayer.Database;
using DataLayer.Model;
using DataLayer.Repositories;

namespace UI.Components;

public partial class Student : UserControl
{
    public DatabaseStudent DBStudent { get; set; }
    public Student()
    {
        StudentRepository repository = StudentRepository.getInstance();
        DBStudent = repository.GetStudentByID(1);
        InitializeComponent();
        this.DataContext = DBStudent;
    }
}