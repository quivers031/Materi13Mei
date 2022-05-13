using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Materi13Mei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;


        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            sqlQuery = "INSERT INTO pelajar VALUES('IDPelajar', 'NamaPelajar', 'Jurusan', 'TanggalLahir', 'NoInduk', 'NoTelepon', 'JenisKelamin', 'Alamat', 'Angkatan', 'Email', 0)";
            MessageBox.Show(sqlQuery);
        }
    }
}
