

using System.Data;
using System.Data.SqlClient;

namespace EmloyeeMenegmentF;

public class Functions
{
    private SqlConnection Con;
    private SqlCommand Cmd;
    private DataTable dt;
    private SqlDataAdapter sda;
    private string ConStr;
    public Functions()
    {
        ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmloyeeDb.mdf;Integrated Security=True;Connect Timeout=30";
        Con = new SqlConnection(ConStr);
        Cmd = new SqlCommand();
        Cmd.Connection = Con;

    }
    public DataTable GetData(string Query)
    {
        dt = new DataTable();
        sda = new SqlDataAdapter(Query, ConStr);
        sda.Fill(dt);
        return dt;
    }

    public int SetData(string Query)
    {
        int cnt = 0;
        if (Con.State == ConnectionState.Closed)
        {
            Con.Open();
        }
        Cmd.CommandText = Query;
        cnt = Cmd.ExecuteNonQuery();
        return cnt;

    }



}




//internal class Function
//{
//    private SqlConnection Con;
//    private SqlCommand cmd;
//    private DataTable dt;
//    private SqlDataAdapter sda;
//    private string ConStr;

//    public Function()
//    {
//        ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmloyeeDb.mdf;Integrated Security=True;Connect Timeout=30";
//        Con = new SqlConnection(ConStr);
//        cmd = new SqlCommand();
//        cmd.Connection = Con;
//    }

//    public DataTable GetData(string Query)
//    {
//        dt = new DataTable();
//        sda = new SqlDataAdapter(Query, ConStr);
//        sda.Fill(dt);
//        return dt;
//    }

//    public int SetData(string Query)
//    {
//        int cnt = 0;
//        if (Con.State == ConnectionState.Closed)
//        {
//            Con.Open();
//        }
//        cmd.CommandText = Query;
//        cnt = cmd.ExecuteNonQuery();
//        return cnt;
//    }
//}

