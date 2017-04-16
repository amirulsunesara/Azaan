using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ComposeDAL
/// </summary>
public class ComposeDAL
{
    Conn connect = new Conn();
    public void addMessage(Composer c)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("insert into message(sender,reciever,message,subject) values( '" + c.sender + "','" + c.reciever + "','" +c.message+ "','" + c.subject + "') ", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    public DataSet GetInstructorName()
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select instructor_id AS 'Id' ,instructor_fname+' '+instructor_lname AS 'Instructor Name' From instructor", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public DataSet GetInstructorName(int cid)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select instructor_id AS 'Id' ,instructor_fname+' '+instructor_lname AS 'Instructor Name' From instructor where instructor_id=(Select instructor_id2 from course where course_id='"+cid+"')", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public DataSet Check(int sid,int cid)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select * From registration where student_id='"+sid+"' AND course_id='"+cid+"'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public int getMultiple(int id)
    {

        SqlConnection conn = connect.GetConnnect();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select COUNT (*) from registration where student_id="+id, conn);
        cmd.ExecuteNonQuery();

      int  count = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();

        return count;
    }
    public DataSet GetStudentName()
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select Student_id AS 'id', first_name +' '+ last_name AS 'Student Name' From student", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public DataSet GetStudentNameByCourse(int id)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select Student_id AS 'id', first_name +' '+ last_name AS 'Student Name' From student  where student_id=(select student_id from registration where course_id=(select course_id from course where instructor_id2='" + id + "'))", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public DataSet GetMessage(string recieve)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select Id,Sender AS 'From',subject AS 'Subject',message AS 'Message' From message where reciever='"+recieve+"'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public DataSet GetSentMessage(string sender)
    {

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Select Id,Reciever AS 'To',subject AS 'Subject',message AS 'Message' From message where sender= '"+sender+"'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        return ds;
    }
    public void DeleteMessage(int rowid)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("delete from message where Id=" +rowid, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }

}