using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{

    
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
        "Data Source=LAPTOP-2QET043V\\DIMAS; Initial Catalog=DBAkademikADO; Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void ConnectDatabase()
        {
            try
            { if (conn.State == System.Data.ConnectionState.Closed)
                {
                     conn.Open();
                }
                MessageBox.Show("Koneksi berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
