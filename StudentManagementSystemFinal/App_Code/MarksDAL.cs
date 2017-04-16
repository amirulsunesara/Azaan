using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for MarksDAL
/// </summary>
public class MarksDAL
{
    Conn connect = new Conn();
    public DataSet getData(int id)
    {
       
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select student_name,course_id,student_id from Registration where course_id=(select course_id from course where instructor_id2='"+id+"')   ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public DataSet CheckMarksUploaded(int id)
    {

        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select course_id,student_id from marks where course_id=(select course_id from course where instructor_id2='" + id + "')   ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public void AddMarks(int stdid,int courseid,int marks)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Insert into marks(course_id,student_id,marks) values('"+courseid+"','"+stdid+"','"+marks+"')", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    public DataSet getAllData(int id)
    {

        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select * from marks where student_id="+id, conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public DataSet getAllData(int id,int cid)
    {

        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();

        SqlCommand cmd = new SqlCommand("Select * from marks where student_id='"+id+"' AND course_id='"+cid+"'  ", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
}