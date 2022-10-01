using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecondSemOOPproject
{
    public partial class Registration : Form
    {
        string Path = @"Data Source= DESKTOP-O1FFAIK; Initial Catalog= Learning_App ; Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dtable;
        int ID;
        public Registration()
        {
            InitializeComponent();
            con = new SqlConnection(Path);
            Display();
        }
        private void clear()
        {
            NametextBox.Text = "";
            FnametextBox.Text = "";
            PhonetextBox.Text = "";
            PasswordtextBox.Text = "";
            AddresscomboBox.SelectedItem = null;
            malerbtn.Checked = false;
            femalerbtn.Checked = false;
        }
        public void Display()
        {
            try
            {
                dtable = new DataTable();
                con.Open();
                adapt = new SqlDataAdapter("select * from StudentRecord", con);
                adapt.Fill(dtable);
                dataGridView1.DataSource = dtable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchnametextBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from StudentRecord where Student_Name like '%" + searchnametextBox.Text + "%'", con);
            dtable = new DataTable();
            adapt.Fill(dtable);
            dataGridView1.DataSource = dtable;
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            NametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            FnametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PhonetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Female")
            {
                femalerbtn.Checked = true;
                malerbtn.Checked = false;
            }
            else
            {
                femalerbtn.Checked = false;
                malerbtn.Checked = true;
            }
            PasswordtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            AddresscomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if(malerbtn.Checked||femalerbtn.Checked)
            {
                check = true;
            }
            if (NametextBox.Text == "" || FnametextBox.Text == "" || PhonetextBox.Text == "" || PasswordtextBox.Text == "" || AddresscomboBox.Text == ""||check==false)
            {
                MessageBox.Show("Please fill all the required details");
            }
            else
            {
                try
                {
                    string gender;
                    if (femalerbtn.Checked)
                    {

                        gender = "Female";
                    }
                    else
                    {
                        gender = "male";
                    }

                    con.Open();
                    cmd = new SqlCommand("insert into StudentRecord(Student_Name,Student_Fname,Student_Phoneno,Student_Gender,Student_Password,Student_Address)values('" + NametextBox.Text + "','" + FnametextBox.Text + "','" + PhonetextBox.Text + "','" + gender + "','" + PasswordtextBox.Text + "','" + AddresscomboBox.SelectedItem + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your record has been added in the database");
                    clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (femalerbtn.Checked)
                {

                    gender = "Female";
                }
                else
                {
                    gender = "male";
                }
                con.Open();
                cmd = new SqlCommand("update StudentRecord set Student_Name='" + NametextBox.Text + "',Student_Fname='" + FnametextBox.Text + "',Student_Phoneno='" + PhonetextBox.Text + "',Student_Gender='" + gender + "',Student_Password='" + PasswordtextBox.Text + "',Student_Address='" + AddresscomboBox.Text + "' where Sudent_Id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your record has been Updated!");
                Display();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("delete from StudentRecord where Sudent_Id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your record has been Deleted!");
                Display();
                clear();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Learningstartbtn_Click(object sender, EventArgs e)
        {
            startlearning sl = new startlearning();
            sl.Show();
            this.Hide();
           
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            
        }
    }
}
