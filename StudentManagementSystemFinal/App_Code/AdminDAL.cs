using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for AdminDAL
/// </summary>
public class AdminDAL
{
    Conn connect = new Conn();
    public DataSet getDetails(int id) 
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("select * from administrator where admin_id='"+id+"'", conn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        adpt.Fill(ds);
        return ds;
    
    }
    public void UpdateAdmin(Administrator a , int id)
    {
    
        SqlConnection conn = connect.GetConnnect();
        SqlCommand cmd = new SqlCommand("Update administrator SET admin_password='"+a.password+"',email='"+a.email+"',admin_fname='"+a.fname+"',admin_lname='"+a.lname+"'  where admin_id='" + id + "'", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    
    }
}