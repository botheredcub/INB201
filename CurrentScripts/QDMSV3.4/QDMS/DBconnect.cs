using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Drawing;

using System.Windows.Forms;

using MySql.Data.MySqlClient;



namespace WindowsFormsApplication1 {

    public class DBConnect {



        private MySqlConnection connection;

        private string server;

        private string database;

        private string uid;

        private string password;



        //Constructor

        public DBConnect() {

            Initialize();

        }



        //Initialize values

        public void Initialize() {

            server = "localhost";

            database = "inb201";

            uid = "root";

            password = "rjop0248";

            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +

            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";



            connection = new MySqlConnection(connectionString);

        }



        //open connection to database

        public bool OpenConnection() {

            try {

                connection.Open();

                MessageBox.Show("Successful Connection");

                return true;

            } catch (MySqlException ex) {

                //When handling errors, you can your application's response based 

                //on the error number.

                //The two most common error numbers when connecting are as follows:

                //0: Cannot connect to server.

                //1045: Invalid user name and/or password.

                switch (ex.Number) {

                    case 0:      

                        MessageBox.Show("Cannot connect to server.  Contact administrator");

                        break;



                    case 1045:

                        MessageBox.Show("Invalid username/password, please try again");

                        break;

                }

                return false;

            }

        }



        //Close connection

        public bool CloseConnection() {

            try {

                connection.Close();

                return true;

            } catch (MySqlException ex) {

                MessageBox.Show(ex.Message);

                return false;

            }

        }



            //Insert statement
            public void Insert_personnel()
            {
                //Account table columns
                string FirstName = "yes";
                string MiddleName = "name";
                string LastName = "given";
                string Address = "42 Address";
                string Gender = "male";
                string Email = "email@hotmail.com";
                string City = "Cairns";
                string Password = "password";
                string AccessLevel = "basic";
                string AccountCode = "FR";
                int Phone = 32887777;
                int Postcode = 4300;
                

               /*`Password` , `AccessLevel`,  `F_name` ,  `L_name`,  `M_name`,  `Phone`  ,  `Address`,
  `City` ,  `PostCode`,  `gender` ,  `email`,  `AccountCode` )*/
                string query = "INSERT INTO inb201.personnel(`Password` , `AccessLevel`,  `FirstName` ,  `LastName`,  `MiddleName`,  `Phone`  ,  `Address`, `City` ,  `PostCode`,  `Gender` ,  `Email`,  `AccountCode` )VALUES (MD5('"+Password+"'), '"+AccessLevel+"','"+FirstName+"','"+LastName+"','"+MiddleName+"','"+Phone+"','"+Address+"','"+City+"','"+Postcode+"','"+Gender+"','"+Email+"','"+AccountCode+"')";
                //string query = "INSERT INTO inb201.personnel(`Password` , `AccessLevel`,  `FirstName` ,  `LastName`,  `MiddleName`,  `Phone`  ,  `Address`, `City` ,  `PostCode`,  `Gender` ,  `Email`,  `AccountCode` )VALUES (MD5('Password123'), 'basic','first','given','name','32882102','65 Wilson','Brisbane','4300','male','testing@hotmail.com','FR')";
                MessageBox.Show(query);
                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                else 
                {
                    MessageBox.Show("oh no");
                }
            }

            public void Insert_events_t()
            {

                string query = "INSERT INTO events_t(`EventCode`,`IncidentAddress`,`EventStatus`, `EventWarning`, `CityName`,`Event_Date`,`Notes`, `Event_updated_Date`)VALUES('', '','','','','','')";

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            public void Insert_incident()
            {
                string query = "INSERT INTO Incidents ( `UserID`, `Event_ID`)  VALUES('', '')"; 
                /* The values need to inptted from variable that we will assign to eachof hte input boxes that will hold 
                 * temporary values the forms submit box will be when the db connect opesn and closes and it will check that the 
                 values associated with the values that go with it are their in a variable compare statement first*/

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            //Update statement
            public void Update_Events()
            {
                string query = 
                "UPDATE events_t SET EventStatus='', Event_updated_Date='', EventWarning='' WHERE EventID=''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            public void Update_Personnel_password()
            {
                string query = "UPDATE personnel SET Password=MD5('') where UserID=''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            public void Update_Personnel_Contact_details()
            {
                string query = "UPDATE personnel SET phone='', email='' where UserID=''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            public void Update_Personnel_Address()
            {
                string query = "UPDATE personnel SET Address='', City='', PostCode='' where UserID=''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            public void Update_Incidents_Responded_to()
            {
                string query = "UPDATE Incidents SET Responded_DateTime='' WHERE UserID='' AND Event_ID=''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            public void Update_Incidents_Finalized()
            {
                string query = "UPDATE Incidents SET Finalized_DateTime='' WHERE UserID='' AND Event_ID=''";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            //Delete statement
            public void Delete()
            {
                string query = "DELETE FROM tableinfo WHERE name='John Smith'";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }

           
            //Select statement
            public List<string>[] Select_Personnel_Information_about()
            {
                //string query = "SELECT P.UserID, P.F_name, P.L_name, P.Address, P.City, P.PostCode, P.Phone, S.AccountType FROM Personnel P inner join Services S where P.AccountCode = S.Accountcode";
                string query = "SELECT * from Location;";

                //Create a list to store the result
                
                List<string>[] list = new List<string>[4];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();
      
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["CityName"] + "");
                        list[1].Add(dataReader["RegionName"] + "");
                        list[2].Add(dataReader["latitude"] + "");
                        list[3].Add(dataReader["longitude"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;

                }
                else
                {
                    return list;
                }
            } 

            public List<string>[] Select_City_list()
            {
                string query = "SELECT * FROM location where RegionName='Far North'";

                //Create a list to store the result
                List<string>[] list = new List<string>[4];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataRepeater1 = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataRepeater1.Read())
                    {
                        list[0].Add(dataRepeater1["CityName"] + "");
                        list[0].Add(dataRepeater1["RegionName"] + "");
                        list[0].Add(dataRepeater1["Latitude"] + "");
                        list[0].Add(dataRepeater1["Longitude"] + "");
                    }

                    //close Data Reader
                    dataRepeater1.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            public List<string>[] returnlat_long_list()
            {
                string query = "SELECT latitude, longitude FROM location Where RegionName='' AND CityName=''";

                //Create a list to store the result
                List<string>[] list = new List<string>[2];
                list[0] = new List<string>();
                list[1] = new List<string>();

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["latitude"] + "");
                        list[1].Add(dataReader["longitude"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            //Count statement
            public int Count()
            {
                string query = "SELECT Count(*) FROM location";
                int Count = -1;

                //Open Connection
                if (this.OpenConnection() == true)
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");

                    //close Connection
                    this.CloseConnection();

                    return Count;
                }
                else
                {
                    return Count;
                }


            }
        }
    }

         