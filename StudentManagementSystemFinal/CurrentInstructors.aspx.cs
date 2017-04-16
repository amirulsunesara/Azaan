using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CurrentInstructors : System.Web.UI.Page
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
        InstructorsDAL ld = new InstructorsDAL();
        DataSet ds = ld.getInstructors();
        gvInstructors.DataSource = ds;
        gvInstructors.DataBind();
        lblNo.Visible = false;
        if(ds.Tables[0].Rows.Count == 0)
        {
            btnDelete.Visible = false;
        lblNo.Visible = true;
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
   

   
    protected void btnDelete_Click(object sender, EventArgs e)
    {
       

      
        foreach (GridViewRow row in gvInstructors.Rows)
        {
       
            CheckBox cb = (CheckBox)row.FindControl("DeleteSelector");
            if (cb != null && cb.Checked)
            {
              
                int id = Convert.ToInt32(gvInstructors.DataKeys[row.RowIndex].Value);
                InstructorsDAL idal = new InstructorsDAL();
                idal.DeleteInstructor(id);
                InstructorsDAL ld = new InstructorsDAL();
                DataSet ds = ld.getInstructors();
                gvInstructors.DataSource = ds;
                gvInstructors.DataBind();
               
               
            }
         
        }

        
      

    }



    protected void gvInstructors_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}