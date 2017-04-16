using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;  
   
public partial class UploadMarks: System.Web.UI.Page
{

    public void Page_Load(object sender, EventArgs e)
    {
        MarksDAL mdal = new MarksDAL();
        try
        {
            this.Master.name.Text = Session["User"].ToString();
        }
        catch (Exception ex)
        {
            Response.Redirect("index.aspx");
        }
        int id = Convert.ToInt32(Session["Marks_Key"]);

        DataSet ds1 = mdal.CheckMarksUploaded(id);
        if (ds1.Tables[0].Rows.Count > 0)
        {
            lblError.ForeColor = System.Drawing.Color.Green;
            btnSubmit.Visible = false;
            lblError.Text = "Marks Already Uploaded";
        }
        else
        {
            DataTable dt = new DataTable();


            StringBuilder htmlTable = new StringBuilder();



            DataSet ds = mdal.getData(id);


            htmlTable.Append("<table border='1' id='Table1' class='table-hover' width='500px' height='80'>");
            htmlTable.Append("<tr style='background-color:green; color: White; '><th  style='text-align:center'>Student ID</th><th style='text-align:center'>Student Name</th><th style='text-align:center'>Enter Marks (out of 100)</th></tr>");
            int j = 1000;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                htmlTable.Append("<tr style='color: black;'>");
                htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Student_id"] + "</td>");
                htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Student_Name"] + "</td>");
                htmlTable.Append("<td> <input runat='server' type='text' id=" + i + " name=" + i + "</td>");




                htmlTable.Append("</tr>");



            }
            htmlTable.Append("</table>");
            DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });
             if(ds.Tables[0].Rows.Count == 0)
             {
                 DBDataPlaceHolder.Visible = false;
                 lblError.ForeColor = System.Drawing.Color.Green;
                 btnSubmit.Visible = false;
                 lblError.Text = "There are no Students Currently Registered for Course";
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
   

    
 public void btnSubmit_Click(object sender, EventArgs e)
    {
        MarksDAL mdal = new MarksDAL();
        int id = Convert.ToInt32(Session["Marks_Key"]);
        DataSet ds = mdal.getData(id);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
              {
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            try
            {
                int marks = Convert.ToInt32(String.Format("{0}", Request.Form["" + i + "</td"]));
                if (marks > 100)
                {
                    lblError.Text = "Incorrect Marks Entered";
                  
                    break;
                }
                else if (marks == null)
                {
                    lblError.Text = "Marks Columns is blank";
                 
                    break;

                }

                int course_id = Convert.ToInt32(dr["Course_id"]);
                int student_id = Convert.ToInt32(ds.Tables[0].Rows[i]["Student_id"]);

                MarksDAL mdale = new MarksDAL();
                mdale.AddMarks(student_id, course_id, marks);
                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "Succesfully Entered Marks";
                DBDataPlaceHolder.Visible = false;
                btnSubmit.Visible = false;
            }
            catch (Exception ex)
            {
                lblError.Text = "Succesfully Entered Marks";

            }
          
                
            
        }
    }
    
}