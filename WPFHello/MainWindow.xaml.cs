using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _student = "pesho";
        
        public string Name
        {
            get { return _student; }
            set { _student = value; }
        }
        
        public MainWindow()
        {
            //InitializeComponent();
            _student = "ivan";
            InitializeComponent();
        }
        
        private void Mouse_OnMouseEnter(object sender, MouseEventArgs e)
        {
            _student = "joro";
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _student = "joro";
            InitializeComponent();
            MessageBox.Show(_student);
        }
    }
}