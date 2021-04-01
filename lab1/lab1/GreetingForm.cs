using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class GreetingForm : Form
    {
        private string connectionString = "Server=DESKTOP-D82IMOD\\SQLEXPRESS;Database=OnePiece;Integrated Security=true;";
        private DataSet ds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource bsParent = new BindingSource();
        BindingSource bsChild = new BindingSource();
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    parentAdapter.SelectCommand = new SqlCommand("select * from Echipaj;", connection);
                    // childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Jocuri", connection);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Pirati", connection);
                    parentAdapter.Fill(ds, "Echipaj");
                    childAdapter.Fill(ds, "Pirati");
                    bsParent.DataSource = ds.Tables["Echipaj"];
                    gridEchipaj.DataSource = bsParent;
                    // dataGridView1.DataSource = bsParent;
                    DataColumn pk = ds.Tables["Echipaj"].Columns["cod_echipaj"];
                    DataColumn fk = ds.Tables["Pirati"].Columns["cod_echipaj"];
                    // DataColumn pk = ds.Tables["SaliDeJoc"].Columns["id"];
                    // DataColumn fk = ds.Tables["Jocuri"].Columns["cod_sala"];
                    // DataRelation relation = new DataRelation("FK_SaliDeJoc_Jocuri", pk, fk);
                    DataRelation relation = new DataRelation("FK_Echipaj_Pirati", pk, fk);
                    ds.Relations.Add(relation);
                    bsChild.DataSource = bsParent;
                    bsChild.DataMember = "FK_Echipaj_Pirati";
                    gridPirati.DataSource = bsChild;
                    // dataGridView2.DataSource = bsChild;
                    // MessageBox.Show("M-am deschis ;)");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}