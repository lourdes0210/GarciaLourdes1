using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.CodeDom.Compiler;
using System.Collections;
using System.Security.Cryptography;

namespace GarciaLourdes1
{
    public class ConexionBD
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;

        string cadena;

        public ConexionBD()
        {
            cadena = "\"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= BD_GarciaLj";


        }




    }
}
