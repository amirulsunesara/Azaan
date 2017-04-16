using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for InstructorsDAL
/// </summary>
public class InstructorsDAL
{
    Conn connect = new Conn();
    public void DeleteInstructor(int rowid)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("delete from instructor where instructor_id="+rowid, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    public DataSet getInstructors()
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select  instructor_id AS 'Id' ,instructor_fname+ ' ' +instructor_lname AS 'Instructor Name' ,course_name AS 'Course' FROM Course RIGHT JOIN Instructor ON course.instructor_id2 = instructor.instructor_id", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public DataSet getDetails(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from instructor where instructor_id='" + id + "'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public void UpdateInstructor(SignUp a, int id)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Update instructor SET password='" + a.Password + "',instructor_email='" + a.Email + "',instructor_fname='" + a.Fname + "',instructor_lname='" + a.Lname + "',instructor_cellno='" + a.Cell + "',telephone='" + a.Tel + "',address='" + a.Address + "'  where instructor_id='" + id + "'", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


    }
    public DataSet getAllInstructors()
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select instructor_id ,instructor_fname + ' ' +instructor_lname AS 'Instructor Name' from Instructor", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public DataSet getAllInstructorsT()
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select instructor_id ,instructor_fname + ' ' +instructor_lname AS 'Instructor Name' from Instructor RIGHT JOIN course On course.instructor_id2=instructor.instructor_id", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public void addInstructor(SignUp su)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("insert into instructor(instructor_fname,instructor_lname,telephone,instructor_cellno,address,password,instructor_email) values('" + su.Fname + "','" + su.Lname + "','" + su.Tel + "','" + su.Cell + "','" + su.Address + "','" + su.Password + "','" + su.Email + "')", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    public DataSet ViewEnrollment() 
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select  instructor_id AS 'Id' ,instructor_fname+ ' ' +instructor_lname AS 'Instructor Name' ,course_name AS 'Course' FROM Course LEFT JOIN Instructor ON course.instructor_id2 = instructor.instructor_id", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    
    
    }
}