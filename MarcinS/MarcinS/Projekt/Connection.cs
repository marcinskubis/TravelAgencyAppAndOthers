using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace MarcinS.Projekt
{
    public class Connection
    {
        static string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";
        static SqlConnection cnn = new SqlConnection(connectionString);
        public void addTripF(string departure, int destinationID, string price, string length, string date, string hotel)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Trips(Deparature, DestinationID, Price, Length, Date, Hotel)\r\nvalues('{departure}','{destinationID}',{Convert.ToDouble(price)},'{length}','{date}','{hotel}');", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Pomyślnie dodano wycieczkę");
        }

        public int getIdByName(string name)
        {
            cnn.Open();
            SqlCommand getIdByName = new SqlCommand($"exec getIdByName {name}", cnn);
            int x = Convert.ToInt32(getIdByName.ExecuteScalar());
            cnn.Close();
            return x;
        }

        public void fillComboBox(ComboBox box)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"select * from Destinations", cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                box.Items.Add(rd["Name"]);
            }
            cnn.Close();
        }

        public DataTable fillDataTable()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("exec fillDataTable", cnn);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            cnn.Close();
            return dt;
        }

        public void deleteTrip(string ID)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"delete from Trips where TripID={ID}", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable fillDestinationTable()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("exec fillDestinationTable", cnn);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void addDestination(string name, string country, string population)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Destinations(Name, Country, Population)\r\nvalues('{name}','{country}','{population}');", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Pomyślnie dodano kierunek");
        }
    }
}
