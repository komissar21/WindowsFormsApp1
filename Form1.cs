using System;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        XMLGeneration XMLTables;
        public Form1()
        {
            InitializeComponent();
            XMLTables = new XMLGeneration();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            XMLTables.write();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            XMLTables.generate();  
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            DataSet a = XMLTables.read();
            dataGridView1.DataSource = a.Tables["Чеки"];
        }
    }
}
