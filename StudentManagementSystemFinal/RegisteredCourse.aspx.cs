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
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.Master.name.Text = Session["User"].ToString();
        }
        catch (Exception ex)
        {
            Response.Redirect("index.aspx");
        }
        int sid = Convert.ToInt32(Session["Feedback_Key"]); 

//        DataSet ds = cd.getOfferedCourse(sid);

        ComposeDAL sdal = new ComposeDAL();
      

     

            ListItemCollection lic = new ListItemCollection();
            int id = Convert.ToInt32(Session["Feedback_Key"]);
            int count = sdal.getMultiple(id);
            DataTable dt2 = new DataTable();
            dt2.Columns.Add(new DataColumn("Course Id", typeof(int)));
            dt2.Columns.Add(new DataColumn("Course", typeof(string)));
            dt2.Columns.Add(new DataColumn("Instructor Name", typeof(string)));
            if (count > 0)
            {
                for (int i = 1; i < 1000; i++)
                {
                    DataSet ds = cd.getOfferedCourse(id, i);
                    DataTable dt = ds.Tables[0];
                    try
                    {
                        DataRow dr = dt.Rows[0];
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                           
                            
                            DataRow dr3 = dt2.NewRow();
                            dr3["Course id"] = Convert.ToInt32(dr["Course id"]);
                            dr3["Course"] = dr["Course"].ToString();
                            dr3["Instructor Name"] = dr["Instructor Name"].ToString();
                            dt2.Rows.Add(dr3);
                        }
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }

                }

            }
               
          
                gvCourse.DataSource = dt2;
                gvCourse.DataBind();
            
           
           
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

    protected void gvCourse_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnk = (LinkButton)e.Row.Cells[3].Controls[1];
            lnk.Click += new EventHandler(lbDRegister_Click);
           
        }

    }



    public void lbDRegister_Click(object sender, EventArgs e)
    {

        foreach (GridViewRow row in gvCourse.Rows)
        {


            int cid = Convert.ToInt32(row.Cells[0].Text);
            RegistrationDAL cdal = new RegistrationDAL();
            cdal.DeRegisterCourse(cid);
            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }

}