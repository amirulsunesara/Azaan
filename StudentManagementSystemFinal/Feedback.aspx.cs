using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Feedback : System.Web.UI.Page
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
        int sid = Convert.ToInt32(Session["Feedback_Key"]);
        FeedbackDAL fdal = new FeedbackDAL();
        DataSet ds = fdal.GetAll(sid);
        if (ds.Tables[0].Rows.Count > 0)
        {

            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            string a = Session["Feedback_Key"].ToString(); 
            string b= dr["student_id"].ToString();
            if (a == b)
            {
                pnlFeedback.Visible = false;
                lblSubmitted.Text = "Feedback Already Submitted";
            }
           
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
    Variablefeedback v = new Variablefeedback();
    protected void Button1_Click(object sender, EventArgs e)
    {
        instructor();
        venue();
        volunteer();
        hospitality();
        course();
        registration();
        atmosphere();
        /*   v.instructor = 1;
          v.venue = 2;
          v.Volunteer = 4;
          v.hospitality = 5;
          v.course = 1;
          v.registration = 2;
          v.atmosphere = 5;*/
        FeedbackDAL d = new FeedbackDAL();
        int sid = Convert.ToInt32(Session["Feedback_Key"]);
        d.Addfeedback(v ,sid);



    }


    public void instructor()
    {


        if (II1.Checked) { v.instructor = 1; }

        else if (II2.Checked) { v.instructor = 2; }
        else if (II3.Checked) { v.instructor = 3; }
        else if (II4.Checked) { v.instructor = 4; }
        else if (II5.Checked) { v.instructor = 5; }
    }

    public void venue()
    {
        if (V1.Checked) { v.venue = 1; }
        else if (V2.Checked) { v.venue = 2; }
        else if (V3.Checked) { v.venue = 3; }
        else if (V4.Checked) { v.venue = 4; }
        else if (V5.Checked) { v.venue = 5; }

    }
    public void volunteer()
    {
        if (Vol1.Checked) { v.Volunteer = 1; }
        else if (Vol2.Checked) { v.Volunteer = 2; }
        else if (Vol3.Checked) { v.Volunteer = 3; }
        else if (vol4.Checked) { v.Volunteer = 4; }
        else if (Vol5.Checked) { v.Volunteer = 5; }
    }
    public void hospitality()
    {
        if (H1.Checked) { v.hospitality = 1; }
        else if (H2.Checked) { v.hospitality = 2; }
        else if (H3.Checked) { v.hospitality = 3; }
        else if (H4.Checked) { v.hospitality = 4; }
        else if (H5.Checked) { v.hospitality = 5; }
    }
    public void course()
    {
        if (c1.Checked) { v.course = 1; }
        else if (c2.Checked) { v.course = 2; }
        else if (c3.Checked) { v.course = 3; }
        else if (c4.Checked) { v.course = 4; }
        else if (c5.Checked) { v.course = 5; }
    }
    public void registration()
    {
        if (R1.Checked) { v.registration = 1; }
        else if (R2.Checked) { v.registration = 2; }
        else if (R3.Checked) { v.registration = 3; }
        else if (R4.Checked) { v.registration = 4; }
        else if (R5.Checked) { v.registration = 5; }

    }
    public void atmosphere()
    {
        if (A1.Checked) { v.atmosphere = 1; }
        else if (A2.Checked) { v.atmosphere = 2; }
        else if (A3.Checked) { v.atmosphere = 3; }
        else if (A4.Checked) { v.atmosphere = 4; }
        else if (A5.Checked) { v.atmosphere = 5; }
    }


}