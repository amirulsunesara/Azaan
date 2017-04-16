using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for DAL
/// </summary>
public class FeedbackDAL
{
    //  Variablefeedback v = new Variablefeedback();
    public int count { get; set; }
    public int instructorsum { get; set; }
    Conn c = new Conn();
    
    public void Addfeedback(Variablefeedback v,int sid)
    {
        SqlConnection sqlcon = c.GetConnnect();
        SqlCommand cmd = new SqlCommand("insert into feedback values ('"+sid+"','" + v.instructor + "','" + v.venue + "','" + v.Volunteer + "','" + v.hospitality + "','" + v.course + "','" + v.registration + "','" + v.atmosphere + "')", sqlcon);
        sqlcon.Open();
        cmd.ExecuteNonQuery();
        sqlcon.Close();
    }
    public DataSet GetAll(int sid)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = c.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from feedback where student_id="+sid, conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public void getcount()
    {

        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("select COUNT (*) from feedback", sqlcon);
        cmd.ExecuteNonQuery();

        count = Convert.ToInt32(cmd.ExecuteScalar());
        sqlcon.Close();


    }
    public void getavginstructor(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("select AVG (instructor) from feedback", sqlcon);
        cmd.ExecuteNonQuery();
        v.instructorsum = Convert.ToDecimal(cmd.ExecuteScalar());
    }
    public void getavgvenue(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("  select AVG (venue) from feedback ", sqlcon);
        cmd.ExecuteNonQuery();
        v.venuesum = Convert.ToDecimal(cmd.ExecuteScalar());

    }
    public void getavgvol(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("  select AVG (Volunteer) from feedback ", sqlcon);
        cmd.ExecuteNonQuery();
        v.volsum = Convert.ToDecimal(cmd.ExecuteScalar());
    }
    public void getavghosp(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("  select AVG (Hospitality) from feedback  ", sqlcon);
        cmd.ExecuteNonQuery();
        v.hospitalitysum = Convert.ToDecimal(cmd.ExecuteScalar());
    }
    public void course(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("  select AVG (course) from feedback   ", sqlcon);
        cmd.ExecuteNonQuery();
        v.coursesum = Convert.ToDecimal(cmd.ExecuteScalar());
    }
    public void registration(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("select AVG (Registration) from feedback", sqlcon);
        cmd.ExecuteNonQuery();
        v.regsum = Convert.ToDecimal(cmd.ExecuteScalar());
    }
    public void atmosphere(Variablefeedback v)
    {
        SqlConnection sqlcon = c.GetConnnect();
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand(" select AVG (Atmosphere) from feedback   ", sqlcon);
        cmd.ExecuteNonQuery();
        v.asum = Convert.ToDecimal(cmd.ExecuteScalar());
    }
}