using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SahlaTranportLogistics
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Backup Files (*.back)|*.bak";
            saveFileDialog1.ShowDialog();
            txtbackpath.Text = saveFileDialog1.FileName;

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            My_Classes.DB_General obj = new My_Classes.DB_General();
            obj.general_queray("backup database SahalTLDB to disk= '" + txtbackpath.Text + "'");
            MessageBox.Show("Back up Done Successfully");

        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("Restore Files (*bak)|*bak");
            openFileDialog1.ShowDialog();
            txtRestor.Text = openFileDialog1.FileName;
        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            My_Classes.DB_General obj = new My_Classes.DB_General();
            obj.general_queray("use master;restore database SahalTLDB from disk= '" + txtbackpath.Text + "'");
            MessageBox.Show("Restore  Done Successfully");
        }
    }
}

namespace My_Classes
{
    class DB_General
    {
        internal void general_queray()
        {
            throw new NotImplementedException();
        }

        internal void general_queray(string v)
        {
           // throw new NotImplementedException("backup database SahalTLDB to disk='" +  + "'");
        }
    }
}