using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class Data
    {

        public List<Propietario> obtenerPropietarios()
        {
            List<Propietario> res = new List<Propietario>();
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDInmobiliaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string sql = "SELECT idPropietario,Nombre,Apellido,Mail,Telefono,Clave FROM Propietarios;";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            var reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Propietario p = new Propietario
                {
                    IdPropietario = reader.GetInt32(0),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader[nameof(p.Apellido)].ToString(),
                    Mail = reader[nameof(p.Mail)].ToString(),
                    Telefono = reader[nameof(p.Telefono)].ToString(),
                    Clave = reader[nameof(p.Clave)].ToString()
                };
                res.Add(p);
            }
            conn.Close();
            return res;
        }
    }
}
