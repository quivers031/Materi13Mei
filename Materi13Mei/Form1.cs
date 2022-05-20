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
            string cekJenisKelamin = "";
            if (rb_LakiLaki.Checked == true)
            {
                cekJenisKelamin = "Laki - Laki";
            }
            else if (rb_Perempuan.Checked == true)  
            {
                cekJenisKelamin = "Perempuan";
            }
            sqlQuery = "INSERT INTO pelajar VALUES('"+tb_IDPelajar.Text+"', '"+tb_NamaPelajar.Text+"', '"+cb_Jurusan.Text+"', '"+dtp_TanggalLahir.Value.ToString("yyyyMMdd")+"', '"+tb_NoInduk.Text+"', '"+tb_NoTelepon.Text+"', '"+cekJenisKelamin+"', '"+tb_Alamat.Text+"', '"+cb_Angkatan.Text+"', '"+tb_EMail.Text+"', 0)";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data pelajar baru bernama " + tb_NamaPelajar.Text + " berhasil diinput.");

            
        }
    }
}
