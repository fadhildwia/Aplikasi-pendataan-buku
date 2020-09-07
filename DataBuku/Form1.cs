using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Book> lists;

        public Form1()
        {
            InitializeComponent();
            lists = new List<Book>();
        }

        private void Save()
        {
            Book book = new Book();
            int year;
            Int32.TryParse(txtYear.Text, out year);

            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Year = year;
            book.Publisher = txtPublisher.Text;

            lists.Add(book);
        }

        private void DataShow()
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["Column1", row].Value = dataGridView1.RowCount - 1;
            dataGridView1["Column2", row].Value = txtTitle.Text;
            dataGridView1["Column3", row].Value = txtAuthor.Text;
            dataGridView1["Column4", row].Value = txtYear.Text;
            dataGridView1["Column5", row].Value = txtPublisher.Text;
            dataGridView1.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            DataShow();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtYear.Text = "";
            txtPublisher.Text = "";

            txtTitle.Focus();

            dataGridView1.Rows.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult keluar = MessageBox.Show("Yakin ingin keluar?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (keluar == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtYear.Text = "";
                txtPublisher.Text = "";

                txtTitle.Focus();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtYear.Text = "";
            txtPublisher.Text = "";

            txtTitle.Focus();
        }
    }
}
