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
    internal class Connection
    {
        public void connect()
        {
            string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
        }
        public void print()
        {
            string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";
            MainWindow win = new MainWindow();
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand("select * from Trips", cnn1);
            cmd.ExecuteNonQuery();
            cnn1.Close();
        }
    }
}
