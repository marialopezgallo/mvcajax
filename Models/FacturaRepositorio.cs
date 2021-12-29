using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
namespace mvcajax.Models
{

    public class FacturaRepositorio
    {

        public List<Factura> BuscarDatos()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            //Tu consulta en SQL
            string query = "SELECT * from facturas";
            List<Factura> lista = new List<Factura>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                Factura factura = new Factura(reader.GetInt32("Numero"), reader.GetString("Concepto"), reader.GetDouble("importe"));

                lista.Add(factura);


            }
            return lista;
        }






        public void Insertar(Factura f)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            // Tu inserccion de nuevas facturas
            string query = "insert into facturas values ('" + f.Numero + "',' " + f.Concepto + "','" + f.Importe + "')";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();

        }

        public void Borrar(int numero)
        {


            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            // Tu borrado de facturas por numero de factrqa

            string query = "delete from facturas where numero= " + numero;
            Console.WriteLine(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();
        }


        public Factura BuscarUno(int numero)
        {
           
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            //Tu consulta en SQL
            string query = "SELECT * from facturas where numero="+numero;
            Console.WriteLine(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            reader.Read();
            Factura factura = new Factura(reader.GetInt32("Numero"), reader.GetString("Concepto"), reader.GetDouble("importe"));
            return factura;


        }

        public void Salvar(Factura factura)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;";
            //Tu consulta en SQL
            string query = " UPDATE facturas set concepto='"+factura.Concepto+"',importe="+factura.Importe+" where numero="+factura.Numero;
            Console.WriteLine(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            commandDatabase.ExecuteNonQuery();
           
        }
    }



}
