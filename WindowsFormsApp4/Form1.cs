using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using myDataSetTableAdapters;

//MySql.Data.MySqlClient.MySqlConnection conn;
//string myConnectionString;

//myConnectionString = "server=127.0.0.1;uid=root;" +
//    "pwd=12345;database=test;";

//try
//{
//  conn = new MySql.Data.MySqlClient.MySqlConnection();
//    conn.ConnectionString = myConnectionString;
//  conn.Open();
//}
//catch (MySql.Data.MySqlClient.MySqlException ex)


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        // Initialize the form.

            public Form1()
        {
            InitializeComponent();
            //this.dataGridView1.Dock = DockStyle.Fill;
            //this.Controls.Add(this.dataGridView1);
            //this.Load += new EventHandler(Form1_Load);
            //this.Text = "DataGridView virtual-mode demo (row-level commit scope)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=127.0.0.1;datasource = localhost;port = 3306; username =  merch;password=ialsql1851;database=studenttest;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                //myDataAdapter.SelectCommand = new MySqlCommand("describe students;", myConn);
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM students;", myConn);

                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                //DataSet ds = new DataSet();
                
                DataTable table = new DataTable();
                myDataAdapter.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dataGridView1.DataSource = bSource;
                //dataGridView1.DataMember = table;

                myDataAdapter.Update(table);
                
                ////////////////////////////////


                //using (SqlConnection sqlConn = new SqlConnection("yourConnectionString"))
                //{
                //using (SqlCommand cmd = new SqlCommand())
                //{
                //SqlCommand cmd = new SqlCommand
                //cmd.CommandText = "SELECT first_name, last_name FROM students";
                //cmd.Parameters.Add("@first_name", SqlDbType.Text).Value = "Andy",myConn);
                //  cmd.Parameters.  ("SELECT first_name, last_name Where first_name='Andy';");
                //cmd.Connection = myConn;

                MySqlCommand mSqlCmd = myConn.CreateCommand();
                    mSqlCmd.CommandText = "select * from students WHERE first_Name = 'Andy'";
                    MySqlDataReader mSqlReader;

                //myConn.Open();
                DataSet ds = new DataSet();
                mSqlReader = mSqlCmd.ExecuteReader();
                    DataTable dtCustomers = new DataTable();
                    dtCustomers.Load(mSqlReader);

                    // foreach (DataRow row in dtCustomers.Rows)
                    // textBox1.Text = dtCustomers.Rows[1]["last_name"];       Console.WriteLine(row["last_name"].ToString())
                foreach (DataRow row in dtCustomers.Rows)
                {
                    //Console.WriteLine(row["customerName"].ToString());
                    textBox1.Text = row["last_name"].ToString();
                }

               
                //Console.ReadKey();

                //using (SqlDataReader reader = cmd.ExecuteReader())
                //{
                //  if (reader.Read())
                //{
                //  textBox1.Text = (string)reader.GetValue[0];
                //textBox2.Text = (string)reader[1];
                //}
                //}
                //}
                //}
                //myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //MessageBox.Show("Connected");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=127.0.0.1;datasource = localhost;port = 3306; username =  merch;password=ialsql1851;database=studenttest;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                //myDataAdapter.SelectCommand = new MySqlCommand("describe students;", myConn);
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM students;", myConn);

                //MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                DataTable table = new DataTable();
                myDataAdapter.Fill(table);

                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = table;

                //MySqlConnection myConn = new MySqlConnection(connectionString);
                //da = new MySqlDataAdapter();
                //da.SelectCommand = new MySqlCommand("SELECT * FROM students;", myConn);
                myDataAdapter = new MySqlDataAdapter("SELECT * FROM students;", myConn);
                DataSet ds = new DataSet();
                //myDataAdapter.Fill(ds, dataGridView1.Name(GET) ;

                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                //da.Fill(ds, sTable); da.Update(ds, sTable)
                //da.Update(ds, sTable);
                //myDataAdapter.Update
                

                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
