using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
namespace mvcajax.Models

{

    public class ClienteRepository
    {

        public List<Cliente> BuscarTodos()
        {

            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            //Tu consulta en SQL
            string query = "SELECT * from cliente";
            List<Cliente> lista = new List<Cliente>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                Cliente cliente = new Cliente(reader.GetString("Dni"), reader.GetString("Nombre"), reader.GetString("Apellido"));
             
                lista.Add(cliente);
            }

            return lista;
        }

            public void Insertar(Cliente c)
{
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            // Tu inserccion de nuevos clientes
            string query = "insert into cliente values ('" + c.Dni + "',' " + c.Nombre + "','" + c.Apellidos + "')";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();



        }

        public void Borrar(string dni)
        {


            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            // Tu borrado de clientes por numero de DNI
            
            string query = "delete from cliente where dni= '" + dni + "'";
            Console.WriteLine(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();



        }







    }



}


