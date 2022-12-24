using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("SERVER=AXEL\\MSSQLSERVER01;DATABASE=Biblioteca;Integrated security=true");

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            login lg = new login();
            if (e.Alt && e.KeyCode == Keys.P)
            {
                lg.Show();
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("SELECT * FROM Añadirir WHERE Titulo = @Titulo", cn);
            comando.Parameters.AddWithValue("@Titulo", textBox1.Text);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtAutor.Text = registro["Autor"].ToString();
                txtFecha.Text = registro["Fecha"].ToString();
                txtGenero.Text = registro["Genero"].ToString();
                txtSeccion.Text = registro["Seccion"].ToString();
                txtTitulo.Text = registro["Titulo"].ToString();
            }
            else
            {
                MessageBox.Show("EL libro no se encuentra en la biblioteca");
            }
            cn.Close();


        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            login lg = new login();
            if (e.Alt && e.KeyCode == Keys.P)
            {
                lg.Show();
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)

        {
            login lg = new login();
            if (e.Alt && e.KeyCode == Keys.P)
            {
                lg.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}