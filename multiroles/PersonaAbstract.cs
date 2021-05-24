using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace multiroles
{
    abstract class PersonaAbstract
    {
        SQLiteConnection con;
        SQLiteDataAdapter tablasql;
        protected DataTable tabla;
        protected PersonaAbstract()
        {
            this.con = new SQLiteConnection("Data Source=bd.db");
        }
        public void conexion()
        {
            this.con.Open();            
            
        }
        public void cierre()
        {
            this.con.Close();            
        }
        //visualiza la información en un datagrid
        public DataTable mostrar(string sql)
        {
            this.conexion();
            this.tabla = new DataTable();
            this.tablasql = new SQLiteDataAdapter(sql, this.con );
            this.tabla.Reset();
            this.tablasql.Fill(this.tabla);
            this.cierre();
            return this.tabla;
        }
        public void insertar(string sql)
        {
            this.conexion();            
            SQLiteCommand query = new SQLiteCommand(sql, this.con);
            query.ExecuteNonQuery();
            this.cierre();
        }
    }
}
