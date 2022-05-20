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
    public partial class FormViewPemain : Form
    {
        public FormViewPemain()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        int PosisiSekarang = 0;
       
        
        private void FormViewPemain_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM dt_type";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            IsiDataPemain(0);
            
        }

        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            tBox_ID.Text = dtTypePemain.Rows[Posisi][0].ToString();
            tBox_Nama.Text = dtTypePemain.Rows[Posisi][1].ToString();
            tBox_Goal.Text = dtTypePemain.Rows[Posisi][2].ToString();
            tBox_GoalPenalty.Text = dtTypePemain.Rows[Posisi][3].ToString();
            tBox_KartuKuning.Text = dtTypePemain.Rows[Posisi][4].ToString();
            tBox_KartuMerah.Text = dtTypePemain.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
            
        }
    }
}
