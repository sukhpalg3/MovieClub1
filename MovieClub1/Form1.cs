using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieClub1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtRentedCost.ReadOnly = true; 
        }

        /// <summary>
        /// Show Customer Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customer_Click(object sender, EventArgs e)
        {
            BindGridCustomer(); // method calling here
            groupBox1Customer.Visible = true;
            groupBoxMovies.Visible = false;
            groupBoxReturnMovie.Visible = false;
            gbRentMovies.Visible = false;
        }

        // Bind Grid of Customers
        private void BindGridCustomer()
        {
            DataTable dt = GetAllCustomers();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Bind Grid of Movies
        private void BindGridMovies()
        {
            DataTable dt = GetAllMovies();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Get All Customers
        public DataTable GetAllCustomers()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from customer";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        // Get All Movie List
        public DataTable GetAllMovies()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from movies";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            con.Dispose();
            return ds;
        }

        //Show Movie Panel
        private void Movie_Click(object sender, EventArgs e)
        {
            BindGridMovies(); //Method calling - Show Movies
            groupBox1Customer.Visible = false;
            groupBoxMovies.Visible = true;
            groupBoxReturnMovie.Visible = false;
            gbRentMovies.Visible = false;
        }

        //Add new customer Data
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name, address, phone;
                name = txtName.Text.Trim();
                address = txtAddress.Text.Trim();
                phone = txtPhone.Text.Trim();

                if (name.Equals(""))
                {
                    MessageBox.Show("Customer name is required!");
                    txtName.Focus();
                }
                else if (address.Equals(""))
                {
                    MessageBox.Show("Address is required!");
                    txtAddress.Focus();
                }
                else if (phone.Equals(""))
                {
                    MessageBox.Show("Customer phone number is required!");
                    txtPhone.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    string sp = "InsertCustomerData";
                    cmd.CommandText = sp;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@address", address));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));

                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindGridCustomer(); //bind grid after adding new customer
                        MessageBox.Show("Customer Data Saved!","Alert");
                        txtAddress.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Customer Data NOT Saved!","Alert");
                    }
                    cmd.Dispose();
                    con.Dispose();
                }
            }
            catch (Exception exp)
            {
                    MessageBox.Show(exp.Message);
            }
        }

        //update customer data 
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name, address, phone,custID;
                name = txtName.Text.Trim();
                address = txtAddress.Text.Trim();
                phone = txtPhone.Text.Trim();
                custID = tbxCustomerID.Text.Trim();
                if (name.Equals(""))
                {
                    MessageBox.Show("Customer name is required!");
                    txtName.Focus();
                }
                else if (address.Equals(""))
                {
                    MessageBox.Show("Address is required!");
                    txtAddress.Focus();
                }
                else if (phone.Equals(""))
                {
                    MessageBox.Show("Customer phone number is required!");
                    txtPhone.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    string sp = "UpdateCustomerData";
                    cmd.CommandText = sp;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@address", address));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));
                    cmd.Parameters.Add(new SqlParameter("custId", custID));
                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindGridCustomer(); // bind grid customer after updation
                        MessageBox.Show("Customer Data updated!", "Alert");
                        txtAddress.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Customer Data NOT Updated!", "Alert");
                    }
                    cmd.Dispose();
                    con.Dispose();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

       
        //Get Customer Info from custID
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string customerID = tbxCustomerID.Text.Trim();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                string sp = "Select * from customer where custID=@CustID";
                cmd.CommandText = sp;
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@custId", customerID));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader[1].ToString();
                    txtAddress.Text = reader[2].ToString();
                    txtPhone.Text = reader[3].ToString();
                }
                reader.Dispose();
                cmd.Dispose();
                con.Dispose();
            }
            catch (Exception exp)
            {
                    MessageBox.Show(exp.Message);
                }
        }

        //Delete customer
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string customerID = tbxCustomerID.Text;
                if (customerID.Equals(""))
                {
                    MessageBox.Show("Plz enter customer id!");
                    tbxCustomerID.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    string query = "delete customer where custId=@custId";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@custId", customerID));
                    cmd.Connection = con;
                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindGridCustomer(); // bind grid customer after deleting the customer
                        MessageBox.Show("Customer Deleted!", "Alert");
                        tbxCustomerID.Text = "";
                        txtAddress.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("CustomerID does not exists", "Alert");
                    }
                    cmd.Dispose();
                    con.Dispose();

                }
            }
            catch (Exception exp)
            {
                if (exp.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Unable to delete this customer as the customer rented a movie!");
                }
                else
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }


        //Customer Borrow Most Movies - method calling
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CustomersBorrowMostMovies();
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception exp)
            {
                    MessageBox.Show(exp.Message);
            }
        }

        //Customer Borrow Most Movies - implementataion
        public DataTable CustomersBorrowMostMovies()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CustBorrowMostMovies"; 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            con.Dispose();
            return ds;
        }

        //Most Popular Movies- implementation
        public DataTable MostPopularMovies()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostPopularMovies";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            con.Dispose();
            return ds;
        }

        //Most Popular Movies- method calling
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = MostPopularMovies();
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception exp)
            {
                    MessageBox.Show(exp.Message);
            }
        }

        //All Rented Movies - method calling
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = AllRentedMovies();
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //All Rented Movies - implementation
        public DataTable AllRentedMovies()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AllRentedMovies";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            con.Dispose();
            return ds;
        }

        //Get All Rented Movies
        private void rentMovie_Click(object sender, EventArgs e)
        {
            BindRentMovieGrid();
            BindDdlAllMovies();
            groupBox1Customer.Visible = false;
            groupBoxMovies.Visible = false;
            groupBoxReturnMovie.Visible = false;
            gbRentMovies.Visible = true;
            BindDdlCustomer();
            
        }

        //private method to Bind Rented movie 
        private void BindRentMovieGrid()
        {
            DataTable dt = AllRentedMovies();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Bind customer to combo box 
        private void BindDdlCustomer()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            
            string query = "select CustId, concat(name,' - ' ,custid)as name from customer";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select..";
            dt.Rows.InsertAt(row, 0); // add new item at 1st position;

            cblistCustomer.DisplayMember = "Name";
            cblistCustomer.ValueMember = "CustId";
            cblistCustomer.DataSource = dt; // Bind combo box customer in return panel

            cbCust.DisplayMember = "Name";
            cbCust.ValueMember = "CustId";
            cbCust.DataSource = dt; // Bind combo box customer in rent panel
        }

        //Bind combox movies
        private void BindDdlAllMovies()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();

            string query = "select movieId, title from movies";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select..";
            dt.Rows.InsertAt(row, 0); // add new item at 1st position;

            cbMovi.DisplayMember = "title";
            cbMovi.ValueMember = "movieid";
            cbMovi.DataSource = dt; // Bind combo box movie in rent panel

        }
        
        //Exit the Appication here
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Delete the movie
        private void btnDelMOvie_Click(object sender, EventArgs e)
        {
            try
            {
                string MovieID = tbxMovieID.Text;
                if (MovieID.Equals(""))
                {
                    MessageBox.Show("Plz enter movie id!");
                    tbxCustomerID.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    string query = "delete movies where movieid=@movieid";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@movieid", MovieID));
                    cmd.Connection = con;
                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindGridMovies();
                        MessageBox.Show("Movie Deleted!", "Alert");
                        tbxMovieID.Text = "";
                        txtTitle.Text = "";
                        txtYear.Text = "";
                        txtRating.Text = "";
                        txtGenre.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("MovieID does not exists", "Alert");
                    }
                    cmd.Dispose();
                    con.Dispose();

                }
            }
            catch (Exception exp)
            {
                if (exp.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Unable to delete this movie as it is rented by a customer!");
                }
                else
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        //Get movie info via movieID
        private void tbxMovieID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string movieid = tbxMovieID.Text.Trim();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                string sp = "Select * from movies where movieid=@movieid";
                cmd.CommandText = sp;
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@movieid", movieid));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtGenre.Text = reader["genre"].ToString();
                    txtRating.Text = reader["rating"].ToString();
                    txtRentedCost.Text = reader["rentcost"].ToString();
                    txtTitle.Text = reader["title"].ToString();
                    txtYear.Text = reader["year"].ToString();
                    
                }
                reader.Dispose();
                cmd.Dispose();
                con.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Update movie Info
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Title, Rent, Year, Rating, Genre;
                Title = txtTitle.Text.Trim();
                Rent = txtRentedCost.Text.Trim();
                Rating = txtRating.Text.Trim();
                Year = txtYear.Text.Trim();
                Genre = txtGenre.Text.Trim();
                string movieId = tbxMovieID.Text.Trim();
                if (Title.Equals(""))
                {
                    MessageBox.Show("Movie title is required!");
                }
                else if (Year.Equals(""))
                {
                    MessageBox.Show("Movie released year is required!");
                }

                else if (Genre.Equals(""))
                {
                    MessageBox.Show("Movie genre is required!");
                }
                else if (Rent.Equals(""))
                {
                    MessageBox.Show("Movie rent cost is required!");
                }

                else if (Rating.Equals(""))
                {
                    MessageBox.Show("Movie rating is required!");
                }

                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UpdateMovieInfo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@movieid", movieId));
                    cmd.Parameters.Add(new SqlParameter("@title", Title));
                    cmd.Parameters.Add(new SqlParameter("@rent", Rent));
                    cmd.Parameters.Add(new SqlParameter("@genre", Genre));
                    cmd.Parameters.Add(new SqlParameter("@year", Year));
                    cmd.Parameters.Add(new SqlParameter("@rating", Rating));
                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindGridMovies(); // method calling to Bind Grid Movies
                        MessageBox.Show("Movie Info updated!", "Alert");
                        tbxCustomerID.Text = "";
                        txtTitle.Text = "";
                        txtYear.Text = "";
                        txtRating.Text = "";
                        txtGenre.Text = "";
                        txtRentedCost.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Movie Info NOT Updated!", "Alert");
                    }
                    cmd.Dispose();
                    con.Dispose();


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Show Return Movie Panel
        private void returnMovie_Click(object sender, EventArgs e)
        {
            BindDdlCustomer();
            groupBox1Customer.Visible = false;
            groupBoxMovies.Visible = false;
            groupBoxReturnMovie.Visible = true;
            gbRentMovies.Visible = false;
            BindRentMovieGrid(); // show rented movie data grid
        }

        //Get Rented Movie by CustomerID
        private void cblistCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                int CustID = int.Parse(cblistCustomer.SelectedValue.ToString());
                if (CustID > 0)
                {
                    cblistrentmovies.Enabled = true;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    string query = "select rm.MovieID, Title from RentedMovies rm join movies mv on rm.movieid= mv.movieid where rentDate is not null and custid=@custID group by Title, rm.MovieID";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SqlParameter("@custID", CustID));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                       
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "Select..";
                        dt.Rows.InsertAt(row, 0); // add item at INDEX = 0;

                        cblistrentmovies.DisplayMember = "Title";
                        cblistrentmovies.ValueMember = "MovieID";
                        cblistrentmovies.DataSource = dt;
                        da.Dispose();
                        cmd.Dispose();
                        con.Dispose();
                    }
                    else
                    {
                        cblistrentmovies.Enabled = false;
                        // disbale combox list of rented movies 
                    }
                }
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Return the movie implementation
        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int MovieID = int.Parse(cblistrentmovies.SelectedValue.ToString());
                int CustomerId = int.Parse(cblistCustomer.SelectedValue.ToString());

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                string query = "delete from RentedMovies where MovieID=@MovieID and CustID= @CustID;";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@custID", CustomerId));
                cmd.Parameters.Add(new SqlParameter("@MovieID", MovieID));
                bool result = cmd.ExecuteNonQuery() > 0;
                if (result)
                {
                    BindRentMovieGrid(); //method calling to Bind Grid for all rental movies

                    MessageBox.Show("Movie Returned Successfully!","Alert");
                    cblistCustomer.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unable to return this movie!","Alert");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Calculate the Total Rent of a movie
        public int CalculateMovieRentCost(int MovieID)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " select RentCost from movies where MovieID=@MovieID"; // stored procedure
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            int Rent = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                Rent = int.Parse(reader["RentCost"].ToString());
            }
            reader.Close();
            cmd.Dispose();
            con.Dispose();
            return Rent;
        }

        //Rent movie implementation here
        private void buttonRentMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string CustId, MovieId, IssueDate, ReturnDate;
                int totalDays=0;
                int temp = 0;
                int TotalRent = 0;
                CustId = cbCust.SelectedValue.ToString();
                MovieId = cbMovi.SelectedValue.ToString();
                IssueDate = dtissue.Value.ToShortDateString();
                ReturnDate = dtReturn.Value.ToShortDateString();

                if (CustId.Equals("") || CustId == null)
                {
                    MessageBox.Show("Please select a customer", "Alert");
                }
                else if (MovieId.Equals("") || MovieId == null)
                {
                    MessageBox.Show("Please select a movie", "Alert");
                }
                else if (DateTime.Parse(IssueDate) > DateTime.Parse(ReturnDate))
                {
                    MessageBox.Show("Issue date can not be greater than retun date", "Alert");
                }
                else if (IssueDate == ReturnDate)
                {
                    totalDays = 1;
                    temp = CalculateMovieRentCost(int.Parse(MovieId)); // Getting rent amount for that movie

                    TotalRent = totalDays * temp; // Calculate the Total Rent of issue movie
                }
                else
                {
                   totalDays = Convert.ToInt32((DateTime.Parse(ReturnDate) - DateTime.Parse(IssueDate)).TotalDays);
                    temp = CalculateMovieRentCost(int.Parse(MovieId)); // Getting rent amount for that movie

                    TotalRent = totalDays * temp; // Calculate the Total Rent of issue movie
                }

                
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "RentMovie";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MovieID", MovieId);
                    cmd.Parameters.AddWithValue("@CustID", CustId);
                    cmd.Parameters.AddWithValue("@RentDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                    cmd.Parameters.AddWithValue("@TotalRent", TotalRent);
                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindRentMovieGrid();//method calling to Bind Grid for all rental movies
                        MessageBox.Show("Movie rented successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to rent this movie");
                    }
                    cmd.Dispose();
                    con.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Calculate the Rent Amount
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Releaseyear = txtYear.Text.Trim();
                string thisYear = DateTime.Now.Year.ToString();
                if (Releaseyear.Equals(""))
                {
                    txtRentedCost.Text = "";
                }

                else
                {
                    int difference = int.Parse(thisYear) - int.Parse(Releaseyear);
                    //if videos are older than 5 years (Release Date) then they cost $2 otherwise it cost $5
                    if (difference > 5)
                    {
                        txtRentedCost.Text = "2";
                    }
                    else
                    {
                        txtRentedCost.Text = "5";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add New Movie here
        private void btnAddMOvie_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Title, Rent, Year, Rating, Genre;
                Title = txtTitle.Text.Trim();
                Rent = txtRentedCost.Text.Trim();
                Rating = txtRating.Text.Trim();
                Year = txtYear.Text.Trim();
                Genre = txtGenre.Text.Trim();

                if (Title.Equals(""))
                {
                    MessageBox.Show("Movie title is required!");
                }
                else if (Year.Equals(""))
                {
                    MessageBox.Show("Movie released year is required!");
                }

                else if (Genre.Equals(""))
                {
                    MessageBox.Show("Movie genre is required!");
                }
                else if (Rent.Equals(""))
                {
                    MessageBox.Show("Movie rent cost is required!");
                }

                else if (Rating.Equals(""))
                {
                    MessageBox.Show("Movie rating is required!");
                }

                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "insert into movies values(@Title,@Year,@Rent,@Genre,@Rating)";
                    cmd.Connection = con;
                    
                    cmd.Parameters.Add(new SqlParameter("@Title", Title));
                    cmd.Parameters.Add(new SqlParameter("@Rent", Rent));
                    cmd.Parameters.Add(new SqlParameter("@Genre", Genre));
                    cmd.Parameters.Add(new SqlParameter("@Year", Year));
                    cmd.Parameters.Add(new SqlParameter("@Rating", Rating));
                    bool result = cmd.ExecuteNonQuery() > 0;
                    if (result)
                    {
                        BindGridMovies(); // method calling to Bind Grid Movies
                        MessageBox.Show("Movie Info Saved!", "Alert");

                        txtTitle.Text = "";
                        txtYear.Text = "";
                        txtRating.Text = "";
                        txtGenre.Text = "";
                        txtRentedCost.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Movie Info NOT Saved!", "Alert");
                    }
                    cmd.Dispose();
                    con.Dispose();


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
