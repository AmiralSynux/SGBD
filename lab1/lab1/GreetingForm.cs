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
        private const string ConnectionString = "Server=DESKTOP-D82IMOD\\SQLEXPRESS;Database=OnePiece;Integrated Security=true;";
        private readonly DataSet _ds = new DataSet();
        private readonly SqlDataAdapter _parentAdapter = new SqlDataAdapter();
        private readonly SqlDataAdapter _childAdapter = new SqlDataAdapter();
        private readonly BindingSource _bsParent = new BindingSource();
        private readonly BindingSource _bsChild = new BindingSource();
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    _parentAdapter.SelectCommand = new SqlCommand("select * from Echipaj;", connection);
                    _childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Marinar", connection);
                    _parentAdapter.Fill(_ds, "Echipaj");
                    _childAdapter.Fill(_ds, "Marinar");
                    _bsParent.DataSource = _ds.Tables["Echipaj"];
                    gridEchipaj.DataSource = _bsParent;
                    DataColumn pk = _ds.Tables["Echipaj"].Columns["cod_echipaj"];
                    DataColumn fk = _ds.Tables["Marinar"].Columns["cod_echipaj"];
                    DataRelation relation = new DataRelation("FK_Echipaj_Marinar", pk, fk);
                    _ds.Relations.Add(relation);
                    _bsChild.DataSource = _bsParent;
                    _bsChild.DataMember = "FK_Echipaj_Marinar";
                    gridMarinar.DataSource = _bsChild;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void deletePirat_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = gridMarinar.SelectedRows;
                if (rows.Count == 0)
                {
                    MessageBox.Show("Please select a row!");
                    return;
                }

                var id =(int) rows[0].Cells["cod_marinar"].Value;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Marinar WHERE cod_marinar=@cod;",
                        connection);
                    
                    deleteCommand.Parameters.AddWithValue("@cod", id);
                    int deleteCount = deleteCommand.ExecuteNonQuery();
                    MessageBox.Show(("Numarul marinarilor stersi este: " + deleteCount));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateMarinar_Click(object sender, EventArgs e)
        {
            var rows = gridMarinar.SelectedRows;
            if (cod_marinarText.Text.Equals(""))
            {
                MessageBox.Show("Please select a row or fill in the data!");
                return;
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand updateCommand = new SqlCommand("UPDATE Marinar SET functie=@functie, alias=@alias,cod_individ=@cod_individ,cod_echipaj=@cod_echipaj WHERE" +
                                                          " cod_marinar=@cod_marinar;", connection);
                updateCommand.Parameters.AddWithValue("@functie", functieText.Text);
                updateCommand.Parameters.AddWithValue("@alias", aliasText.Text);
                updateCommand.Parameters.AddWithValue("@cod_individ", int.Parse(cod_individText.Text));
                updateCommand.Parameters.AddWithValue("@cod_echipaj", int.Parse(cod_echipajText.Text));
                updateCommand.Parameters.AddWithValue("@cod_marinar", int.Parse(cod_marinarText.Text));
                int updateCount = updateCommand.ExecuteNonQuery();
                MessageBox.Show("Numarul marinarilor actualizati: " + updateCount);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            _ds.Tables["Marinar"].Clear();
            _ds.Tables["Echipaj"].Clear();
            cod_marinarText.Text = "";
            functieText.Text = "";
            aliasText.Text = "";
            cod_individText.Text = "";
            cod_echipajText.Text = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                _parentAdapter.SelectCommand = new SqlCommand("select * from Echipaj;", connection);
                // childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Jocuri", connection);
                _childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Marinar", connection);
                _parentAdapter.Fill(_ds, "Echipaj");
                _childAdapter.Fill(_ds, "Marinar");
            }
        }

        private void gridMarinar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = gridMarinar.SelectedRows;
            if (rows.Count == 0 || rows[0].Cells.Count == 0 || rows[0].Cells["cod_individ"].Value.ToString().Equals(""))
            {
                return;
            }

            cod_marinarText.Text = rows[0].Cells["cod_marinar"].Value.ToString();
            functieText.Text = rows[0].Cells["functie"].Value.ToString();
            aliasText.Text = rows[0].Cells["alias"].Value.ToString();
            cod_individText.Text = rows[0].Cells["cod_individ"].Value.ToString();
            cod_echipajText.Text = rows[0].Cells["cod_echipaj"].Value.ToString();
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            var rows = gridEchipaj.SelectedRows;
            if (rows.Count == 0 || rows[0].Cells.Count == 0 || rows[0].Cells["cod_echipaj"].Value.ToString().Equals(""))
            {
                MessageBox.Show("Alegeti un echipaj!");
                return;
            }

            int echipaj = int.Parse(rows[0].Cells["cod_echipaj"].Value.ToString());
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand("insert into Marinar (functie,alias,cod_individ,cod_echipaj,cod_marinar)values(@functie, @alias,@cod_individ,@cod_echipaj,@cod_marinar);", connection);
                insertCommand.Parameters.AddWithValue("@functie", functieText.Text);
                insertCommand.Parameters.AddWithValue("@alias", aliasText.Text);
                insertCommand.Parameters.AddWithValue("@cod_individ", int.Parse(cod_individText.Text));
                insertCommand.Parameters.AddWithValue("@cod_echipaj", echipaj);
                insertCommand.Parameters.AddWithValue("@cod_marinar", int.Parse(cod_marinarText.Text));
                int inserted = insertCommand.ExecuteNonQuery();
                MessageBox.Show("Numarul marinarilor inserati: " + inserted);
            }
        }
    }
}