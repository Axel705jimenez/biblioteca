using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace proyecto
{

    public partial class administrador : Form
    {

        public administrador()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("SERVER=AXEL\\MSSQLSERVER01;DATABASE=Biblioteca;Integrated security=true");

        private void administrador_Load(object sender, EventArgs e)
        {
            gpAñadir.Visible = false;
            gpVer.Visible = false;
            gBRegostrarPre.Visible = false;
         }
        private void button2_Click(object sender, EventArgs e)
        {
            gpAñadir.Visible = true;
        }

        private void btnAÑadirlibro_Click(object sender, EventArgs e)
        {

            if (txtNombreCompletoautor.Text == "" || cmbSeccionNumero.Text == ""|| cmbSeccionLetra.Text == ""||txtTituloLibro.Text == ""||cmbGenero.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser llenados");
            }
            else
            {
                string query = "INSERT INTO Añadirir (idLibro, Autor,Titulo,Fecha,Genero,Seccion) VALUES (@idLibro, @Autor,@Titulo,@Fecha,@Genero,@Seccion)";
                cn.Open();
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.AddWithValue("@idLibro", int.Parse(txtidLibro.Text));
                comando.Parameters.AddWithValue("@Autor", txtNombreCompletoautor.Text);
                comando.Parameters.AddWithValue("@titulo", txtTituloLibro.Text);
                comando.Parameters.AddWithValue("@fecha", mcFecha.SelectionRange.Start.ToShortDateString());
                comando.Parameters.AddWithValue("@genero", cmbGenero.Text);
                comando.Parameters.AddWithValue("@seccion", cmbSeccionLetra.Text + cmbSeccionNumero.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("INSERTADO");
                cn.Close();
                txtNombreCompletoautor.Text = "";
                cmbSeccionNumero.Text = "";
                cmbSeccionLetra.Text = "";
                txtTituloLibro.Text = "";
                cmbGenero.Text = "";
            }
        }
         
        private void btnSalir_Click(object sender, EventArgs e)
        {
            gpAñadir.Visible = false;
            txtNombreCompletoautor.Text = "";
            cmbSeccionNumero.Text = "";
            cmbSeccionLetra.Text = "";
            txtTituloLibro.Text = "";
            cmbGenero.Text = "";
            txtidLibro.Text = "";
        }     
        private void button1_Click_1(object sender, EventArgs e)
        {
            gpVer.Visible = false;
            cn.Close();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Text = "LIBROS";
                SqlCommand comando = new SqlCommand("select * from Añadirir", cn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView2.DataSource = tabla;
                gpVer.Visible = true;
                gpVer.Location = new Point(0, 0);
                gpVer.Size = new Size(1300, 628);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            gpAñadir.Visible = true;
            gpAñadir.Location = new Point(0, 0);
            gpAñadir.Size = new Size(1300, 628);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Prestamoro (idPrestamo,Nombre,Direccion,FechaPrestamo,Telefono,LibroPrestado) VALUES (@idPrestamo, @Nombre,@Direccion,@FechaPrestamo,@Telefono, @LibroPrestamo)";
            cn.Open();
            SqlCommand comando = new SqlCommand(query, cn);
            comando.Parameters.AddWithValue("@idPrestamo", int.Parse(txtidPreestamo.Text));
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text + " " + txtApellidos.Text);
            comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            comando.Parameters.AddWithValue("@FechaPrestamo", label3.Text);
            comando.Parameters.AddWithValue("@LibroPrestamo", txtPrestado.Text);

            comando.ExecuteNonQuery();
            MessageBox.Show("INSERTADO");
            cn.Close();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtidPreestamo.Clear();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            gBRegostrarPre.Visible = false;
        }
        private void btnRegistrarPre_Click_2(object sender, EventArgs e)
        {
            gBRegostrarPre.Visible = true;
            gBRegostrarPre.Location = new Point(0, 0);
            gBRegostrarPre.Size = new Size(1300, 628);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
        private void txtidLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }
        private void btnRegistrarPre_Click_3(object sender, EventArgs e)
        {
            gBRegostrarPre.Visible = true;
            gBRegostrarPre.Location = new Point(0, 0);
            label3.Text = DateTime.Now.ToShortDateString();
            gBRegostrarPre.Size = new Size(1300, 628);
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            label8.Text = "PRESTAMO";
            SqlCommand comando = new SqlCommand("select * from Prestamoro", cn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView2.DataSource = tabla;
            gpVer.Visible = true;
            gpVer.Location = new Point(0, 0);
            gpVer.Size = new Size(1300, 628);
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            gBRegostrarPre.Visible = false;
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtidPreestamo.Clear();
        }
        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtidPrestamo_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void gBRegostrarPre_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            if (label8.Text == "PRESTAMO")
            {
                int idPrestamo = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                string query = "DELETE FROM Prestamoro WHERE idPrestamo = " + idPrestamo.ToString();
                cn.Open();
                SqlCommand comando = new SqlCommand(query, cn);
                comando.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Se ha eliminado con exito");
            }
            if (label8.Text == "LIBROS")
            {
                int idLibro = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                string query1 = "DELETE FROM Añadirir WHERE idLibro = " + idLibro.ToString(); ;
                cn.Open();
                SqlCommand comando = new SqlCommand(query1, cn);
                comando.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Se ha eliminado con exito");
            }
            //}
            //catch (Exception)
            //{




        }

        private void txtidLibro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidLibro_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void gpAñadir_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSeccionLetra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSeccionLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbSeccionNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = e.KeyChar;
            if (tecla != 8)
            {
                if (tecla < 48 | tecla > 57) 
                {
                    e.Handled = true;
                }
            }
        }

        private void gpVer_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSeccionNumero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidLibro_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtidLibro_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtidPreestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidPreestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
