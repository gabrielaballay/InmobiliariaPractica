using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class RepositorioPropietario : RepositorioBase, IRepositorio<Propietario>
    {
        public RepositorioPropietario(IConfiguration configuration) : base(configuration)
        {

        }
        public int Alta(Propietario p)
        {
            int res = -1;
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                string sql = $"INSERT INTO Propietarios (Nombre, Apellido, Mail, Telefono, Clave)"+
                    $"VALUES ('{p.Nombre}', '{p.Apellido}', '{p.Mail}', '{p.Telefono}', '{p.Clave}')";
                using(SqlCommand command=new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    command.CommandText = "SELECT SCOPE_IDENTITY()";
                    var id = command.ExecuteScalar();
                    p.IdPropietario = Convert.ToInt32(id);
                    connection.Close();
                }
            }
            return res;
        }

        public int Baja(int id)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"DELETE FROM Propietarios WHERE idPropietario={id}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }

        public int Modificacion(Propietario t)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"UPDATE Propietario SET Nombre='{t.Nombre}',Apellido='{t.Apellido}',Mail='{t.Mail}'," +
                    $"Telefono='{t.Telefono}',Clave='{t.Clave}' WHERE idPropietario={t.IdPropietario}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }

        public Propietario ObtenerPorId(int id)
        {
            Propietario p = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT idPropietario,Nombre,Apellido,Mail,Telefono,Clave FROM Propietarios WHERE" +
                    $"idPropietario=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        p = new Propietario
                        {
                            IdPropietario = reader.GetInt32(0),
                            Nombre = reader[nameof(p.Nombre)].ToString(),
                            Apellido = reader[nameof(p.Apellido)].ToString(),
                            Mail = reader[nameof(p.Mail)].ToString(),
                            Telefono = reader[nameof(p.Telefono)].ToString(),
                            Clave = reader[nameof(p.Clave)].ToString(),
                        };
                    }

                    connection.Close();
                }
            }
            return p;

        }

        public IList<Propietario> ObtenerTodos()
        {
            IList<Propietario> res = new List<Propietario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT idPropietario,Nombre,Apellido,Mail,Telefono,Clave FROM Propietarios;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Propietario p = new Propietario
                        {
                            IdPropietario = reader.GetInt32(0),
                            Nombre = reader[nameof(p.Nombre)].ToString(),
                            Apellido = reader[nameof(p.Apellido)].ToString(),
                            Mail = reader[nameof(p.Mail)].ToString(),
                            Telefono = reader[nameof(p.Telefono)].ToString(),
                            Clave = reader[nameof(p.Clave)].ToString(),
                        };
                        res.Add(p);
                    }

                    connection.Close();
                }
            }
            return res;
            
        }
    }
}
