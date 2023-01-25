using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Printing;
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
            SqlCommand cmd = new SqlCommand($"exec [dbo].[insertIntoTrips] @destinationID={destinationID}, @departure='{departure}', @price={Convert.ToDouble(price)}, @length={length}, @date='{date}', @hotel='{hotel}';", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Pomyślnie dodano wycieczkę");
        }
        public int getIdByName(string name)
        {
            cnn.Open();
            SqlDataAdapter da2 = new SqlDataAdapter();
            SqlParameter name1 = new SqlParameter("@name", SqlDbType.VarChar);
            SqlCommand getIdByName = new SqlCommand($"select dbo.GetIdByNameFunction('{@name}')", cnn);
            name1.Value= name;
            int x = Convert.ToInt32(getIdByName.ExecuteScalar());
            cnn.Close();
            return x;
        }
        public void fillComboBox(ComboBox box)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"exec drawTable", cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                box.Items.Add(rd["Name"]);
            }
            cnn.Close();
        }
        public DataTable fillDataTable(string procedure)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"exec {procedure}", cnn);
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
        public void addDestination(string name, string country, string population)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Destinations(Name, Country, Population)\r\nvalues('{name}','{country}','{population}');", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Pomyślnie dodano kierunek");
        }
        public void changeRow(int tripID, int destinationID, string departure, string price, string length, string hotel, string date) {
            cnn.Open();
            SqlCommand cmd = new SqlCommand($"EXEC [dbo].[changeRow] @tripID = {tripID}, @destinationID = {destinationID}, @departure = '{departure}', @price = {price}, @length = {length}, @date = '{date}', @hotel = '{hotel}'", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
