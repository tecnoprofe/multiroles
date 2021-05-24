using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace multiroles
{
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        private void Rol_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            SQLiteConnection conexion = new SQLiteConnection("Data Source=bd.db");
            conexion.Open();

            
            SQLiteDataAdapter tablasql = new SQLiteDataAdapter("select * from rol", conexion);
            tabla.Reset();
            tablasql.Fill(tabla);
            dataGridView1.DataSource = tabla;

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source=bd.db");
            conexion.Open();

            string sql = "insert into rol(nombre, descripcion) values('"+textBox2.Text+"','"+textBox3.Text +"')";
            
            SQLiteCommand query = new SQLiteCommand(sql,conexion);
            query.ExecuteNonQuery();            
            conexion.Close();

            DataTable tabla = new DataTable();            
            conexion.Open();

            SQLiteDataAdapter tablasql = new SQLiteDataAdapter("select * from rol", conexion);
            tabla.Reset();
            tablasql.Fill(tabla);
            dataGridView1.DataSource = tabla;

            conexion.Close();
        }
    }
}
