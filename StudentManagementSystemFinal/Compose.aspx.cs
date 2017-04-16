using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Compose : System.Web.UI.Page
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
        lblSent.Visible = false;
        if (!IsPostBack)
        {
            if(Session["getme"] != null)
            {
                Label1.Text = "";
               
                ddPerson.Visible = false;
                ddReciever.Visible = false;
               
            
            }

            ListItemCollection lic = new ListItemCollection();

            lic.Insert(0, new ListItem("Select Person", "-1"));
            lic.Insert(1, new ListItem("To Instructor", "-2"));
            lic.Insert(2, new ListItem("To Student", "-3"));
        
            ddPerson.DataSource = lic;
            ddPerson.DataValueField = "value";
            ddPerson.DataTextField = "Text";
            ddPerson.DataBind();
            
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
    public bool isFormGood()
    {

        bool returnval = false;

        if(ddPerson.SelectedValue == "-1")
        {
            lbldd.Text = "Please Select Person";
            returnval = false;
        }
        else
        {
            lbldd.Text = "";
           returnval = true;
        }
        if (txtSubject.Text.Length == 0)
        {
            lblSubject.Text = "Please Enter Subject ";
            returnval = false;
        }
        else
        {
            lblSubject.Text = "";
            returnval = true;
        }
        if (txtMessage.Text.Length == 0)
        {
            lblMessage.Text = "Please Enter Message ";
            returnval = false;
        }
        else
        {
            lblMessage.Text = "";
            returnval = true;
        }
        if (txtMessage.Text.Length == 0 || txtSubject.Text.Length == 0 || ddPerson.SelectedValue == "-1")
        {
         
            returnval = false;
        }
        else
        {

            returnval = true;
        }

        return returnval;
    }
    public bool isFormGood2()
    {

        bool returnval = false;

      
        if (txtSubject.Text.Length == 0)
        {
            lblSubject.Text = "Please Enter Subject ";
            returnval = false;
        }
        else
        {
            lblSubject.Text = "";
            returnval = true;
        }
        if (txtMessage.Text.Length == 0)
        {
            lblMessage.Text = "Please Enter Message ";
            returnval = false;
        }
        else
        {

            lblMessage.Text = "";
            returnval = true;
        }
        if (txtMessage.Text.Length == 0 || txtSubject.Text.Length == 0 )
        {

            returnval = false;
        }
        else
        {

            returnval = true;
        }

        return returnval;
    }
    public void doSignup()
    {

        Composer su = new Composer();
        ComposeDAL ldal = new ComposeDAL();
       
            su.subject = txtSubject.Text;
            su.message = txtMessage.Text;
            su.sender = Session["User"].ToString();
            su.reciever = ddReciever.SelectedValue;
            ldal.addMessage(su);
            lbldd.Visible = false;
            lblMessage.Visible = false;
            lblSubject.Visible = false;
            ddPerson.Visible = false;
            ddReciever.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            txtMessage.Visible = false;
            txtSubject.Visible = false;
            btnBack.Visible = false;
            btnSend.Visible = false;
            Label1.Visible = false;
            lblSent.Visible = true;


    }


    protected void ddPerson_SelectedIndexChanged(object sender, EventArgs e)
    {
      
            ComposeDAL sdal = new ComposeDAL();
            if (ddPerson.SelectedValue == "-1") 
            {

                ddReciever.Items.Clear();
            }

            else if (ddPerson.SelectedValue == "-2")
            {

                ddReciever.DataSource = sdal.GetInstructorName();

                ddReciever.DataTextField = "Instructor Name";
                ddReciever.DataValueField = "Instructor Name";
                ddReciever.DataBind();
            }
            else if (ddPerson.SelectedValue == "-3")
            {

                ddReciever.DataSource = sdal.GetStudentName();

                ddReciever.DataTextField = "Student Name";
                ddReciever.DataValueField = "Student Name";
                ddReciever.DataBind();
            }
            else
            {

                //label error here
            }
        }





    protected void btnSend_Click1(object sender, EventArgs e)
    {
        if (Session["getme"] != null)
        {
            if (isFormGood2())
            {
                Composer su = new Composer();
                ComposeDAL ldal = new ComposeDAL();

                su.subject = txtSubject.Text;
                su.message = txtMessage.Text;
                su.sender = Session["User"].ToString();
                su.reciever = Session["getme"].ToString();
                ldal.addMessage(su);
                Session["getme"] = null;
                lbldd.Visible = false;
                lblMessage.Visible = false;
                lblSubject.Visible = false;
                ddPerson.Visible = false;
                ddReciever.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                txtMessage.Visible = false;
                txtSubject.Visible = false;
                btnBack.Visible = false;
                btnSend.Visible = false;
                Label1.Visible = false;
                lblSent.Visible = true;
       
            }
        }
        else if (isFormGood())
        {
            doSignup();
        }

    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Session["getme"] = null;
        Response.Redirect("Message.aspx");
       

    }
}