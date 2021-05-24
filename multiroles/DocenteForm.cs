using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace multiroles
{
    public partial class DocenteForm : Form
    {
        Docente doc = new Docente();
        public DocenteForm()
        {
            InitializeComponent();
        }

        private void DocenteForm_Load(object sender, EventArgs e)
        {                        
            dataGridView1.DataSource= doc.mostrar("select * from docente");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into docente(nombre, apellidos,sueldo) values('" 
                + textBox2.Text 
                + "','" + textBox3.Text 
                + "','" + textBox4.Text 
                + "')";
            doc.insertar(sql);
            dataGridView1.DataSource = doc.mostrar("select * from docente");
        }
    }
}
