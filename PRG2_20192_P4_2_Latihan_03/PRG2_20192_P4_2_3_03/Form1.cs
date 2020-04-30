using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20192_P4_2_3_03
{
    public partial class frm1 : Form
    {
        String jenisKelamin, kurikulumPil, matkulPil;

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (cbJK.Checked)
            {
                matkulPil += "Jaringan Komputer, ";
            }
            if (cbSO.Checked)
            {
                matkulPil += "Sistem Operasi, ";
            }
            if (cbMP.Checked)
            {
                matkulPil += "Manajemen Produksi, ";
            }
            if (cbSM.Checked)
            {
                matkulPil += "Sistem Mutu Astra, ";
            }
            if (cbMtk.Checked)
            {
                matkulPil += "Matematika, ";
            }
            if (cbP1.Checked)
            {
                matkulPil += "Pemrograman 1, ";
            }
            if (cbP2.Checked)
            {
                matkulPil += "Pemrograman 2, ";
            }
            if (cbP3.Checked)
            {
                matkulPil += "Pemrograman 3, ";
            }
            if (cbP4.Checked)
            {
                matkulPil += "Pemrograman 4, ";
            }
            if (cbP5.Checked)
            {
                matkulPil += "Pemrograman 5, ";
            }
            if (cbP6.Checked)
            {
                matkulPil += "Pemrograman 6, ";
            }
            if (cbP7.Checked)
            {
                matkulPil += "Pemrograman 7, ";
            }

            MessageBox.Show(
                "NIM : " + txtNIM.Text +
                "\nNama : " + txtNama.Text +
                "\nJenis Kelamin : " + jenisKelamin +
                "\nAlamat : " + txtAlamat.Text +
                "\nProgram Studi : " + comboBox1.Text +
                "\nSemester : " + txtSemester.Text +
                "\nTahun Akademik : " + txtTahun.Text +
                "\nKurikulum Pilihan : " + kurikulumPil +
                "\nMata Kuliah Pilihan : " + matkulPil,
                "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            Clear();
            this.Height = 300;

        }

        public frm1()
        {
            
            InitializeComponent();
            initialize();

            this.Height = 300;
        }
        public void initialize()
        {
            cbJK.Enabled = false;
            cbMP.Enabled = false;
            cbMtk.Enabled = false;
            cbP1.Enabled = false;
            cbP2.Enabled = false;
            cbP3.Enabled = false;
            cbP4.Enabled = false;
            cbP5.Enabled = false;
            cbP6.Enabled = false;
            cbP7.Enabled = false;
            cbSM.Enabled = false;
            cbSO.Enabled = false;
            kurikulumPil = "";
            jenisKelamin = "";

        }

        private void rbK2006_CheckedChanged(object sender, EventArgs e)
        {
            cbJK.Enabled = true;
            cbMP.Enabled = false;
            cbMtk.Enabled = true;
            cbP1.Enabled = true;
            cbP2.Enabled = true;
            cbP3.Enabled = true;
            cbP4.Enabled = true;
            cbP5.Enabled = true;
            cbP6.Enabled = true;
            cbP7.Enabled = true;
            cbSM.Enabled = false;
            cbSO.Enabled = true;
            kurikulumPil = "2006";
        }

        private void rbK2010_CheckedChanged(object sender, EventArgs e)
        {
            cbJK.Enabled = true;
            cbMP.Enabled = true;
            cbMtk.Enabled = false;
            cbP1.Enabled = true;
            cbP2.Enabled = true;
            cbP3.Enabled = true;
            cbP4.Enabled = true;
            cbP5.Enabled = true;
            cbP6.Enabled = true;
            cbP7.Enabled = true;
            cbSM.Enabled = false;
            cbSO.Enabled = true;
            kurikulumPil = "2010";
        }

        private void rbK2016_CheckedChanged(object sender, EventArgs e)
        {
            cbJK.Enabled = true;
            cbMP.Enabled = false;
            cbMtk.Enabled = false;
            cbP1.Enabled = true;
            cbP2.Enabled = true;
            cbP3.Enabled = true;
            cbP4.Enabled = true;
            cbP5.Enabled = true;
            cbP6.Enabled = true;
            cbP7.Enabled = true;
            cbSM.Enabled = true;
            cbSO.Enabled = true;
            kurikulumPil = "2016";
        }

        

        private void btnPilihMatkul_Click(object sender, EventArgs e)
        {
            if ( txtNIM.Text != "" && txtNama.Text != "" && txtAlamat.Text != "" && txtSemester.Text != "" 
                && txtTahun.Text != "" && comboBox1.Text != "--Pilih Program Studi--"
                && ValidateTahun() == true
                && rbLaki.Checked != false || rbPerempuan.Checked != false)
            {
                if (rbLaki.Checked)
                {
                    jenisKelamin = "Laki-Laki";
                }
                else if (rbPerempuan.Checked)
                {
                    jenisKelamin = "Perempuan";
                }

                this.Height = 625;
            }
            else if ( ValidateTahun() != true)
            {
                MessageBox.Show("Format Tahun nnnn/nnnn !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lengkapi Data !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Clear();
            this.Height = 300;

        }

        public bool ValidateTahun()
        {
            string regexPattern = @"^\d{4}/\d{4}$";

            Regex regex = new Regex(regexPattern);

            if (regex.IsMatch(txtTahun.Text))
                return (true);
            else
                return (false);
        }

        public void Clear()
        {
            txtTahun.Text = "";
            comboBox1.Text = "--Pilih Program Studi--";
            txtAlamat.Text = "";
            txtNama.Text = "";
            txtNIM.Text = "";
            txtTahun.Text = "";
            txtSemester.Text = "";
            rbK2006.Checked = false;
            rbK2010.Checked = false;
            rbK2016.Checked = false;
            cbJK.Checked = false;
            cbSO.Checked = false;
            cbSM.Checked = false;
            cbMtk.Checked = false;
            cbMP.Checked = false;
            cbP1.Checked = false;
            cbP2.Checked = false;
            cbP3.Checked = false;
            cbP4.Checked = false;
            cbP5.Checked = false;
            cbP6.Checked = false;
            cbP7.Checked = false;
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
        }
    }
}
