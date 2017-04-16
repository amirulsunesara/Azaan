using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentFeedback : System.Web.UI.Page
{
    FeedbackDAL d = new FeedbackDAL();
    Variablefeedback v = new Variablefeedback();
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
        d.getcount();
        count.Text = d.count.ToString();
        ins();
        venue();
        vol();
        hosp();
        course();
        registration();
        atmosphere();

    }

    private void atmosphere()
    {
        d.atmosphere(v);
        if (v.asum == 0)
        {

            lbla.Text = "Record not found";
        }
        else if (v.asum == 1)
        {
            lbla.Text = "very poor";
        }
        else if (v.asum == 2)
        {
            lbla.Text = "Poor";
        }
        else if (v.asum == 3)
        {
            lbla.Text = "Satisfactory";
        }
        else if (v.asum == 4)
        {
            lbla.Text = "Good";
        }
        else if (v.asum == 5)
        {
            lbla.Text = "Excellent";
        }
    }
    private void registration()
    {
        d.registration(v);
        if (v.regsum == 0)
        {

            lblr.Text = "Record not found";
        }
        else if (v.regsum == 1)
        {
            lblr.Text = "very poor";
        }
        else if (v.regsum == 2)
        {
            lblr.Text = "Poor";
        }
        else if (v.regsum == 3)
        {
            lblr.Text = "Satisfactory";
        }
        else if (v.regsum == 4)
        {
            lblr.Text = "Good";
        }
        else if (v.regsum == 5)
        {
            lblr.Text = "Excellent";
        }
    }
    private void course()
    {

        d.course(v);
        if (v.coursesum == 0)
        {

            lblc.Text = "Record not found";
        }
        else if (v.coursesum == 1)
        {
            lblc.Text = "very poor";
        }
        else if (v.coursesum == 2)
        {
            lblc.Text = "Poor";
        }
        else if (v.coursesum == 3)
        {
            lblc.Text = "Satisfactory";
        }
        else if (v.coursesum == 4)
        {
            lblc.Text = "Good";
        }
        else if (v.coursesum == 5)
        {
            lblc.Text = "Excellent";
        }
    }
    private void hosp()
    {

        d.getavghosp(v);
        if (v.hospitalitysum == 0)
        {

            lblh.Text = "Record not found";
        }
        else if (v.hospitalitysum == 1)
        {
            lblh.Text = "very poor";
        }
        else if (v.hospitalitysum == 2)
        {
            lblh.Text = "Poor";
        }
        else if (v.hospitalitysum == 3)
        {
            lblh.Text = "Satisfactory";
        }
        else if (v.hospitalitysum == 4)
        {
            lblh.Text = "Good";
        }
        else if (v.hospitalitysum == 5)
        {
            lblh.Text = "Excellent";
        }
    }


    private void ins()
    {
        d.getavginstructor(v);
        if (v.instructorsum == 0)
        {

            lbli.Text = "Record not found";
        }
        else if (v.instructorsum == 1)
        {
            lbli.Text = "very poor";
        }
        else if (v.instructorsum == 2)
        {
            lbli.Text = "Poor";
        }
        else if (v.instructorsum == 3)
        {
            lbli.Text = "Satisfactory";
        }
        else if (v.instructorsum == 4)
        {
            lbli.Text = "Good";
        }
        else if (v.instructorsum == 5)
        {
            lbli.Text = "Excellent";
        }
    }

    private void venue()
    {
        d.getavgvenue(v);
        if (v.venuesum == 0)
        {
            lblv.Text = "Record not found";
        }
        else if (v.venuesum == 1)
        {
            lblv.Text = "very poor";
        }
        else if (v.venuesum == 2)
        {
            lblv.Text = "Poor";
        }
        else if (v.venuesum == 3)
        {
            lblv.Text = "Satisfactory";
        }
        else if (v.venuesum == 4)
        {
            lblv.Text = "Good";
        }
        else if (v.venuesum == 5)
        {
            lblv.Text = "Excellent";
        }
    }
    private void vol()
    {
        d.getavgvol(v);
        if (v.volsum == 0)
        {
            lblvol.Text = "Record not found";
        }
        else if (v.volsum == 1)
        {
            lblvol.Text = "very poor";
        }
        else if (v.volsum == 2)
        {
            lblvol.Text = "Poor";
        }
        else if (v.volsum == 3)
        {
            lblvol.Text = "Satisfactory";
        }
        else if (v.volsum == 4)
        {
            lblvol.Text = "Good";
        }
        else if (v.volsum == 5)
        {
            lblvol.Text = "Excellent";
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

        Response.Redirect("Profile.aspx");
    }

    protected void Messages_Click(object sender, EventArgs e)
    {

        Response.Redirect("Message.aspx");
    }
    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Index.aspx");
    }
}