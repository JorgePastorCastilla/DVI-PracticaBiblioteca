using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02_BibliotecaWinformUI
{
    public partial class BookDetailsFormDialog : Form
    {
        Book _selectedBook;
        private string connectionString =
            "Server=localhost;Port=3306;Database=biblioteca;" +
            "Uid=lector;Pwd=seCret_16;";

        public BookDetailsFormDialog(Book selectedBook)
        {
            InitializeComponent();
            _selectedBook = selectedBook;
            // TODO: Connect to database,
            // get details of book and show them in form

            List<Book> books = new List<Book>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT ID_LLIB, LLIBRES.TITOL, LLIBRES.DESCRIP_LLIB, AUTORS.NOM_AUT," +
                $" LLIBRES.FK_DEPARTAMENT FROM LLIBRES JOIN LLI_AUT ON LLIBRES.ID_LLIB = LLI_AUT.FK_IDLLIB" +
                $" JOIN AUTORS ON LLI_AUT.FK_IDAUT = AUTORS.ID_AUT" +
                $" WHERE ID_LLIB = { selectedBook.ID_LLIB }";
            books = connection.Query<Book>(sql).ToList();
            Book book = books.FirstOrDefault();
            titolLabel.Text = book.TITOL;
            descripcioLabel.Text = book.DESCRIP_LLIB;
            autorLabel.Text = book.NOM_AUTOR;
            departamentLabel.Text = book.FK_DEPARTAMENT;
        }
    }
}
