using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace lab2
{
    public partial class GreetingForm : Form
    {
        private const string ConnectionString = "Server=DESKTOP-D82IMOD\\SQLEXPRESS;Database=OnePiece;Integrated Security=true;";
        private readonly DataSet _ds = new DataSet();
        private readonly SqlDataAdapter _parentAdapter = new SqlDataAdapter();
        private SqlCommandBuilder _builderParent;
        private SqlCommandBuilder _builderChild;
        private readonly SqlDataAdapter _childAdapter = new SqlDataAdapter();
        private readonly BindingSource _bsParent = new BindingSource();
        private readonly BindingSource _bsChild = new BindingSource();
        private string _parent;
        private string _child;
        // private string _child_primarykey;
        private string _parent_primarykey;
        private SqlConnection _connection;
        public GreetingForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            try
            {
                _connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            base.OnClosed(e);
        }

        private void LoadData()
        {
            try
            {
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();
                _parentAdapter.SelectCommand = new SqlCommand("select * from " + _parent, _connection);
                _childAdapter.SelectCommand = new SqlCommand("SELECT * FROM " + _child, _connection);
                _parentAdapter.Fill(_ds, _parent);
                _childAdapter.Fill(_ds, _child);
                _bsParent.DataSource = _ds.Tables[_parent];
                gridEchipaj.DataSource = _bsParent;
                DataColumn pk = _ds.Tables[_parent].Columns[_parent_primarykey];
                DataColumn fk = _ds.Tables[_child].Columns[_parent_primarykey];
                DataRelation relation = new DataRelation("FK_parent_child", pk, fk);
                _ds.Relations.Add(relation);
                _bsChild.DataSource = _bsParent;
                _bsChild.DataMember = "FK_parent_child";
                gridMarinar.DataSource = _bsChild;

                _builderParent = new SqlCommandBuilder(_parentAdapter);
                _builderChild = new SqlCommandBuilder(_childAdapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {
            _child = ConfigurationManager.AppSettings["child"].ToString();
            _parent = ConfigurationManager.AppSettings["parent"].ToString();
            _parent_primarykey = ConfigurationManager.AppSettings["parent_key"].ToString();
            // _child_primarykey = "cod_marinar";
            labelEchipaj.Text = _parent;
            labelPirati.Text = _child;
            LoadData();
        }

        private void deletePirat_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = gridMarinar.SelectedRows;
                if (rows.Count == 0)
                {
                    MessageBox.Show("Alegeti un copil!");
                    return;
                }
                gridMarinar.Rows.Remove(gridMarinar.SelectedRows[0]);
                _builderChild.GetDeleteCommand();
                _childAdapter.Update(_ds, _child);
                MessageBox.Show("Deleted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateMarinar_Click(object sender, EventArgs e)
        {
            try
            {
                _builderChild.GetUpdateCommand();
                _childAdapter.Update(_ds, _child);
                MessageBox.Show("Updated");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            _ds.Tables[_child].Clear();
            _ds.Tables[_parent].Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                _parentAdapter.SelectCommand = new SqlCommand("select * from " + _parent, connection);
                // childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Jocuri", connection);
                _childAdapter.SelectCommand = new SqlCommand("SELECT * FROM " + _child, connection);
                _parentAdapter.Fill(_ds, _parent);
                _childAdapter.Fill(_ds, _child);
            }
        }

        private void gridMarinar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            try
            {
                _builderChild.GetInsertCommand();
                _childAdapter.Update(_ds, _child);
                MessageBox.Show("Added");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}