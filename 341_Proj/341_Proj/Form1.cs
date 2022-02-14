using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _341_Proj
{
    public partial class Form1 : Form
    {
        OracleConnection conn = new OracleConnection("Server=localhost;User Id=deneme;Password=1234;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Welcome");
        }

        private void listMovies_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM MOVIE", conn);
                OracleDataReader reader = cmd.ExecuteReader();

                var col = ("Title            Year          Runtime");
                listBox1.Items.Add(col);

                while (reader.Read())
                {
                    var column1 = reader["Title"];
                    var column2 = reader["Year_"];
                    var column3 = reader["Runtime"];
                    var column = (column1.ToString() + "    " + column2.ToString() + "    " + column3.ToString());
                    listBox1.Items.Add(column);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void listSeries_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM TVSERIES", conn);
                OracleDataReader reader = cmd.ExecuteReader();

                var col = ("Title         Season No");
                listBox1.Items.Add(col);

                while (reader.Read())
                {
                    var column1 = reader["Title"];
                    var column2 = reader["Season_No"];
                    var column = (column1.ToString() + "    " + column2.ToString());
                    listBox1.Items.Add(column);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void crewList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM CREW", conn);
                OracleDataReader reader = cmd.ExecuteReader();

                var col = ("Name           Birth Date");
                listBox1.Items.Add(col);

                while (reader.Read())
                {
                    var column1 = reader["Name"];
                    var column2 = reader["B_date"];
                    var column = (column1.ToString() + "    " + column2.ToString().Remove(10));
                    listBox1.Items.Add(column);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void genreList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM GENRE", conn);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var column1 = reader["Name"];
                    var column = (column1.ToString());
                    listBox1.Items.Add(column);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void findAct_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT CREW.NAME, CAST_.GENDER, CREW.B_DATE, CREW.BIOGRAPHY " +
                                                        "FROM CREW INNER JOIN CAST_ ON CAST_.C_ID = CREW.C_ID " +
                                                        "WHERE CREW.C_ID IN (SELECT C_ID " +
                                                        "FROM CREW WHERE NAME = :name)", conn);

                string str = text1.Text;
                cmd.Parameters.AddWithValue(":name", str);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var column1 = reader["Name"];
                    var column2 = reader["Gender"];
                    var column3 = reader["B_date"];
                    var column = ("Name: " + column1.ToString() + " Gender: " + column2.ToString() + " Birthdate: " + column3.ToString().Remove(10));
                    listBox1.Items.Add(column);

                    column1 = reader["Biography"];
                    column = (column1.ToString());
                    listBox1.Items.Add(column);
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT * FROM MOVIE WHERE M_ID IN (SELECT M_ID " +
                                        "FROM PART_OF_M WHERE C_ID IN (SELECT C_ID " +
                                        "FROM CREW WHERE NAME = :name))", conn);

                cmd.Parameters.AddWithValue(":name", str);
                reader = cmd.ExecuteReader();

                if (reader != null)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Movies:");
                    while (reader.Read())
                    {
                        var column1 = reader["Title"];
                        var column2 = reader["Year_"];
                        var column3 = reader["Runtime"];
                        var column4 = reader["Rate"];

                        var column = (column1.ToString() + " " + column2.ToString() + " Runtime: " + column3.ToString() + " Rate: " + column4.ToString());
                        listBox1.Items.Add(column);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT * FROM TVSERIES WHERE S_ID IN (SELECT S_ID " +
                                        "FROM PART_OF_S WHERE C_ID IN (SELECT C_ID " +
                                        "FROM CREW WHERE NAME = :name))", conn);

                text1.Clear();
                cmd.Parameters.AddWithValue(":name", str);
                reader = cmd.ExecuteReader();

                if (reader != null)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Series:");
                    while (reader.Read())
                    {
                        var column1 = reader["Title"];
                        var column2 = reader["Start_date"];
                        var column3 = reader["End_date"];
                        var column4 = reader["Rating"];

                        var column = (column1.ToString() + " " + column2.ToString().Remove(10) + " - " + column3.ToString().Remove(10) + " Rate: " + column4.ToString());
                        listBox1.Items.Add(column);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void findMovie_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM MOVIE WHERE TITLE = :title ", conn);
                string str = text2.Text;
                text2.Clear();
                cmd.Parameters.AddWithValue(":title", str);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var column1 = reader["Title"];
                    var column2 = reader["Year_"];
                    var column3 = reader["Rate"];
                    var column4 = reader["Runtime"];

                    var column = (column1.ToString() + " " + column2.ToString() + " Rate: " + column3.ToString() + " Runtime: " + column4.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Lang"];
                    column2 = reader["Country"];

                    column = ("Language: " + column1.ToString() + " Country: " + column2.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Budget"];
                    column2 = reader["Box_office"];

                    column = ("Financial Details: Budget: " + column1.ToString() + " Box Office: " + column2.ToString());
                    listBox1.Items.Add(column);
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT NAME FROM GENRE WHERE NAME IN (SELECT NAME " +
                                            "FROM BELONGS_TO_M WHERE M_ID IN (SELECT M_ID " +
                                            "FROM MOVIE WHERE TITLE = :title))", conn);

                cmd.Parameters.AddWithValue(":title", str);
                reader = cmd.ExecuteReader();

                if (reader != null)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Genres:");
                    while (reader.Read())
                    {
                        var column1 = reader["NAME"];
                        var column = (column1.ToString());
                        listBox1.Items.Add(column);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT CREW.NAME,CAST_.GENDER,CREW.B_DATE FROM CREW " +
                                        "INNER JOIN CAST_ ON CAST_.C_ID = CREW.C_ID " +
                                        "WHERE CREW.C_ID IN (SELECT C_ID " +
                                        "FROM PART_OF_M WHERE M_ID IN(SELECT M_ID " +
                                        "FROM MOVIE WHERE TITLE = :title))", conn);

                cmd.Parameters.AddWithValue(":title", str);
                reader = cmd.ExecuteReader();

                if (reader != null)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Actors/Actresses:");
                    while (reader.Read())
                    {
                        var column1 = reader["NAME"];
                        var column2 = reader["GENDER"];
                        var column3 = reader["B_DATE"];
                        var column = (column1.ToString() + " " + column2.ToString() + " " + column3.ToString().Remove(10));
                        listBox1.Items.Add(column);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT CREW.NAME, DIRECTOR.TYPE_, CREW.B_DATE FROM CREW INNER JOIN DIRECTOR ON " +
                                                        "DIRECTOR.C_ID = CREW.C_ID WHERE CREW.C_ID IN (SELECT C_ID FROM PART_OF_M " +
                                                        "WHERE M_ID IN (SELECT M_ID FROM MOVIE WHERE TITLE = :title))", conn);

                cmd.Parameters.AddWithValue(":title", str);
                reader = cmd.ExecuteReader();

                listBox1.Items.Add(" ");
                listBox1.Items.Add("Director:");

                while (reader.Read())
                {
                    var column1 = reader["Name"];
                    var column2 = reader["B_date"];
                    var column3 = reader["Type_"];
                    var column = (column1.ToString() + " " + column2.ToString().Remove(10) + " Type: " + column3.ToString());
                    listBox1.Items.Add(column);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void findSeries_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM TVSERIES WHERE TITLE = :title ", conn);
                string str = text3.Text;
                cmd.Parameters.AddWithValue(":title", str);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var column1 = reader["Title"];
                    var column2 = reader["Start_date"];
                    var column3 = reader["End_date"];
                    var column4 = reader["Rating"];

                    var column = (column1.ToString() + " " + column2.ToString().Remove(10) + " - " + column3.ToString().Remove(10) + " Rate: " + column4.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Season_no"];
                    column2 = reader["Platform"];

                    column = ("Season No: " + column1.ToString() + " Platform: " + column2.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Lang"];
                    column2 = reader["Country"];

                    column = ("Language: " + column1.ToString() + " Country: " + column2.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Budget"];

                    column = ("Financial Details: Budget: " + column1.ToString());
                    listBox1.Items.Add(column);
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT NAME FROM GENRE WHERE NAME IN (SELECT NAME " +
                                            "FROM BELONGS_TO_S WHERE S_ID IN (SELECT S_ID " +
                                            "FROM TVSERIES WHERE TITLE = :title))", conn);

                cmd.Parameters.AddWithValue(":title", str);
                reader = cmd.ExecuteReader();

                if (reader != null)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Genres:");
                    while (reader.Read())
                    {
                        var column1 = reader["NAME"];
                        var column = (column1.ToString());
                        listBox1.Items.Add(column);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new OracleCommand("SELECT CREW.NAME,CAST_.GENDER,CREW.B_DATE FROM CREW " +
                                                        "INNER JOIN CAST_ ON CAST_.C_ID = CREW.C_ID WHERE CREW.C_ID IN " +
                                                        "(SELECT C_ID FROM PART_OF_S WHERE S_ID IN (SELECT S_ID " +
                                                        "FROM TVSERIES WHERE TITLE = :title))", conn);

                text3.Clear();
                cmd.Parameters.AddWithValue(":title", str);
                reader = cmd.ExecuteReader();

                if (reader != null)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Actors/Actresses:");

                    while (reader.Read())
                    {
                        var column1 = reader["NAME"];
                        var column2 = reader["GENDER"];
                        var column3 = reader["B_DATE"];
                        var column = (column1.ToString() + " " + column2.ToString() + " " + column3.ToString().Remove(10));
                        listBox1.Items.Add(column);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        private void findGenre_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM MOVIE WHERE M_ID IN (SELECT M_ID " +
                                                        "FROM BELONGS_TO_M WHERE NAME = :name)", conn);
                string str = text4.Text;
                text4.Clear();
                cmd.Parameters.AddWithValue(":name", str);
                OracleDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Add("Movies:");
                listBox1.Items.Add(" ");

                while (reader.Read())
                {
                    var column1 = reader["Title"];
                    var column2 = reader["Year_"];
                    var column3 = reader["Rate"];
                    var column4 = reader["Runtime"];

                    var column = (column1.ToString() + " " + column2.ToString() + " Rate: " + column3.ToString() + " Runtime: " + column4.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Lang"];
                    column2 = reader["Country"];

                    column = ("Language: " + column1.ToString() + " Country: " + column2.ToString());
                    listBox1.Items.Add(column);
                    listBox1.Items.Add(" ");
                }

                cmd = new OracleCommand("SELECT * FROM TVSERIES WHERE S_ID IN (SELECT S_ID " +
                                        "FROM BELONGS_TO_S WHERE NAME = :name)", conn);

                cmd.Parameters.AddWithValue(":name", str);
                reader = cmd.ExecuteReader();

                listBox1.Items.Add("Series:");
                listBox1.Items.Add(" ");

                while (reader.Read())
                {
                    var column1 = reader["Title"];
                    var column2 = reader["Start_date"];
                    var column3 = reader["End_date"];
                    var column4 = reader["Rating"];

                    var column = (column1.ToString() + " " + column2.ToString().Remove(10) + " - " + column3.ToString().Remove(10) + " Rate: " + column4.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Season_no"];
                    column2 = reader["Platform"];

                    column = ("Season No: " + column1.ToString() + " Platform: " + column2.ToString());
                    listBox1.Items.Add(column);

                    column1 = reader["Lang"];
                    column2 = reader["Country"];

                    column = ("Language: " + column1.ToString() + " Country: " + column2.ToString());
                    listBox1.Items.Add(column);
                    listBox1.Items.Add(" ");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void viewReview_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM REVIEW WHERE R_ID IN (SELECT R_ID " +
                                                        "FROM HAS_M WHERE M_ID IN (SELECT M_ID " +
                                                        "FROM MOVIE WHERE TITLE = :title))", conn);
                string str = text5.Text;
                text5.Clear();
                cmd.Parameters.AddWithValue(":title", str);
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var column1 = reader["Nick"];
                    var column2 = reader["Rate"];
                    var column3 = reader["Date_"];

                    var column = (column1.ToString() + " Rate: " + column2.ToString() + " Date: " + column3.ToString().Remove(10));
                    listBox1.Items.Add(column);

                    column1 = reader["Text_"];
                    column = (column1.ToString());
                    listBox1.Items.Add(column);
                }

                cmd = new OracleCommand("SELECT * FROM REVIEW WHERE R_ID IN (SELECT R_ID " +
                                                        "FROM HAS_S WHERE S_ID IN (SELECT S_ID " +
                                                        "FROM TVSERIES WHERE TITLE = :title))", conn);

                cmd.Parameters.AddWithValue(":title", str);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var column1 = reader["Nick"];
                    var column2 = reader["Rate"];
                    var column3 = reader["Date_"];

                    var column = (column1.ToString() + " Rate: " + column2.ToString() + " Date: " + column3.ToString().Remove(10));
                    listBox1.Items.Add(column);

                    column1 = reader["Text_"];
                    column = (column1.ToString());
                    listBox1.Items.Add(column);
                    listBox1.Items.Add(" ");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Add a review:");
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                
                string strtext = rText.Text;
                string strnick = rNick.Text;
                string strmov = rMovie.Text;
                string strate = rRate.Text;
                var flrate = Decimal.Parse(strate, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                DateTime ndate = DateTime.Now;
                string date = ndate.ToString("dd/MM/yyyy");
                OracleCommand cmd = new OracleCommand("SELECT MAX(R_ID) FROM REVIEW ", conn);
                OracleDataReader reader = cmd.ExecuteReader();

                rText.Clear();
                rNick.Clear();
                rMovie.Clear();
                rRate.Clear();

                reader.Read(); 
                var rid = reader["MAX(R_ID)"];
                int id = int.Parse(rid.ToString());
                id += 1;

                if (checkMovie.Checked && checkSeries.Checked)
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkMovie.Checked)
                {
                    cmd = new OracleCommand("INSERT INTO REVIEW (R_ID,Date_,Nick,Rate,Text_) VALUES " +
                                                            "(:id,to_date(:dates,'DD/MM/RRRR'),:nick,:rate,:text)", conn);
                    cmd.Parameters.AddWithValue(":id", id);
                    cmd.Parameters.AddWithValue(":dates", date);
                    cmd.Parameters.AddWithValue(":nick", strnick);
                    cmd.Parameters.AddWithValue(":rate", flrate);
                    cmd.Parameters.AddWithValue(":text", strtext);
                    cmd.ExecuteNonQuery();

                    cmd = new OracleCommand("SELECT M_ID FROM MOVIE WHERE TITLE = :title", conn);
                    cmd.Parameters.AddWithValue(":title", strmov);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    var m_id = reader["M_ID"];
                    int mid = int.Parse(m_id.ToString());

                    cmd = new OracleCommand("INSERT INTO HAS_M (M_ID,R_ID) VALUES (:mid,:rid)", conn);
                    cmd.Parameters.AddWithValue(":mid", mid);
                    cmd.Parameters.AddWithValue(":rid", id);

                    cmd.ExecuteNonQuery();
                    listBox1.Items.Add("Added");
                }

                else if (checkSeries.Checked)
                {
                    cmd = new OracleCommand("INSERT INTO REVIEW (R_ID,Date_,Nick,Rate,Text_) VALUES " +
                                                            "(:id,to_date(:dates,'DD/MM/RRRR'),:nick,:rate,:text)", conn);
                    cmd.Parameters.AddWithValue(":id", id);
                    cmd.Parameters.AddWithValue(":dates", date);
                    cmd.Parameters.AddWithValue(":nick", strnick);
                    cmd.Parameters.AddWithValue(":rate", flrate);
                    cmd.Parameters.AddWithValue(":text", strtext);
                    
                    cmd.ExecuteNonQuery();

                    cmd = new OracleCommand("SELECT S_ID FROM TVSERIES WHERE TITLE = :title", conn);
                    cmd.Parameters.AddWithValue(":title", strmov);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    var s_id = reader["S_ID"];
                    
                    int sid = int.Parse(s_id.ToString());

                    cmd = new OracleCommand("INSERT INTO HAS_S (S_ID,R_ID) VALUES (:sid,:rid)", conn);
                    cmd.Parameters.AddWithValue(":sid", sid);
                    cmd.Parameters.AddWithValue(":rid", id);

                    cmd.ExecuteNonQuery();
                    listBox1.Items.Add("Added");
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
}

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Add a review:");
        }

        private void findEpisode_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM EPISODE_INCLUDES WHERE s_ID IN (SELECT S_ID " +
                                                        "FROM TVSERIES WHERE TITLE = :title)", conn);
                string str = text6.Text;
                text6.Clear();
                cmd.Parameters.AddWithValue(":title", str);
                OracleDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    var column1 = reader["Name"];
                    var column2 = reader["E_NO"];
                    var column3 = reader["S_NO"];

                    var column = (column1.ToString() + " Episode: " + column2.ToString() + " Season: " + column3.ToString());
                    listBox1.Items.Add(column);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}