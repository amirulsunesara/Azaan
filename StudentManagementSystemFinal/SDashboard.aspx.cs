using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
public partial class _Default : System.Web.UI.Page
{
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
        CourseDAL cd = new CourseDAL();
        if (!Page.IsPostBack)
        {
            DataSet ds = cd.getOfferedCourse();
            gvCourseRegistration.DataSource = ds;
            gvCourseRegistration.DataBind();
            LoadGridView();
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
    public void LoadGridView()
    {

        LecturesDAL ldal = new LecturesDAL();
        DataSet ds = ldal.GetStudents();
        grdStudents.DataSource = ds;
        grdStudents.DataBind();
    }

    protected void grdStudents_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnk = (LinkButton)e.Row.Cells[4].Controls[1];
            lnk.Click += new EventHandler(Watch_Click);

        }

    }



    public void Watch_Click(object sender, EventArgs e)
    {
        StringBuilder htmlTable = new StringBuilder();
        LecturesDAL ldal = new LecturesDAL();
        GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
        int id = Convert.ToInt32(grdrow.Cells[0].Text);

        DataSet ds = ldal.GetVideo(id);
        DataTable dt = ds.Tables[0];
        DataRow dr = dt.Rows[0];
        string path = dr["PictureUri"].ToString();

        htmlTable.Append(" <iframe width='560' height='315' src='" + path + "' frameborder='0' allowfullscreen></iframe>");
        DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });





    }
}