using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MarcinS.Projekt
{
    public class Connection
    {
        string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";
        public void connect()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        

        public void addTripF(string departure, int destinationID, string price, string length, string date, string hotel)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand($"insert into Trips(Deparature, DestinationID, Price, Length, Date, Hotel)\r\nvalues('{departure}','{destinationID}',{Convert.ToDouble(price)},'{length}','{date}','{hotel}');", cnn1);
            cmd.ExecuteNonQuery();
            cnn1.Close();
            MessageBox.Show("Pomyślnie dodano wycieczkę");
        }

        public int getIdByName(string name)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand getIdByName = new SqlCommand($"exec getIdByName {name}", cnn1);
            return Convert.ToInt32(getIdByName.ExecuteScalar());
        }

        public void fillComboBox(ComboBox box)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand($"select * from Destinations", cnn1);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                box.Items.Add(rd["Name"]);
            }
            cnn1.Close();
        }

        public DataTable fillDataTable()
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand("exec fillDataTable", cnn1);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            return dt;
        }

        public void deleteTrip(string ID)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand($"delete from Trips where TripID={ID}", cnn1);
            cmd.ExecuteNonQuery();
            cnn1.Close();
        }

        public DataTable fillDestinationTable()
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand("exec fillDestinationTable", cnn1);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            return dt;
        }

        public void addDestination(string name, string country, string population)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand($"insert into Destinations(Name, Country, Population)\r\nvalues('{name}','{country}','{population}');", cnn1);
            cmd.ExecuteNonQuery();
            cnn1.Close();
            MessageBox.Show("Pomyślnie dodano kierunek");
        }
    }
}
