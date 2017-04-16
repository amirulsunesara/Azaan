using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for RegistrationDAL
/// </summary>
public class RegistrationDAL
{
    Conn connect = new Conn();
    public void RegisterCourse(int rowid,int studentid,string stdname)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("insert into registration(student_id,course_id,student_name) values('"+studentid+"','"+rowid+"','"+stdname+"')", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    public DataSet getStudent(string email)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select student_id,first_name,last_name from student where email='"+email+"'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public DataSet getStudent()
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select * From course", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public int getcount(int cid)
    {

        SqlConnection conn = connect.GetConnnect();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select COUNT (*) from registration where course_id='"+cid+"'", conn);
        cmd.ExecuteNonQuery();

      int  count = Convert.ToInt32(cmd.ExecuteScalar());

        conn.Close();

        return count;
    }
    public void DeRegisterCourse(int rowid)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Delete from registration where course_id="+rowid, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
}