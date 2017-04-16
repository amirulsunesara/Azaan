using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Specialized;

public partial class _Default : System.Web.UI.Page
{
    CourseDAL cd = new CourseDAL();
    
    public void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.Master.name.Text = Session["User"].ToString();
        }
        catch (Exception ex)
        {
            Response.Redirect("index.aspx");
        }
       
        DataSet ds = cd.getOfferedCourse();   
        gvCourseRegistration.DataSource = ds;
        gvCourseRegistration.DataBind();
     
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        this.Master.LogOutButton.Click += new EventHandler(LogoutButton_Click);
        this.Master.LBtn.ServerClick += new EventHandler(Messages_Click);
        this.Master.Profilee.ServerClick += new EventHandler(Profilee_Click);
    }
    protected void Profilee_Click(object sender, EventArgs e)
    {

        Response.Redirect("SProfile.aspx");
    }

    protected void Messages_Click(object sender, EventArgs e)
    {

        Response.Redirect("SMessage.aspx");
    }
    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Index.aspx");
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
      

        foreach (GridViewRow row in gvCourseRegistration.Rows)
        {

            CheckBox cb = (CheckBox)row.FindControl("RegisterThis");
            if (cb != null && cb.Checked)
            {

                int id = Convert.ToInt32(gvCourseRegistration.DataKeys[row.RowIndex].Value);
                int cid = Convert.ToInt32(row.Cells[1].Text);
               RegistrationDAL rdal = new RegistrationDAL();
                 string email = Session["Course_Key"].ToString();
                  DataSet sid= rdal.getStudent(email);
               

                             DataTable dt = sid.Tables[0];
                             DataRow dr = dt.Rows[0];

                             int stdid = (int)dr["Student_id"];
                             string fname = dr["first_name"].ToString();
                             string lname = dr["last_name"].ToString();
                             string name = fname + ' '+lname;
                             try
                             {
                                 rdal.RegisterCourse(cid, stdid, name);
                                 gvCourseRegistration.Visible = false;
                                 btnRegister.Visible = false;
                                 heading1.InnerText = "Course has been Successfully registered";
                                   
                             }
                             catch (Exception ex)
                             {
                                
                                 lblAlready.Text = "  Course Already Registered";
                               
                             }
      

            }

        }
      
        


    }
}