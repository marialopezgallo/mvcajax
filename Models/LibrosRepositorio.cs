using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
namespace mvcajax.Models

{
    public class LibrosRepositorio

    {    
            

        public List<Libro> BuscarDatos()

            {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            //Tu consulta en SQL
            string query = "SELECT * from libros";
            List<Libro> lista = new List<Libro>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                Libro libro = new Libro(reader.GetInt32("Numero"),reader.GetString("Titulo"), reader.GetString("Autor"));

                lista.Add(libro);


            }
            return lista;
        }


            public void Insertar(Libro l)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            // Tu inserccion de nuevos libros
            string query = "insert into Libros (numero,titulo,autor) values ('" + l.Numero + "','" + l.Titulo + "',' " + l.Autor + "')";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();

        }
    
            public void Borrar(int numero)
        {


            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            // Tu borrado de facturas por titulo de libro

            string query = "delete from libros where numero= " + numero;
            Console.WriteLine(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();
        }
            public Libro BuscarUno(int numero)
        {
           
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            //Tu consulta en SQL
            string query = "SELECT * from libros where numero="+numero;
            Console.WriteLine(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            reader.Read();
            Libro libro = new Libro(reader.GetInt32("Numero"),reader.GetString("Titulo"), reader.GetString("Autor"));
            return libro;


    }
}

}