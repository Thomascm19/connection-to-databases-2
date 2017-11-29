using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClienteData
    {
        public void CrearCliente(Cliente unCliente)
        {
            SqlConnection con = new SqlConnection();
         
            con.ConnectionString = "Data Source=THOMAS-CM-PC\\SQLEXPRESS;Initial Catalog=Web;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "INSERT INTO Clientes (Nombre,CC,Tel) values('"+unCliente.Nombre+"','"+unCliente.CC+"','"+unCliente.Tel+"')";
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
