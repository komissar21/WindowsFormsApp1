using System;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        XMLGeneration XMLTables;
        public DataSet FormData;
        public Form1()
        {
            InitializeComponent();
            XMLTables = new XMLGeneration();
            if (!(File.Exists("check.xml")))
            {
                XMLTables.generate();
                XMLTables.write();
            }
            
            FormData = XMLTables.read();
            dataGridView1.DataSource = FormData.Tables["Чеки"];
            
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void addCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
