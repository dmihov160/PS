using System.Linq;
using System.Windows.Controls;
using DataLayer.Database;

namespace UI.Components;

public partial class StudentList : UserControl
{
    public StudentList()
    {
        InitializeComponent();
        using (var context = new DatabaseContext())
        {
            var records = context.Users.ToList();
            students.DataContext = records;
        }
    }
}