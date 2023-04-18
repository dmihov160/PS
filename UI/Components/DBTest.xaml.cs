using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace UI.Components;

public partial class DBTest : UserControl
{
    public List<string> StudStatusChoices { get; set; }
    
    public DBTest()
    {
        InitializeComponent();
        this.DataContext = this;
        fillStudStatusChoices();
    }

    private void fillStudStatusChoices()
    {
        StudStatusChoices = new List<string>(); 
        using (IDbConnection connection = new
                   SqlConnection("Server=localhost\\SQLEXPRESS;Database=StudentInfoDatabase;Trusted_Connection=True")) 
        { 
            string sqlquery = 
                @"SELECT StatusDescr
                FROM StudStatus";
            IDbCommand command = new SqlCommand(); 
            command.Connection = connection; 
            connection.Open(); 
            command.CommandText = sqlquery; 
            IDataReader reader = command.ExecuteReader(); 
            bool notEndOfResult; 
            notEndOfResult = reader.Read(); 
            while (notEndOfResult) 
            { 
                string s = reader.GetString(0); 
                StudStatusChoices.Add(s); 
                notEndOfResult = reader.Read(); 
            } 
        }
    }
}