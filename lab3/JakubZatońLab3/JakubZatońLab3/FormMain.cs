using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/// <summary>
/// Zadanie: Utworzeni aplikacji bazodanowej, 5 tabel, TEMAT Dowolny(Różny od poprzednich), sensowny widok, Trzeba użyć -View -join -insert,delete, Where
/// może być timer, progres
/// Trzeba umieścić skrypt z danymi
/// </summary>
namespace JakubZatońLab3
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Poląćzenie z bazą danych
        /// </summary>
        SqlConnection connection;
        public FormMain()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-5177O24\JAKUBSQL; database=JakubZatonLab3; Trusted_Connection=yes");
        }
        /// <summary>
        /// Wyświetlanie widoku "GradesView"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonViewGrades_Click(object sender, EventArgs e)
        {
            showData("GradesView");
        }
        /// <summary>
        /// Dodawanie nowego kursu do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            //Utworzenie kwerendy 
            SqlCommand command = new SqlCommand(@"INSERT INTO Courses(Name, Teacher)
                                                  VALUES (@Name, @Teacher)", connection);
            //Dodanie parametrów kwerendy    
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxCourse.Text;
            command.Parameters.Add("@Teacher", SqlDbType.NVarChar).Value = textBoxTeacherName.Text;
            //Wykonanie kwerendy
            connection.Open();
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Wyświetlanie dowolonych danych z tabel
        /// </summary>
        /// <param name="table"></param>
        private void showData(string tableName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
            DataTable table = new DataTable();
            //Wypełnienie tablicy danymi z bazy
            dataAdapter.Fill(table);
            //Wyświetlenie bazy danych
            dataGridViewData.DataSource = table;
        }

        private void buttonViewCourses_Click(object sender, EventArgs e)
        {
            showData("Courses");
        }
    }
}
