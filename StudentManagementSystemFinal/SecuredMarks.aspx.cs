using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class _Default : System.Web.UI.Page
{
    MarksDAL fdal = new MarksDAL();
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
      
        DataSet ds = fdal.getAllData(sid);
        if (ds.Tables[0].Rows.Count > 1)
        {
            if (!IsPostBack)
            {
                ddCourse.DataSource = ds;
                ddCourse.DataValueField = "Course_id";
                ddCourse.DataTextField = "Course_id";

                ddCourse.DataBind();
            }
        }
        else if (ds.Tables[0].Rows.Count == 1)
        {
            ddCourse.Visible = false;
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            string marks = dr["marks"].ToString();

            lblMarks.Text = "You Secured "+marks+"/100 ";
        }
        else 
        {
         
            ddCourse.Visible = false;
            lblMarks.Text = "Marks will upload soon";
        }
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
    protected void ddCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(ddCourse.SelectedValue);
        int sid = Convert.ToInt32(Session["Feedback_Key"]);
        DataSet ds = fdal.getAllData(sid,cid);
        DataTable dt = ds.Tables[0];
        DataRow dr = dt.Rows[0];
        string marks = dr["marks"].ToString();

        lblMarks.Text = "You Secured " + marks + "/100 ";
    }
}