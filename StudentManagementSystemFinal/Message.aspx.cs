using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;  
public partial class Message : System.Web.UI.Page
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
        ComposeDAL cdal = new ComposeDAL();
        btnDelete.Visible = true;
        btnDelete2.Visible = false;
        DataSet ds = cdal.GetMessage(Session["User"].ToString());
        gvMessage.DataSource = ds;
        gvMessage.DataBind();
        lblEmpty.Visible = false;
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblEmpty.Visible = true;
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


    protected void btnSentMails_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<br/><br/>");
        DBDataPlaceHolder.Controls.Add(new Literal { Text = sb.ToString() });
        btnDelete.Visible = false;
        btnDelete2.Visible = false;
        ComposeDAL cdal = new ComposeDAL();
        DataSet ds = cdal.GetSentMessage(Session["User"].ToString());
        gvMessage.DataSource = ds;
        gvMessage.DataBind();
        gvMessage.Columns[1].Visible = false;
        gvMessage.Columns[0].Visible = false;
        lblEmpty.Visible = false;
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblEmpty.Visible = true;
        }

    }
    protected void btnInbox_Click(object sender, EventArgs e)
    {
        gvMessage.Columns[1].Visible = true;
        gvMessage.Columns[0].Visible = true;
        ComposeDAL cdal = new ComposeDAL();
        btnDelete.Visible = true;
        btnDelete2.Visible = false;
        DataSet ds = cdal.GetMessage(Session["User"].ToString());
        gvMessage.DataSource = ds;
        gvMessage.DataBind();
        lblEmpty.Visible = false;
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblEmpty.Visible = true;
        }

    }
    protected void btnCompose_Click(object sender, EventArgs e)
    {
        Response.Redirect("Compose.aspx");

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {

        foreach (GridViewRow row in gvMessage.Rows)
        {

            CheckBox cb = (CheckBox)row.FindControl("DeleteSelector");
            if (cb != null && cb.Checked)
            {

                int id = Convert.ToInt32(gvMessage.DataKeys[row.RowIndex].Value);
                ComposeDAL cdal = new ComposeDAL();
                cdal.DeleteMessage(id);
            }

        }
        ComposeDAL cdall = new ComposeDAL();
        DataSet ds = cdall.GetMessage(Session["User"].ToString());
        gvMessage.DataSource = ds;
        gvMessage.DataBind();
        lblEmpty.Visible = false;
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblEmpty.Visible = true;
        }



    }

    protected void btnDelete2_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gvMessage.Rows)
        {

            CheckBox cb = (CheckBox)row.FindControl("DeleteSelector");
            if (cb != null && cb.Checked)
            {

                int id = Convert.ToInt32(gvMessage.DataKeys[row.RowIndex].Value);
                ComposeDAL cdal = new ComposeDAL();
                cdal.DeleteMessage(id);


            }

        }
        ComposeDAL cdall = new ComposeDAL();
        DataSet ds = cdall.GetSentMessage(Session["User"].ToString());
        gvMessage.DataSource = ds;
        gvMessage.DataBind();
        gvMessage.Columns[1].Visible = false;
        lblEmpty.Visible = false;
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblEmpty.Visible = true;
        }



    }
    protected void gvMessage_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnk = (LinkButton)e.Row.Cells[1].Controls[1];
            lnk.Click += new EventHandler(Reply_Click);

        }

    }



    public void Reply_Click(object sender, EventArgs e)
    {

        foreach (GridViewRow row in gvMessage.Rows)
        {


            string cid = row.Cells[3].Text;
            Session["getme"] = cid;
            Response.Redirect("Compose.aspx");

        }
    }
}