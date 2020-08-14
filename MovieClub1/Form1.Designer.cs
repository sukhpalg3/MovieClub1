namespace MovieClub1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customer = new System.Windows.Forms.Button();
            this.Movie = new System.Windows.Forms.Button();
            this.rentMovie = new System.Windows.Forms.Button();
            this.returnMovie = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1Customer = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.groupBoxMovies = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddMOvie = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentedCost = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.tbxMovieID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelMOvie = new System.Windows.Forms.Button();
            this.groupBoxReturnMovie = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cblistCustomer = new System.Windows.Forms.ComboBox();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cblistrentmovies = new System.Windows.Forms.ComboBox();
            this.gbRentMovies = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cbCust = new System.Windows.Forms.ComboBox();
            this.cbMovi = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtissue = new System.Windows.Forms.DateTimePicker();
            this.buttonRentMovie = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1Customer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMovies.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxReturnMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbRentMovies.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.Maroon;
            this.customer.ForeColor = System.Drawing.Color.White;
            this.customer.Location = new System.Drawing.Point(-1, 1);
            this.customer.Margin = new System.Windows.Forms.Padding(4);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(200, 40);
            this.customer.TabIndex = 0;
            this.customer.Text = "Customers";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // Movie
            // 
            this.Movie.BackColor = System.Drawing.Color.Maroon;
            this.Movie.ForeColor = System.Drawing.Color.White;
            this.Movie.Location = new System.Drawing.Point(207, 1);
            this.Movie.Margin = new System.Windows.Forms.Padding(4);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(200, 40);
            this.Movie.TabIndex = 1;
            this.Movie.Text = "Movies";
            this.Movie.UseVisualStyleBackColor = false;
            this.Movie.Click += new System.EventHandler(this.Movie_Click);
            // 
            // rentMovie
            // 
            this.rentMovie.BackColor = System.Drawing.Color.Maroon;
            this.rentMovie.ForeColor = System.Drawing.Color.White;
            this.rentMovie.Location = new System.Drawing.Point(415, 1);
            this.rentMovie.Margin = new System.Windows.Forms.Padding(4);
            this.rentMovie.Name = "rentMovie";
            this.rentMovie.Size = new System.Drawing.Size(220, 40);
            this.rentMovie.TabIndex = 2;
            this.rentMovie.Text = "Rent Movie";
            this.rentMovie.UseVisualStyleBackColor = false;
            this.rentMovie.Click += new System.EventHandler(this.rentMovie_Click);
            // 
            // returnMovie
            // 
            this.returnMovie.BackColor = System.Drawing.Color.Maroon;
            this.returnMovie.ForeColor = System.Drawing.Color.White;
            this.returnMovie.Location = new System.Drawing.Point(643, 1);
            this.returnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.returnMovie.Name = "returnMovie";
            this.returnMovie.Size = new System.Drawing.Size(220, 40);
            this.returnMovie.TabIndex = 3;
            this.returnMovie.Text = "Return Movie";
            this.returnMovie.UseVisualStyleBackColor = false;
            this.returnMovie.Click += new System.EventHandler(this.returnMovie_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(871, 1);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 363);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(-1, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Customers Who Borrows Most Movies ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(415, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Most Popular Movies";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(775, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "All Rented Movies";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1Customer
            // 
            this.groupBox1Customer.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1Customer.Controls.Add(this.panel1);
            this.groupBox1Customer.Controls.Add(this.tbxCustomerID);
            this.groupBox1Customer.Controls.Add(this.label13);
            this.groupBox1Customer.Controls.Add(this.DeleteCustomer);
            this.groupBox1Customer.Controls.Add(this.UpdateCustomer);
            this.groupBox1Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1Customer.Location = new System.Drawing.Point(12, 454);
            this.groupBox1Customer.Name = "groupBox1Customer";
            this.groupBox1Customer.Size = new System.Drawing.Size(1030, 210);
            this.groupBox1Customer.TabIndex = 44;
            this.groupBox1Customer.TabStop = false;
            this.groupBox1Customer.Text = "Customer Panel";
            this.groupBox1Customer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.AddCustomer);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 100);
            this.panel1.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 28);
            this.txtName.TabIndex = 44;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.Black;
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.Location = new System.Drawing.Point(817, 34);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(160, 40);
            this.AddCustomer.TabIndex = 43;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(267, 37);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 47);
            this.txtAddress.TabIndex = 31;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(569, 37);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 28);
            this.txtPhone.TabIndex = 32;
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(487, 153);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(100, 28);
            this.tbxCustomerID.TabIndex = 53;
            this.tbxCustomerID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(365, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 24);
            this.label13.TabIndex = 52;
            this.label13.Text = "Customer Id:";
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.Black;
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCustomer.Location = new System.Drawing.Point(815, 146);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(178, 40);
            this.DeleteCustomer.TabIndex = 26;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.Black;
            this.UpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCustomer.Location = new System.Drawing.Point(608, 147);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(190, 40);
            this.UpdateCustomer.TabIndex = 25;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // groupBoxMovies
            // 
            this.groupBoxMovies.BackColor = System.Drawing.Color.Bisque;
            this.groupBoxMovies.Controls.Add(this.panel2);
            this.groupBoxMovies.Controls.Add(this.tbxMovieID);
            this.groupBoxMovies.Controls.Add(this.label14);
            this.groupBoxMovies.Controls.Add(this.btnUpdate);
            this.groupBoxMovies.Controls.Add(this.btnDelMOvie);
            this.groupBoxMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMovies.Location = new System.Drawing.Point(12, 454);
            this.groupBoxMovies.Name = "groupBoxMovies";
            this.groupBoxMovies.Size = new System.Drawing.Size(1063, 213);
            this.groupBoxMovies.TabIndex = 49;
            this.groupBoxMovies.TabStop = false;
            this.groupBoxMovies.Text = "Movie Panel";
            this.groupBoxMovies.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnAddMOvie);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtRating);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtRentedCost);
            this.panel2.Controls.Add(this.txtGenre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Location = new System.Drawing.Point(16, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 109);
            this.panel2.TabIndex = 56;
            // 
            // btnAddMOvie
            // 
            this.btnAddMOvie.BackColor = System.Drawing.Color.Black;
            this.btnAddMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMOvie.Location = new System.Drawing.Point(866, 47);
            this.btnAddMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMOvie.Name = "btnAddMOvie";
            this.btnAddMOvie.Size = new System.Drawing.Size(140, 40);
            this.btnAddMOvie.TabIndex = 63;
            this.btnAddMOvie.Text = "Add Movie";
            this.btnAddMOvie.UseVisualStyleBackColor = false;
            this.btnAddMOvie.Click += new System.EventHandler(this.btnAddMOvie_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "Rent cost($):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Rating (*/10):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Genre:";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(573, 54);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(105, 28);
            this.txtRating.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Year:";
            // 
            // txtRentedCost
            // 
            this.txtRentedCost.Location = new System.Drawing.Point(706, 54);
            this.txtRentedCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentedCost.Name = "txtRentedCost";
            this.txtRentedCost.Size = new System.Drawing.Size(143, 28);
            this.txtRentedCost.TabIndex = 58;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(379, 54);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(172, 28);
            this.txtGenre.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(21, 54);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(237, 28);
            this.txtTitle.TabIndex = 54;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(282, 54);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(81, 28);
            this.txtYear.TabIndex = 56;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // tbxMovieID
            // 
            this.tbxMovieID.Location = new System.Drawing.Point(561, 159);
            this.tbxMovieID.Name = "tbxMovieID";
            this.tbxMovieID.Size = new System.Drawing.Size(100, 28);
            this.tbxMovieID.TabIndex = 55;
            this.tbxMovieID.TextChanged += new System.EventHandler(this.tbxMovieID_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(461, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 24);
            this.label14.TabIndex = 52;
            this.label14.Text = "Movie Id:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(679, 156);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 40);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelMOvie
            // 
            this.btnDelMOvie.BackColor = System.Drawing.Color.Black;
            this.btnDelMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelMOvie.Location = new System.Drawing.Point(857, 156);
            this.btnDelMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelMOvie.Name = "btnDelMOvie";
            this.btnDelMOvie.Size = new System.Drawing.Size(160, 40);
            this.btnDelMOvie.TabIndex = 53;
            this.btnDelMOvie.Text = "Delete Movie";
            this.btnDelMOvie.UseVisualStyleBackColor = false;
            this.btnDelMOvie.Click += new System.EventHandler(this.btnDelMOvie_Click);
            // 
            // groupBoxReturnMovie
            // 
            this.groupBoxReturnMovie.BackColor = System.Drawing.Color.Bisque;
            this.groupBoxReturnMovie.Controls.Add(this.pictureBox1);
            this.groupBoxReturnMovie.Controls.Add(this.panel3);
            this.groupBoxReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReturnMovie.Location = new System.Drawing.Point(12, 454);
            this.groupBoxReturnMovie.Name = "groupBoxReturnMovie";
            this.groupBoxReturnMovie.Size = new System.Drawing.Size(882, 253);
            this.groupBoxReturnMovie.TabIndex = 61;
            this.groupBoxReturnMovie.TabStop = false;
            this.groupBoxReturnMovie.Text = "Movie Return ";
            this.groupBoxReturnMovie.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieClub1.Properties.Resources._67817198_its_a_wrap_final_finished_complete_done_movie_clapper_boards_3d_illustration;
            this.pictureBox1.Location = new System.Drawing.Point(545, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cblistCustomer);
            this.panel3.Controls.Add(this.btnReturnMovie);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cblistrentmovies);
            this.panel3.Location = new System.Drawing.Point(36, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 196);
            this.panel3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 61;
            this.label12.Text = "Customer:";
            // 
            // cblistCustomer
            // 
            this.cblistCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblistCustomer.FormattingEnabled = true;
            this.cblistCustomer.Location = new System.Drawing.Point(163, 31);
            this.cblistCustomer.Name = "cblistCustomer";
            this.cblistCustomer.Size = new System.Drawing.Size(213, 30);
            this.cblistCustomer.TabIndex = 60;
            this.cblistCustomer.SelectedIndexChanged += new System.EventHandler(this.cblistCustomer_SelectedIndexChanged);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.Black;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnMovie.Location = new System.Drawing.Point(163, 125);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(160, 40);
            this.btnReturnMovie.TabIndex = 57;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 24);
            this.label11.TabIndex = 59;
            this.label11.Text = "Movie:";
            // 
            // cblistrentmovies
            // 
            this.cblistrentmovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblistrentmovies.FormattingEnabled = true;
            this.cblistrentmovies.Location = new System.Drawing.Point(163, 77);
            this.cblistrentmovies.Name = "cblistrentmovies";
            this.cblistrentmovies.Size = new System.Drawing.Size(213, 30);
            this.cblistrentmovies.TabIndex = 58;
            // 
            // gbRentMovies
            // 
            this.gbRentMovies.BackColor = System.Drawing.Color.Bisque;
            this.gbRentMovies.Controls.Add(this.panel4);
            this.gbRentMovies.Controls.Add(this.label17);
            this.gbRentMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRentMovies.Location = new System.Drawing.Point(12, 454);
            this.gbRentMovies.Name = "gbRentMovies";
            this.gbRentMovies.Size = new System.Drawing.Size(1017, 283);
            this.gbRentMovies.TabIndex = 62;
            this.gbRentMovies.TabStop = false;
            this.gbRentMovies.Text = "Rent Movie Panel";
            this.gbRentMovies.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.cbCust);
            this.panel4.Controls.Add(this.cbMovi);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dtReturn);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.dtissue);
            this.panel4.Controls.Add(this.buttonRentMovie);
            this.panel4.Location = new System.Drawing.Point(40, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(935, 210);
            this.panel4.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 24);
            this.label16.TabIndex = 78;
            this.label16.Text = "Select Customer:";
            // 
            // cbCust
            // 
            this.cbCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCust.FormattingEnabled = true;
            this.cbCust.Location = new System.Drawing.Point(198, 23);
            this.cbCust.Name = "cbCust";
            this.cbCust.Size = new System.Drawing.Size(231, 30);
            this.cbCust.TabIndex = 77;
            // 
            // cbMovi
            // 
            this.cbMovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovi.FormattingEnabled = true;
            this.cbMovi.Location = new System.Drawing.Point(646, 26);
            this.cbMovi.Name = "cbMovi";
            this.cbMovi.Size = new System.Drawing.Size(231, 30);
            this.cbMovi.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(517, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 24);
            this.label15.TabIndex = 75;
            this.label15.Text = "Select Movie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 71;
            this.label9.Text = "Issue Date:";
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(646, 86);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(231, 28);
            this.dtReturn.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 74;
            this.label10.Text = "Return Date:";
            // 
            // dtissue
            // 
            this.dtissue.Location = new System.Drawing.Point(199, 83);
            this.dtissue.Name = "dtissue";
            this.dtissue.Size = new System.Drawing.Size(230, 28);
            this.dtissue.TabIndex = 72;
            // 
            // buttonRentMovie
            // 
            this.buttonRentMovie.BackColor = System.Drawing.Color.Black;
            this.buttonRentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRentMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRentMovie.Location = new System.Drawing.Point(283, 148);
            this.buttonRentMovie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRentMovie.Name = "buttonRentMovie";
            this.buttonRentMovie.Size = new System.Drawing.Size(400, 45);
            this.buttonRentMovie.TabIndex = 70;
            this.buttonRentMovie.Text = "Rent  Movie";
            this.buttonRentMovie.UseVisualStyleBackColor = false;
            this.buttonRentMovie.Click += new System.EventHandler(this.buttonRentMovie_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(123, -67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 52;
            this.label17.Text = "Select Movie:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieClub1.Properties.Resources.images__5_;
            this.pictureBox2.Location = new System.Drawing.Point(1060, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 277);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MovieClub1.Properties.Resources.images__2_;
            this.pictureBox3.Location = new System.Drawing.Point(1060, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(294, 216);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::MovieClub1.Properties.Resources.images__6_;
            this.pictureBox4.Location = new System.Drawing.Point(1061, 502);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(294, 260);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieClub1.Properties.Resources.movie_premiere_event_cine_theatre_cinema_white_blank_screen_dark_movie_hall_interior_with_empty_red_seats_vector_background_102902_33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 766);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbRentMovies);
            this.Controls.Add(this.groupBoxReturnMovie);
            this.Controls.Add(this.groupBoxMovies);
            this.Controls.Add(this.groupBox1Customer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnMovie);
            this.Controls.Add(this.rentMovie);
            this.Controls.Add(this.Movie);
            this.Controls.Add(this.customer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Club";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1Customer.ResumeLayout(false);
            this.groupBox1Customer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxMovies.ResumeLayout(false);
            this.groupBoxMovies.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxReturnMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbRentMovies.ResumeLayout(false);
            this.gbRentMovies.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button Movie;
        private System.Windows.Forms.Button rentMovie;
        private System.Windows.Forms.Button returnMovie;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1Customer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.GroupBox groupBoxMovies;
        private System.Windows.Forms.TextBox tbxMovieID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelMOvie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddMOvie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRentedCost;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox groupBoxReturnMovie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cblistCustomer;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cblistrentmovies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbRentMovies;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbCust;
        private System.Windows.Forms.ComboBox cbMovi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtissue;
        private System.Windows.Forms.Button buttonRentMovie;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

