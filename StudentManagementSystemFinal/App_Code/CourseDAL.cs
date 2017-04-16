using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for CourseDAL
/// </summary>
public class CourseDAL
{
    Conn connect = new Conn();
    public void addCourse(Course c , string id)
    {
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("insert into course(course_name,instructor_id2) values( '" + c.CourseName +"','"+id+"') ", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    public DataSet getOfferedCourse()
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select  course_id AS 'Course Id',course_name AS 'Course',instructor_fname + ' ' +instructor_lname AS 'Instructor Name' FROM Course INNER JOIN Instructor ON course.instructor_id2 = instructor.instructor_id", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
    public DataSet getOfferedCourse(int sid, int cid)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select  course_id AS 'Course Id',course_name AS 'Course',instructor_fname + ' ' +instructor_lname AS 'Instructor Name' FROM Course INNER JOIN Instructor ON course.instructor_id2 = instructor.instructor_id where course_id=(select course_id from registration where student_id='" + sid + "' AND course_id='"+cid+"')", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;

    }
   
}