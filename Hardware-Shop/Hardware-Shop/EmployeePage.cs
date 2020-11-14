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

namespace Hardware_Shop
{
    public partial class EmployeePage : Form
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;

        public static employee Employee = new employee();

        public EmployeePage()
        {
            InitializeComponent();

            lblUpdateInfo.Visible = false;
            lblDeleteInformation.Visible = false;

            grpbxAddUpdateEmployee.Visible = false;

            //display the group4.EmployeeTable on the productTable datagridview
            try
            {
                da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.EmployeeTable", con);

                da.Fill(ds);

                employeeTable.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            grpbxAddUpdateEmployee.Visible = true;

            btnEnter.Visible = false;
            btnUpdate.Visible = false;
            lblUpdateInfo.Visible = false;
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnEnterDelete.Visible = false;
            lblUpdateInfo.Visible = false;
            lblUpdateInfo.Visible = false;

            enableFields();
        }

        //create a method to refresh the productTable datagridview
        public void showEmployeeTable()
        {
            try
            {
                da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.EmployeeTable", con);

                ds.Clear();

                da.Fill(ds);

                employeeTable.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertCommand = new SqlCommand("INSERT INTO group4bfa202330.EmployeeTable Values(@firstName, @lastName, @Phone, @Address, @Address2, @City, @State, @ZipCode)", con);
                da.InsertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = txtNewFirstName.Text;
                da.InsertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = txtNewLastName.Text;
                da.InsertCommand.Parameters.Add("@Phone", SqlDbType.VarChar).Value = txtNewPhone.Text;
                da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtNewAddress1.Text;
                da.InsertCommand.Parameters.Add("@Address2", SqlDbType.VarChar).Value = txtNewAddress2.Text;
                da.InsertCommand.Parameters.Add("@City", SqlDbType.VarChar).Value = txtNewCity.Text;
                da.InsertCommand.Parameters.Add("@State", SqlDbType.VarChar).Value = txtNewState.Text;
                da.InsertCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = txtNewZip.Text;

                con.Open();

                da.InsertCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clearTextFields();

            showEmployeeTable();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            grpbxAddUpdateEmployee.Visible = true;

            btnUpdate.Visible = false;
            btnAdd.Visible = false;
            btnEnter.Visible = true;
            lblUpdateInfo.Text = "Highlight the employee row you wish to update from Employee Table View, click enter, update the desired fields, " +
                                 "then click the update button to update the information.";
            lblUpdateInfo.Visible = true;
            btnDelete.Visible = false;
            btnEnterDelete.Visible = false;
            lblDeleteInformation.Visible = false;

            disableFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //open connection
                con.Open();

                //create an update query
                string sqlQuery = "Update group4bfa202330.EmployeeTable SET firstName = @firstName, lastName = @lastName, Phone = @Phone, Address = @Address, Address2 = @Address2, City = @City, State = @State, ZipCode = @ZipCode WHERE EmployeeID = '" + Employee.employeeID + "' ";

                //pass the update query
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                //add the data
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar);
                cmd.Parameters["@firstName"].Value = txtNewFirstName.Text;
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar);
                cmd.Parameters["@lastName"].Value = txtNewLastName.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar);
                cmd.Parameters["@Phone"].Value = txtNewPhone.Text;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd.Parameters["@Address"].Value = txtNewAddress1.Text;
                cmd.Parameters.Add("@Address2", SqlDbType.VarChar);
                cmd.Parameters["@Address2"].Value = txtNewAddress2.Text;
                cmd.Parameters.Add("@City", SqlDbType.VarChar);
                cmd.Parameters["@City"].Value = txtNewCity.Text;
                cmd.Parameters.Add("@State", SqlDbType.VarChar);
                cmd.Parameters["@State"].Value = txtNewState.Text;
                cmd.Parameters.Add("@ZipCode", SqlDbType.VarChar);
                cmd.Parameters["@ZipCode"].Value = txtNewZip.Text;

                cmd.ExecuteNonQuery();

                //close the connection
                con.Close();

                //display a messagebox to show the product information was updated successfully
                MessageBox.Show("The employee information was updated successfully!!!");

                //call method to set field to blank
                clearTextFields();

                //call showEmployeeTable to refresh the employeeTable datagridview
                showEmployeeTable();

                btnUpdate.Visible = false;

                disableFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            getEmployeeRowIndex();

            btnUpdate.Visible = true;

            enableFields();
        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            Hardware_Shop hs = new Hardware_Shop();
            hs.Show();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            grpbxAddUpdateEmployee.Visible = true;

            btnAdd.Visible = false;
            btnEnter.Visible = false;
            btnUpdate.Visible = false;
            btnEnterDelete.Visible = true;
            btnDelete.Visible = false;

            lblUpdateInfo.Visible = false;
            lblDeleteInformation.Visible = true;

            disableFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wan to delete employee?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string sqlQry = "DELETE FROM group4bfa202330.EmployeeTable WHERE EmployeeID = '" + Employee.employeeID + "'";
                    cmd = new SqlCommand(sqlQry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("The employee was deleted successfully");

                    showEmployeeTable();

                    clearTextFields();

                    btnDelete.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            clearTextFields();
        }

        private void btnEnterDelete_Click(object sender, EventArgs e)
        {
            getEmployeeRowIndex();

            btnDelete.Visible = true;
        }

        //create a public class name product
        public class employee
        {
            //create objects for the product class
            public string employeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string phone { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
        }

        public void getEmployeeRowIndex()
        {
            //assign the index of employeeTable datagridview
            Employee.employeeID = employeeTable[0, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.FirstName = employeeTable[1, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.LastName = employeeTable[2, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.phone = employeeTable[3, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.address1 = employeeTable[4, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.address2 = employeeTable[5, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.city = employeeTable[6, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.state = employeeTable[7, employeeTable.CurrentRow.Index].Value.ToString();
            Employee.zip = employeeTable[8, employeeTable.CurrentRow.Index].Value.ToString();

            txtNewFirstName.Text = Employee.FirstName;
            txtNewLastName.Text = Employee.LastName;
            txtNewPhone.Text = Employee.phone;
            txtNewAddress1.Text = Employee.address1;
            txtNewAddress2.Text = Employee.address2;
            txtNewCity.Text = Employee.city;
            txtNewState.Text = Employee.state;
            txtNewZip.Text = Employee.zip;
        }

        public void disableFields()
        {
            txtNewFirstName.Enabled = false;
            txtNewLastName.Enabled = false;
            txtNewPhone.Enabled = false;
            txtNewAddress1.Enabled = false;
            txtNewAddress2.Enabled = false;
            txtNewCity.Enabled = false;
            txtNewState.Enabled = false;
            txtNewZip.Enabled = false;
        }

        public void enableFields()
        {
            txtNewFirstName.Enabled = true;
            txtNewLastName.Enabled = true;
            txtNewPhone.Enabled = true;
            txtNewAddress1.Enabled = true;
            txtNewAddress2.Enabled = true;
            txtNewCity.Enabled = true;
            txtNewState.Enabled = true;
            txtNewZip.Enabled = true;
        }

        public void clearTextFields()
        {
            txtNewFirstName.Text = "";
            txtNewLastName.Text = "";
            txtNewPhone.Text = "";
            txtNewAddress1.Text = "";
            txtNewAddress2.Text = "";
            txtNewCity.Text = "";
            txtNewState.Text = "";
            txtNewZip.Text = "";
        }
    }
}
