using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{
    public static SqlConnection connection;

    #region DB Access Functions

    protected static void OpenConnection()
    {
        try
        {
            // string scon = @"server=Dungetic;Initial Catalog=QLsinhvien;User ID=sa;Password=123456";
            //  string scon = @"server=dungetic;"
            // + "database=Quanlisinhvien;Integrated Security=True;";
            // string scon = @"Data Source=DESKTOP-B8N6V6G\DUNG2;Initial Catalog=QLTV;User ID=sa;password=123456";
            string scon = @"Data Source=DESKTOP-14Q6V0E\HOANG;Initial Catalog=QLCF_14_10;Integrated Security=True";
            if (DB.connection == null)
            {
                DB.connection = new SqlConnection(scon);
            }
            if (DB.connection.State != ConnectionState.Open)
            {
                DB.connection.Open();
                //  MessageBox.Show("Ket noi khong thanh cong");
            }
        }
        catch
        {
           // MessageBox.Show("Ket noi khong thanh cong");
           // Application.Exit();

        }
    }


    protected static void CloseConnection()
    {
        if (DB.connection != null)
        {
            if (DB.connection.State == ConnectionState.Open)
            {
                DB.connection.Close();
            }
        }
    }

    public static SqlCommand BuildCommand(string procedureName, IDataParameter[] parameters)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = procedureName;
        cmd.Connection = DB.connection;
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter parameter in parameters)
        {
            cmd.Parameters.Add(parameter);
        }
        return cmd;
    }

    public static SqlCommand BuildIntCommand(string procedureName, IDataParameter[] parameters)
    {
        SqlCommand cmd = BuildCommand(procedureName, parameters);
        cmd.Parameters.Add(new SqlParameter("ReturnValue",
            SqlDbType.Int,
            4,
            ParameterDirection.ReturnValue,
            false,
            0, 0,
            string.Empty,
            DataRowVersion.Default,
            null));
        return cmd;
    }

    public static int ExecuteIntCommand(string procedureName, IDataParameter[] parameters)
    {
        try
        {
            int returnValue;
            OpenConnection();
            SqlCommand cmd = BuildIntCommand(procedureName, parameters);
            cmd.ExecuteNonQuery();
            returnValue = (int)cmd.Parameters["ReturnValue"].Value;
            CloseConnection();
            return returnValue;
        }
        catch
        {
            throw new Exception("ExecuteIntCommand Error");
        }
    }

    public static SqlDataReader ExecuteReader(string procedureName, IDataParameter[] parameters)
    {
        try
        {
            SqlDataReader returnReader;
            OpenConnection();
            SqlCommand cmd = BuildCommand(procedureName, parameters);
            cmd.CommandType = CommandType.StoredProcedure;
            returnReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            // CloseConnection();
            //CommandBehavior.CloseConnection);
            return returnReader;

        }
        catch (Exception)
        {
            throw new Exception("ExecuteReader Error!");
        }
    }

    public static int ExecuteNonQuery(string procedureName, IDataParameter[] parameters)
    {
        try
        {
            OpenConnection();
            SqlCommand cmd = BuildCommand(procedureName, parameters);
            cmd.CommandType = CommandType.StoredProcedure;
            int rowsAffected = cmd.ExecuteNonQuery();
            CloseConnection();
            return rowsAffected;
        }
        catch (Exception)
        {
            throw new Exception("ExecuteNonQuery Error!");
        }
    }



    public static DataTable ExecuteQuery(string procedureName, IDataParameter[] parameters)
    {
        try
        {
            DataSet dataSet = new DataSet();
            OpenConnection();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildCommand(procedureName, parameters);
            sqlDA.Fill(dataSet);
            CloseConnection();
            return dataSet.Tables[0];
        }
        catch (Exception exp)
        {
            throw exp;
        }
    }

    public static DataSet ExecuteQuery1(string procedureName, IDataParameter[] parameters)
    {
        try
        {
            DataSet dataSet = new DataSet();
            OpenConnection();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildCommand(procedureName, parameters);
            sqlDA.Fill(dataSet);
            CloseConnection();
            return dataSet;
        }
        catch (Exception exp)
        {
            throw exp;
        }
    }

    public static object ExecuteScalar(string procedureName, IDataParameter[] parameters)
    {
        try
        {
            SqlCommand cmd = BuildCommand(procedureName, parameters);
            OpenConnection();
            object retValue = cmd.ExecuteScalar();
            CloseConnection();
            return retValue;
        }
        catch (Exception exp)
        {
            throw new Exception("Execute Scalar Error!", exp);
        }
    }
    #endregion
}