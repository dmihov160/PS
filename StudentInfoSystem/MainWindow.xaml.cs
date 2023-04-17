using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student _student;
        public MainWindow()
        {
            _student = new Student();
            _student.FullName = "Damyan Kaloyan Mihov";
            _student.Course = 3;
            _student.Faculty = "FCST";
            _student.Status = "Active";
            _student.Group = 42;
            _student.Potok = 9;
            _student.Speciality = "KSI";
            _student.EducationLevel = "Bachelor";
            InitializeComponent();
            this.DataContext = _student;
        }
    }
}