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
using System.Windows.Forms.DataVisualization.Charting;


namespace test
{
    public partial class Form1 : Form
    {
        readonly SalesPerson employee = new SalesPerson();
        readonly Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();
            eAddCar1.addBut += new EventHandler(addVehicle);
            eAddCar1.refreshBut += new EventHandler(Refresh);
            ePotentialSale1.backbut += new EventHandler(Back);
            ePotentialSale1.sellbut += new EventHandler(Esell);
            eSoldVehicles1.backbut += new EventHandler(Back);
            adminDelete1.backbut += new EventHandler(Back);
            adminDelete1.deletebut += new EventHandler(DeleteVehicle);
            cPotentialSale1.backbut += new EventHandler(cBack);
            cViewCar1.addbut += new EventHandler(addPotent);
            cViewCar1.filterbut += new EventHandler(FilterSearch);
            cPotentialSale1.removebut += new EventHandler(removePotent);
            cPreviousSales1.backbut += new EventHandler(cBack);
            colorChart1.backbut += new EventHandler(cBack);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerPanel.Visible = false;
            employeePanel.Visible = false;
            eAddCar1.Visible = false;
            employee_top_panel.Visible = false;
            pictureBox1.Visible = true;
            ePotentialSale1.Visible = false;
            eSoldVehicles1.Visible = false;
            adminDelete1.Visible = false;
            CTopPanel.Visible = false;
            cViewCar1.Visible = false;
            cPotentialSale1.Visible = false;
            cPreviousSales1.Visible = false;
            colorChart1.Visible = false;
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            employeePanel.Visible = true;
            customerPanel.Visible = false;
            pictureBox1.Visible = false;
            employee_top_panel.Visible = true;
            eAddCar1.Visible = false;
            employee_top_panel.Visible = false;
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            employeePanel.Visible = false;
            customerPanel.Visible = true;
            pictureBox1.Visible = false;
            eAddCar1.Visible = false;
            employee_top_panel.Visible = false;
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            line.DrawLine(p, 0, 94, 1089, 94);
            line.Dispose();
               
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            line.DrawLine(p, 30, 50, 665, 50);
            line.Dispose();

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = false;
            employeePanel.Visible = false;
            eAddCar1.Visible = false;
            employee_top_panel.Visible = false;
            pictureBox1.Visible = true;
            ePotentialSale1.Visible = false;
            eSoldVehicles1.Visible = false;
            adminDelete1.Visible = false;
            CTopPanel.Visible = false;
            cViewCar1.Visible = false;
            cPotentialSale1.Visible = false;
            cPreviousSales1.Visible = false;
            SignedInLabel.Text = "";
        }

        private void csignUpButton_Click(object sender, EventArgs e)
        {
            CustomerSignUpForm cusForm = new CustomerSignUpForm();
            cusForm.StartPosition = FormStartPosition.CenterScreen;
            cusForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = false;
            employeePanel.Visible = false;
            eAddCar1.Visible = false;
            employee_top_panel.Visible = false;
            pictureBox1.Visible = true;
            ePotentialSale1.Visible = false;
            eSoldVehicles1.Visible = false;
            adminDelete1.Visible = false;
            CTopPanel.Visible = false;
            cViewCar1.Visible = false;
            cPotentialSale1.Visible = false;
            cPreviousSales1.Visible = false;
            SignedInLabel.Text = "";
        }

        private void csignInButton_Click(object sender, EventArgs e)
        {
            string username = CusernameTextBox.Text;
            string password = cPasswordTextBox.Text;
            string fName = "";
            string lName = "";
            string id = "";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand("select customerFN, customerLN, customerid from customer where customerUsername = '" + username + "' and customerPassword = '" + password + "'");
            cmd.Connection = con;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (loginSuccessful)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fName = reader["customerFN"].ToString();
                    lName = reader["customerLN"].ToString();
                    id = reader["customerid"].ToString();
                }
                customer.FirstName = fName;
                customer.LastName = lName;
                customer.CustomerID = id;
                MessageBox.Show("Success!");
                customerPanel.Visible = false;
                employeePanel.Visible = false;
                pictureBox1.Visible = false;
                CTopPanel.Visible = true;
                cViewCar1.Visible = true;
                
                Cviewvheicles();

