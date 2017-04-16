using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Conn
/// </summary>
public class Conn
{

    public SqlConnection GetConnnect() 
    {
        string connector = System.Configuration.ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        SqlConnection connect = new SqlConnection(connector);
        return connect;
    
    }
}