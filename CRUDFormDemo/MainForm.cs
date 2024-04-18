using System.Data;
using System.Data.SqlClient;

namespace CRUDFormDemo;

public partial class MainForm : Form
{
    private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=CRUD_Demo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
    public int studentID;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        GetStudentData();
    }

    private void GetStudentData()
    {
        if (conn.State != ConnectionState.Open)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM students", conn);
                DataTable dt = new DataTable();

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                studentRecordGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }

    private void insertButton_Click(object sender, EventArgs e)
    {
        if (isValid())
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO students (name, fatherName, rollNumber, address, phoneNumber) VALUES (@name, @fatherName, @rollNumber, @address, @phoneNumber)", conn);

                cmd.Parameters.AddWithValue("@name", studentNameText.Text);
                cmd.Parameters.AddWithValue("@fatherName", fatherNameText.Text);
                cmd.Parameters.AddWithValue("@rollNumber", rollNumberText.Text);
                cmd.Parameters.AddWithValue("@address", addressText.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberText.Text);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inputting data to the table: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Data added successfully to the table.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentData();
                ClearFields();
            }
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (studentID > 0 && isValid())
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE students SET name = @name, fatherName = @fatherName, rollNumber = @rollNumber, address = @address, phoneNumber = @phoneNumber WHERE studentID = @ID", conn);
                cmd.Parameters.AddWithValue("@name", studentNameText.Text);
                cmd.Parameters.AddWithValue("@fatherName", fatherNameText.Text);
                cmd.Parameters.AddWithValue("@rollNumber", rollNumberText.Text);
                cmd.Parameters.AddWithValue("@address", addressText.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberText.Text);
                cmd.Parameters.AddWithValue("@ID", this.studentID);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating data to the table: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

                MessageBox.Show("Data updated successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentData();
                ClearFields();
            }
        }
        else
        {
            MessageBox.Show("Please select a data to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        var confirmMessage = MessageBox.Show("Are you sure?", "Information Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (studentID > 0 && isValid() && confirmMessage == DialogResult.Yes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE studentID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", studentID);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data to the table: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

                MessageBox.Show("Data deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentData();
                ClearFields();
            }
        }
        else
        {
            MessageBox.Show("Please select a data to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    private bool isValid()
    {
        if (studentNameText.Text == "" || fatherNameText.Text == "" || rollNumberText.Text == "" || addressText.Text == "" || phoneNumberText.Text == "'")
        {
            MessageBox.Show("Please fill the empty fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void ClearFields()
    {
        studentID = 0;
        studentNameText.Clear();
        fatherNameText.Clear();
        rollNumberText.Clear();
        addressText.Clear();
        phoneNumberText.Clear();

        studentNameText.Focus();
    }

    private void studentRecordGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        studentID = Convert.ToInt32(studentRecordGridView.SelectedRows[0].Cells[0].Value.ToString());
        studentNameText.Text = studentRecordGridView.SelectedRows[0].Cells[1].Value.ToString();
        fatherNameText.Text = studentRecordGridView.SelectedRows[0].Cells[2].Value.ToString();
        rollNumberText.Text = studentRecordGridView.SelectedRows[0].Cells[3].Value.ToString();
        addressText.Text = studentRecordGridView.SelectedRows[0].Cells[4].Value.ToString();
        phoneNumberText.Text = studentRecordGridView.SelectedRows[0].Cells[5].Value.ToString();
    }
}