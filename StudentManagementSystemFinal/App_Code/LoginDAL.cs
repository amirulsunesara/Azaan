using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for LoginDAL
/// </summary>
public class LoginDAL : System.Web.UI.Page
{
    Conn connect = new Conn();
    public bool isCorrectLoginInfoAdministrator(string email, string password)
    {

        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from administrator where email='" + email + "' and admin_password='" + password + "'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            Session["aid"] = dr["admin_id"].ToString();
            Session["Admin_Fname"] = dr["admin_fname"].ToString();
            Session["Admin_Lname"] = dr["admin_lname"].ToString();
            string fname = dr["admin_fname"].ToString();
            string lname = dr["admin_lname"].ToString();
            string name = fname + ' ' + lname;
            Session["User"] = name;
            return true;
        }
        else
        {
            return false;
        }

    }
 
    public bool isCorrectLoginInfoStudent(string email , string password) 
    {

        DataSet ds = new DataSet();
      
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from student where email='" +email + "' and Password='" + password + "'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);

    if (ds.Tables[0].Rows.Count > 0)
        {

            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            Session["Student_Fname"] = dr["first_Name"].ToString();
            Session["Student_Lname"] = dr["last_Name"].ToString();
            Session["Course_Key"] = dr["email"].ToString();
            Session["Feedback_Key"]=dr["student_id"].ToString();
        string fname = dr["first_name"].ToString();
        string lname = dr["last_name"].ToString();
        string name = fname+' '+lname;
        Session["User"] = name;
            return true;
        }
 else
    {
        return false;
    }

    }
  
  
   
    public bool isCorrectLoginInfoInstructor(string email, string password)
    {

        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from instructor where instructor_email='" + email + "' and Password='" + password + "'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

          Session["Instructor_Fname"] = dr["instructor_fname"].ToString();
          Session["Instructor_Lname"] = dr["instructor_lname"].ToString();
          Session["Marks_Key"] = dr["instructor_id"].ToString();
          string fname = dr["instructor_fname"].ToString();
          string lname = dr["instructor_lname"].ToString();
          string name = fname + ' ' + lname;
          Session["User"] = name;

          int id = Convert.ToInt32(dr["instructor_id"]);
          SqlConnection connec = connect.GetConnnect();
          DataSet ds2 = new DataSet();
          SqlCommand cmd2 = new SqlCommand("select * from course where instructor_id2='" + id + "'", connec);
          SqlDataAdapter adpt2 = new SqlDataAdapter(cmd2);
          adpt2.Fill(ds2);
          DataTable dt2 = ds2.Tables[0];
          DataRow dr2 = dt2.Rows[0];
          Session["Lecture_Key"] = dr2["course_id"].ToString();

         
            return true;
        }
        else
        {
            return false;
        }

    }
    public void addStudent(SignUp su)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("insert into student(first_name,last_name,telephone,cell_no,address,password,email) values('" + su.Fname + "','" + su.Lname + "','" + su.Tel + "','" + su.Cell + "','" + su.Address + "','" + su.Password + "','" + su.Email + "')", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
   
    

   
    }
   
   
