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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source= DESKTOP-O1FFAIK; Initial Catalog= Learning_App ; Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernametextBox.Text == "" && PasstextBox.Text == "")
                {
                    MessageBox.Show("Please enter User name and password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from StudentRecord where Student_Name='" + UsernametextBox.Text + "' and Student_Password='" + PasstextBox.Text + "'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet dset = new DataSet();
                    adapt.Fill(dset);
                    int count = dset.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("You have successfully login");
                        LearningSource ls = new LearningSource();
                        ls.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("PLz check your username and password");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginclosebtn_Click(object sender, EventArgs e)
        {
            CoverPg cp1 = new CoverPg();
            cp1.Show();
            this.Hide();
        }
    }
}
