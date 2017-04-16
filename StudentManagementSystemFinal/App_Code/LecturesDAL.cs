using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for LecturesDAL
/// </summary>
public class LecturesDAL

{
    Conn connect = new Conn();

  
    public int AddStudent(Lectures l)
    {
        SqlConnection conn = connect.GetConnnect();
        string q = "INSERT INTO Lectures (LectureName,LectureDescription,PictureUri,course_id,instructor_name) OUTPUT Inserted.Id VALUES(@n,@c,@p,@i,@in)";
        SqlCommand cmd = new SqlCommand(q, conn);
        conn.Open();
     
        cmd.Parameters.AddWithValue("@n", l.LectureName);
        cmd.Parameters.AddWithValue("@c", l.LectureDescription);
        cmd.Parameters.AddWithValue("@i", l.instructor);
        cmd.Parameters.AddWithValue("@p", l.PictureUri);
        cmd.Parameters.AddWithValue("@in", l.instructor_name);
        return int.Parse(cmd.ExecuteScalar().ToString());
       

    }
    public void DeleteStudent(int Id)
    {
        SqlConnection conn = connect.GetConnnect();
        string q = "DELETE FROM Lectures WHERE Id=@id";
        SqlCommand cmd = new SqlCommand(q, conn);
        cmd.Parameters.AddWithValue("@id", Id);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public void UpdateStudent(Lectures l)
    {
        SqlConnection conn = connect.GetConnnect();
        string q = "UPDATE Lectures SET LectureName=@n,LectureDescription=@c,PictureUri=@p,course_id=@i,instructor_name=@in WHERE Id=@id";
        SqlCommand cmd = new SqlCommand(q, conn);
        conn.Open();

        cmd.Parameters.AddWithValue("@n", l.LectureName);
        cmd.Parameters.AddWithValue("@c", l.LectureDescription);
        cmd.Parameters.AddWithValue("@i", l.instructor);
        cmd.Parameters.AddWithValue("@p", l.PictureUri);
        cmd.Parameters.AddWithValue("@id", l.Id);
        cmd.Parameters.AddWithValue("@in", l.instructor_name);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public DataSet GetStudents(string id)
    {
        SqlConnection conn = connect.GetConnnect();
        string q = "SELECT * FROM Lectures where course_id=(Select course_id from course where instructor_id2='"+id+"') ";
        SqlCommand cmd = new SqlCommand(q,conn );
        System.Data.DataSet ds = new System.Data.DataSet();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        adapt.Fill(ds);
        return ds;
    }
    public DataSet GetStudents()
    {
        SqlConnection conn = connect.GetConnnect();
        string q = "SELECT * FROM Lectures ";
        SqlCommand cmd = new SqlCommand(q, conn);
        System.Data.DataSet ds = new System.Data.DataSet();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        adapt.Fill(ds);
        return ds;
    }
    public DataSet GetVideo(int id)
    {
        SqlConnection conn = connect.GetConnnect();
        string q = "SELECT PictureUri from Lectures where Id="+id;
        SqlCommand cmd = new SqlCommand(q, conn);
        System.Data.DataSet ds = new System.Data.DataSet();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        adapt.Fill(ds);
        return ds;
    }
    public Lectures GetStudent(int Id)
    {
        SqlConnection conn = connect.GetConnnect();
        Lectures l = new Lectures();
        string q = "SELECT * FROM Lectures WHERE Id=@id";
        SqlCommand cmd = new SqlCommand(q, conn);

        cmd.Parameters.AddWithValue("@id", Id);
        System.Data.DataSet ds = new System.Data.DataSet();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);

        adapt.Fill(ds);
        System.Data.DataRow d = ds.Tables[0].Rows[0];
       l.LectureName = d["LectureName"].ToString();
        l.Id = Id;
        l.LectureDescription = d["LectureDescription"].ToString();
        l.PictureUri = d["PictureUri"].ToString();
        
        return l;

    }
}