                cViewCar1.fillVehicleidComboBox();
                cViewCar1.fillColorComboBox();
                cViewCar1.fillLotComboBox();
                cViewCar1.fillMakeComboBox();
                SignedInLabel.Text = "Customer: " + customer.FirstName + " " + customer.LastName;

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            con.Close();
            CusernameTextBox.Clear();
            cPasswordTextBox.Clear();
        }

        private void signinButton_MouseClick(object sender, MouseEventArgs e)
        {
            string username = EusernameTextBox.Text;
            string password = EPasswordTextBox.Text;
            string fName = "";
            string lName = "";
            string id = "";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand("select salespersonFN, salespersonLN, salespersonid from salesperson where salespersonUsername = '" + username + "' and salespersonPassword = '" + password +"'");
            cmd.Connection = con;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (loginSuccessful)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fName = reader["salespersonFN"].ToString();
                    lName = reader["salespersonLN"].ToString();
                    id = reader["salespersonid"].ToString();
                }
                employee.FirstName = fName;
                employee.LastName = lName;
                employee.EmployeeID = id;
                MessageBox.Show("Success!");
                customerPanel.Visible = false;
                employeePanel.Visible = false;
                pictureBox1.Visible = false;
                eAddCar1.Visible = true;
                employee_top_panel.Visible = true;

                // Populate Combo Boxes
                eAddCar1.fillMakeComboBox();
                eAddCar1.fillColorComboBox();
                eAddCar1.fillLotComboBox();
                SignedInLabel.Text = "Employee: " + employee.FirstName + " " + employee.LastName;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            con.Close();
            EusernameTextBox.Clear();
            EPasswordTextBox.Clear();
        }

        private void addLot_Click(object sender, EventArgs e)
        {
            addCarLotForm lotForm = new addCarLotForm();
            lotForm.StartPosition = FormStartPosition.CenterScreen;
            lotForm.Show();
        }

        private void employeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EsignUpButton_MouseClick(object sender, MouseEventArgs e)
        {
            EmployeeSignUpForm eForm = new EmployeeSignUpForm();
            eForm.StartPosition = FormStartPosition.CenterScreen;
            eForm.Show();
        }

        private void addVehicle(object sender, EventArgs e)
        {
                
            string makeid = eAddCar1.getmakeCombo().GetItemText(eAddCar1.getmakeCombo().SelectedValue);
            string modelid = eAddCar1.getmodelCombo().GetItemText(eAddCar1.getmodelCombo().SelectedValue);
            string color = eAddCar1.getcolorCombo().GetItemText(eAddCar1.getcolorCombo().SelectedItem);
            string year = eAddCar1.getyearCombo().GetItemText(eAddCar1.getyearCombo().SelectedItem);
            string price = eAddCar1.getPriceBox().Text;
            string mileage = eAddCar1.getMileageBox().Text;
            string lot = eAddCar1.getLotCombo().GetItemText(eAddCar1.getLotCombo().SelectedValue);

            if (makeid == "" || modelid == "" || color == "" || year == "" || price == "" || mileage == "")
            {
                MessageBox.Show("Please fill in all information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                con.Open();
                string query = "INSERT INTO vehicle values(" + makeid + "," + modelid + "," + year + ",'" + color + "'," + mileage + "," + price + "," + lot + ", 'T')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Vehicle Added");
                cmd.Dispose();
                con.Close();
            }
            eAddCar1.getmakeCombo().SelectedIndex = -1;
            eAddCar1.getmodelCombo().ResetText();
            eAddCar1.getcolorCombo().SelectedIndex = -1;
            eAddCar1.getyearCombo().SelectedIndex = -1;
            eAddCar1.getPriceBox().Clear();
            eAddCar1.getMileageBox().Clear();
        }

        private void viewVehicle(object sender, EventArgs e)
        {
            string query = "select make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from vehicle INNER JOIN make ON vehicle.make = make.makeid INNER JOIN  model on vehicle.model = modelid INNER JOIN lot on vehicle.lotid = lot.lotid where forsale = 'T'";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            eAddCar1.getGridView().DataSource = dt;
        }

        private void CViewPreviousSales()
        {
            string query = "select make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName, salesperson.salespersonFN, salesperson.salespersonLN from soldvehicles INNER JOIN vehicle on soldvehicles.vehicleid = vehicle.vehicleid INNER JOIN make ON vehicle.make = make.makeid INNER JOIN  model on vehicle.model = modelid INNER JOIN lot on vehicle.lotid = lot.lotid INNER JOIN customer on soldvehicles.customerid = customer.customerid INNER JOIN salesperson on soldvehicles.salespersonid = salesperson.salespersonid where soldvehicles.customerid = " + customer.CustomerID;
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cPreviousSales1.getGridView().DataSource = dt;
            con.Close();
        }

        private void viewPotentialSales()
        {
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string query = "select potentialsales.potentialsalesid,customer.customerFN, customer.customerLN, make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from potentialsales INNER JOIN customer on potentialsales.customerid = customer.customerid INNER JOIN vehicle on potentialsales.vehicleid = vehicle.vehicleid INNER JOIN make on vehicle.make = make.makeid INNER JOIN model on vehicle.model = model.modelid INNER JOIN lot on vehicle.lotid = lot.lotid where vehicle.forsale = 'T'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ePotentialSale1.getGridView().DataSource = dt;
        }
        private void cviewPotentialSales()
        {
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string query = "select potentialsales.potentialsalesid, make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from potentialsales INNER JOIN vehicle on potentialsales.vehicleid = vehicle.vehicleid INNER JOIN make on vehicle.make = make.makeid INNER JOIN model on vehicle.model = model.modelid INNER JOIN lot on vehicle.lotid = lot.lotid where potentialsales.customerid =" + customer.CustomerID;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cPotentialSale1.getGridView().DataSource = dt;
        }

        private void Cviewvheicles()
        {
            string query = "select vehicle.vehicleid, make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from vehicle INNER JOIN make ON vehicle.make = make.makeid INNER JOIN  model on vehicle.model = modelid INNER JOIN lot on vehicle.lotid = lot.lotid where forsale = 'T'";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cViewCar1.getGridView().DataSource = dt;
        }

        private void viewSoldVehicles()
        {
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string query = "select salesperson.salespersonFN, salesperson.salespersonLN, customer.customerFN, customer.customerLN, make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from soldvehicles INNER JOIN salesperson on soldvehicles.salespersonid = salesperson.salespersonid INNER JOIN customer on soldvehicles.customerid = customer.customerid INNER JOIN vehicle on soldvehicles.vehicleid = vehicle.vehicleid INNER JOIN make ON vehicle.make = make.makeid INNER JOIN  model on vehicle.model = modelid INNER JOIN lot on vehicle.lotid = lot.lotid";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            eSoldVehicles1.getGridView().DataSource = dt;
        }

        private void viewDeleteVTable()
        {
            string query = "select vehicle.vehicleid, make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from vehicle INNER JOIN make ON vehicle.make = make.makeid INNER JOIN  model on vehicle.model = modelid INNER JOIN lot on vehicle.lotid = lot.lotid";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminDelete1.getGridView().DataSource = dt;
        }

        private void newMMCButton_Click(object sender, EventArgs e)
        {
            NewMakeModelColorForm mmc = new NewMakeModelColorForm();
            mmc.Show();
        }

        private void Refresh(object sender, EventArgs e)
        {
            // Populate Combo Boxes
            eAddCar1.fillMakeComboBox();
            eAddCar1.fillColorComboBox();
            eAddCar1.fillLotComboBox();

            viewVehicle(sender, e);
        }

        private void epotentialSalesButton_Click(object sender, EventArgs e)
        {
            adminDelete1.Visible = false;
            eSoldVehicles1.Visible = false;
            ePotentialSale1.Visible = true;
            viewPotentialSales();
            ePotentialSale1.fillPotentialSaleComboBox();
        }

        private void Back(object sender, EventArgs e)
        {
            eSoldVehicles1.Visible = false;
            ePotentialSale1.Visible = false;
            adminDelete1.Visible = false;
        }

        private void cBack(object sender, EventArgs e)
        {
            cPotentialSale1.Visible = false;
            cPreviousSales1.Visible = false;
            colorChart1.Visible = false;
        }

        private void Esell(object sender, EventArgs e)
        {
            string salesid = ePotentialSale1.GetComboBox().GetItemText(ePotentialSale1.GetComboBox().SelectedItem);

            if (salesid == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                string emplid = employee.EmployeeID;
                string vid = "";
                string query = "select vehicleid from potentialsales where potentialsalesid = " + salesid;

                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vid = reader["vehicleid"].ToString();
                }
                con.Close();

                string custQuery = "SELECT customerid from potentialsales where potentialsalesid = " + salesid;
                con.Open();
                cmd.Dispose();
                cmd = new SqlCommand(custQuery, con);
                string custid = "";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    custid = reader["customerid"].ToString();
                }
                con.Close();
                cmd.Dispose();

                con.Open();
                string query1 = "INSERT INTO soldvehicles values(" + custid + "," + vid + "," + emplid + ")";
                cmd = new SqlCommand(query1, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query1, con);
                da.InsertCommand.ExecuteNonQuery();
                da.Dispose();
                MessageBox.Show("Vehicle Sold");
                cmd.Dispose();
                con.Close();

                con.Open();
                string queryDelete = "delete from potentialsales where potentialsalesid = " + salesid;
                cmd = new SqlCommand(queryDelete, con);
                da.InsertCommand = new SqlCommand(queryDelete, con);
                da.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                con.Open();
                string queryVehicle = "update vehicle set forsale = 'F' where vehicleid = " + vid;
                cmd = new SqlCommand(queryVehicle, con);
                da.InsertCommand = new SqlCommand(queryVehicle, con);
                da.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                viewPotentialSales();
            }
        }

        private void esoldvehicles_Click(object sender, EventArgs e)
        {
            ePotentialSale1.Visible = false;
            eSoldVehicles1.Visible = true;
            adminDelete1.Visible = false;
            viewSoldVehicles();
        }

        private void vehicleDeleteButton_Click(object sender, EventArgs e)
        {
            adminDelete1.Visible = true;
            ePotentialSale1.Visible = false;
            eSoldVehicles1.Visible = false;
            viewDeleteVTable();
            adminDelete1.filldeleteVComboBox();
        }

        private void DeleteVehicle(object sender, EventArgs e)
        {
            string vehicleid = adminDelete1.GetComboBox().GetItemText(adminDelete1.GetComboBox().SelectedItem);
            if(vehicleid == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
               
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                con.Open();
                string queryDelete = "delete from vehicle where vehicleid = " + vehicleid + "; update vehicle set forsale = 'F' where vehicleid = " + vehicleid;
                SqlCommand cmd = new SqlCommand(queryDelete, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(queryDelete, con);
                da.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Vehicle Deleted");
            }
        }

        private void Csignoutbutton_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = false;
            employeePanel.Visible = false;
            eAddCar1.Visible = false;
            employee_top_panel.Visible = false;
            pictureBox1.Visible = true;
            ePotentialSale1.Visible = false;
            eSoldVehicles1.Visible = false;
            adminDelete1.Visible = false;
            CTopPanel.Visible = false;
            cViewCar1.Visible = false;
            cPotentialSale1.Visible = false;
            cPreviousSales1.Visible = false;
            SignedInLabel.Text = "";
        }

        private void addPotent(object sender, EventArgs e)
        {
            string vehicleid = cViewCar1.GetComboBox().GetItemText(cViewCar1.GetComboBox().SelectedItem);
            if(vehicleid == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                string query = "insert into potentialsales values(" + customer.CustomerID + "," + vehicleid + ")";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Vehicle Added to Potential Sales List");
                cViewCar1.GetComboBox().SelectedIndex = -1;
            }
        }

        private void removePotent(object sender, EventArgs e)
        {
            string vehicleid = cPotentialSale1.GetComboBox().GetItemText(cPotentialSale1.GetComboBox().SelectedItem);
            if(vehicleid == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                string query = "delete from potentialsales where potentialsalesid = " + vehicleid;
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Vehicle removed from Potential Sales List");
                cPotentialSale1.GetComboBox().SelectedIndex = -1;
                cviewPotentialSales();
            }
        }

        private void cViewPotentialSalesbutton_Click(object sender, EventArgs e)
        {
            cPotentialSale1.Visible = true;
            cPreviousSales1.Visible = false;
            colorChart1.Visible = false;
            cviewPotentialSales();
            cPotentialSale1.fillremovePotentComboBox(customer.CustomerID);
        }

        private void CEditProfileButton_Click(object sender, EventArgs e)
        {
            CEditProfile form = new CEditProfile();
            form.Show();
            form.setCustomerID(customer.CustomerID);
            customer.LastName = form.updateName();
            SignedInLabel.Text = "Customer: " + customer.FirstName + " " + customer.LastName;
        }

        private void CViewBoughtCarbutton_Click(object sender, EventArgs e)
        {
            cPreviousSales1.Visible = true;
            cPotentialSale1.Visible = false;
            colorChart1.Visible = false;
            CViewPreviousSales();
            
            string total = "$";
            string query = "select SUM (vehicle.price) from soldvehicles INNER JOIN vehicle on soldvehicles.vehicleid = vehicle.vehicleid INNER JOIN customer on soldvehicles.customerid = customer.customerid where soldvehicles.customerid = " + customer.CustomerID;

            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                total += reader[""].ToString();
            }
            con.Close();
            cmd.Dispose();

            cPreviousSales1.getTotalMoneyLabel().Text = total;
        }

        private void FilterSearch(object sender, EventArgs e)
        {
            string color = cViewCar1.getcolorCombo().GetItemText(cViewCar1.getcolorCombo().SelectedItem);
            string make = cViewCar1.getmakeCombo().GetItemText(cViewCar1.getmakeCombo().SelectedItem);
            string model = cViewCar1.getmodelCombo().GetItemText(cViewCar1.getmodelCombo().SelectedItem);
            string year = cViewCar1.getyearCombo().GetItemText(cViewCar1.getyearCombo().SelectedItem);
            string lot = cViewCar1.getLotCombo().GetItemText(cViewCar1.getLotCombo().SelectedItem);
            string minPrice = cViewCar1.getMinPriceBox().Text;
            string maxPrice = cViewCar1.getMaxPriceBox().Text;
            string minMileage = cViewCar1.getMinMileageBox().Text;
            string maxMileage = cViewCar1.getMaxMileageBox().Text;

            string query = "select vehicle.vehicleid, make.make, model.model, vehicle.year, vehicle.color, vehicle.mileage, vehicle.price, lot.streetName from vehicle INNER JOIN make ON vehicle.make = make.makeid INNER JOIN  model on vehicle.model = modelid INNER JOIN lot on vehicle.lotid = lot.lotid where forsale = 'T'";
            
            if(color != "")
            {
                string tempQuery = " and vehicle.color = '" + color + "'";
                query += tempQuery;
            }
            if(make != "")
            {
                string tempQuery = " and make.make = '" + make + "'";
                query += tempQuery;
            }
            if (model != "")
            {
                string tempQuery = " and model.model = '" + model + "'";
                query += tempQuery;
            }
            if (year != "")
            {
                string tempQuery = " and vehicle.year = '" + year + "'";
                query += tempQuery;
            }
            if (lot != "")
            {
                string tempQuery = " and lot.streetName = '" + lot + "'";
                query += tempQuery;
            }

            if (minPrice != "")
            {
                string tempQuery = " and vehicle.price >= '" + minPrice + "'";
                query += tempQuery;
            }

            if (maxPrice != "")
            {
                string tempQuery = " and vehicle.price <= '" + maxPrice + "'";
                query += tempQuery;
            }

            if (minMileage != "")
            {
                string tempQuery = " and vehicle.mileage >= '" + minMileage + "'";
                query += tempQuery;
            }

            if (maxMileage != "")
            {
                string tempQuery = " and vehicle.mileage <= '" + maxMileage + "'";
                query += tempQuery;
            }
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cViewCar1.getGridView().DataSource = dt;
            con.Close();
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            cPreviousSales1.Visible = true;
            cPotentialSale1.Visible = false;
            colorChart1.Visible = true;
            ViewColorChart();
        }

        private void ViewColorChart()
        {
            Chart chart = colorChart1.getChart();
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select COUNT(vehicleid) as y, color from vehicle where forsale = 'T' group by color";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds);
            chart.DataSource = ds.Tables[0];
            chart.Series[0].XValueMember = "color";
            chart.Series[0].YValueMembers = "y";
            chart.DataBind();
            con.Close();
        }
    }
}