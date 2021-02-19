using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3.Custom
{
    public class Personas : System.Web.UI.Page
    {

        public static List<Personas> personas = new List<Personas>();

        private string nombre;
        private string apellidos;
        private int edad;
        private string mail;



        public Personas(string nombre, string apellidos, int edad, string mail)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Mail = mail;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Mail { get => mail; set => mail = value; }


        public static void LoadPersonas()
        {
            SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["personDB"].ConnectionString
                );
            SqlCommand cmd = new SqlCommand("SELECT [nombre] "
                  + ",[apellidos] "
                  + ",[edad] "
                  + ",[direccion] "
                + "FROM[Personas].[dbo].[Personas]", connection);

            connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            personas = new List<Personas>();
            while (read.Read())
            {
                personas.Add(new Personas(
                    read.GetString(0),
                    read.GetString(1),
                    int.Parse(read.GetInt32(2).ToString()),
                    read.GetString(3)
                ));
            }
            connection.Close();
        }
    }
}