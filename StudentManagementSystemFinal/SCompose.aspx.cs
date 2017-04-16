using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
        if (!IsPostBack)
        {
            if (Session["getme"] != null)
            {
                Label1.Text = "";

                ddPerson.Visible = false;
                ddReciever.Visible = false;


            }

            ListItemCollection lic = new ListItemCollection();

            lic.Insert(0, new ListItem("Select Person", "-1"));
            lic.Insert(1, new ListItem("To Instructor", "-2"));
            lic.Insert(2, new ListItem("To Administrator", "-3"));

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
    public bool isFormGood()
    {

        bool returnval = false;

        if (ddPerson.SelectedValue == "-1")
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
        if (txtMessage.Text.Length == 0 || txtSubject.Text.Length == 0)
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

            ListItemCollection lic = new ListItemCollection();
            int id = Convert.ToInt32(Session["Feedback_Key"]);
            int count = sdal.getMultiple(id);
            if(count > 1)
            {
                int j = 0;
                int k = -1;
                for(int i=1 ; i<1000 ; i++)
                {
                        DataSet ds = sdal.Check(id,i);
                        DataTable dt = ds.Tables[0];
                        try
                        {
                            DataRow dr = dt.Rows[0];
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                int course_id = Convert.ToInt32(dr["course_id"]);
                                DataSet ds2 = sdal.GetInstructorName(course_id);
                                DataTable dt2 = ds2.Tables[0];
                                DataRow dr2 = dt2.Rows[0];
                                string name = dr2["Instructor Name"].ToString();
                                string temp = k.ToString();
                                lic.Insert(j, new ListItem(name, temp));
                                j++;
                                k--;
                            }
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                       
                }
                ddReciever.DataSource = lic;
                ddReciever.DataTextField = "Text";
                ddReciever.DataValueField = "Text";
                ddReciever.DataBind();
            
            }
            else 
            {
            ddReciever.DataSource = sdal.GetInstructorName();
            ddReciever.DataTextField = "Instructor Name";
            ddReciever.DataValueField = "Instructor Name";
            ddReciever.DataBind();
            
            }
           
          
          

           

          
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
        Response.Redirect("SMessage.aspx");


    }
}