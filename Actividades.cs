using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaLourdes1
{
    public class Actividades
    {

        private OleDbConnection CONEXION = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private string CadenaDeConexion = "\"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD_GarciaLj";

        private string tabla;   


        public string Mes { get; set; }
        public string Cantidad { get; set; }
        public string CategoriaUsuario { get; set; }
    }
}
