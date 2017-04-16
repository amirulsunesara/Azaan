using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
public partial class UploadLectures : System.Web.UI.Page
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
        if (!Page.IsPostBack)
        {
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

        Response.Redirect("IProfile.aspx");
    }

    protected void Messages_Click(object sender, EventArgs e)
    {

        Response.Redirect("IMessage.aspx");
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
        string id = Session["Marks_Key"].ToString();
        DataSet ds = ldal.GetStudents(id);
        grdStudents.DataSource = ds;
        grdStudents.DataBind();
    }
    protected void AddStdnt_Click(object sender, EventArgs e)
    {
        Lectures l = new Lectures();
        LecturesDAL ldal = new LecturesDAL();

        try
        {
            l.LectureName = Request.Form["s_name"].ToString();
            l.instructor = Session["Lecture_Key"].ToString();
            l.LectureDescription = Request.Form["s_contact"].ToString();
            l.instructor_name = Session["User"].ToString();
        }
        catch (Exception)
        {


        }
        l.Id = ldal.AddStudent(l);
        string filePath = string.Format("images/{0}.{1}", l.Id, s_file.PostedFile.FileName.Substring(s_file.PostedFile.FileName.LastIndexOf('.') + 1));
        s_file.SaveAs(Server.MapPath(filePath));
        l.PictureUri = filePath;
        ldal.UpdateStudent(l);
        LoadGridView();
    }
    protected void grdStudents_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnk = (LinkButton)e.Row.Cells[3].Controls[1];
           lnk.Click += new EventHandler(Watch_Click);
            Button btn = (Button)e.Row.Cells[4].Controls[1];
      
            
             btn.Click += new EventHandler(btnDelete_Click);
        }

    }
   /** protected void Watch_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        StringBuilder htmlTable = new StringBuilder();
        LecturesDAL ldal = new LecturesDAL();
        if (e.CommandName.CompareTo("Watchme") == 0 )
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            string Id = lnkView.CommandArgument;
            int id = Convert.ToInt32(Id);
            DataSet ds = ldal.GetVideo(id);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
           string path = dr["PictureUri"].ToString();

            htmlTable.Append(" <iframe width='560' height='315' src='" + path + "' frameborder='0' allowfullscreen></iframe>");
            DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });

        }
    }**/



    public void Watch_Click(object sender, EventArgs e)
    {
        StringBuilder htmlTable = new StringBuilder();
          LecturesDAL ldal = new LecturesDAL();
          GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
          int id = Convert.ToInt32(grdrow.Cells[0].Text);
      //    foreach (GridViewRow row in grdStudents.Rows)
        //  {

             
          
            
          //   int id = Convert.ToInt32(row.Cells[0].Text);
              DataSet ds = ldal.GetVideo(id);
              DataTable dt = ds.Tables[0];
              DataRow dr = dt.Rows[0];
              string path = dr["PictureUri"].ToString();

              htmlTable.Append(" <iframe width='560' height='315' src='" + path + "' frameborder='0' allowfullscreen></iframe>");
              DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            
       //   }
        

        
    }
    public void btnDelete_Click(object sender, EventArgs e)
    {

        foreach (GridViewRow row in grdStudents.Rows)
        {
            LecturesDAL ldal = new LecturesDAL();
          int id = Convert.ToInt32(row.Cells[0].Text);
           ldal.DeleteStudent(id);
           Response.Redirect(Request.Url.AbsoluteUri);

        }
    }
}