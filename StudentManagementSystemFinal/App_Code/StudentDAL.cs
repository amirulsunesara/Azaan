using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for StudentDAL
/// </summary>
public class StudentDAL
{
    Conn connect = new Conn();
    public DataSet getStudents(int id) 
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select Student_id AS 'Student ID', Student_name 'Student Name' from Registration where course_id=(select course_id from course where instructor_id2='" + id + "')   ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;
    
    
    }
    public DataSet getStudents()
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select student_id AS 'Student ID',first_name+' '+last_name AS 'Name',cell_no AS 'Contact No.',email AS 'Email' FROM Student ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;


    }
    public DataSet getSearchStudents( string search)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select student_id AS 'Student ID',first_name+' '+last_name AS 'Name',cell_no AS 'Contact No.',email AS 'Email' FROM Student Where (first_name LIKE '" + search + "%' OR Last_name LIKE '" + search + "%' ) ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;


    }
    public DataSet getSearchStudents(int id,string search)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select student_id AS 'Student ID',first_name+' '+last_name AS 'Name',cell_no AS 'Contact No.',email AS 'Email' FROM Student where student_id=(select student_id from registration where course_id=(select course_id from course where instructor_id2='" + id + "')) AND ( first_name LIKE '" + search + "%' OR Last_name LIKE '" + search + "%' ) ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;


    }
    public DataSet getDetails(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from student where student_id='" + id + "'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public void UpdateStudent(SignUp a, int id)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Update student SET password='" + a.Password + "',email='" + a.Email + "',first_name='" + a.Fname + "',last_name='" + a.Lname + "',cell_no='"+a.Cell+"',telephone='"+a.Tel+"',address='"+a.Address+"'  where student_id='" + id + "'", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


    }

	
}