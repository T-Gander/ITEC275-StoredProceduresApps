namespace ITEC275_A01;

using DBCLI;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

public class DataLayer
{
    //Only do Q1 in SQL Server, Q2 in datalayer
    //b231-9\\b2319
    string connectionString = "server=192.168.50.250,1434;database=NwindDB;user id=sa;password=P@ssword!;encrypt=false";
    string masterConnectionString = "server=192.168.50.250,1434;database=master;user id=sa;password=P@ssword!;encrypt=false";

    public bool CheckConnection()
    {
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            conn.Open();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool InstallProcedures()
    {
        bool ret = false;
        DatabaseScript allScripts = new DatabaseScript();
        SqlConnection conn = new SqlConnection(masterConnectionString);

        try
        {
            conn.Open();

            string[] commands = allScripts.CreateDatabaseStoredProceduresScript.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string command in commands)
            {
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            
            ret = true;
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Stored Procedures with the same names are already installed. Install Aborted.");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
        finally
        {
            conn.Close();
        }

        return ret;
    }

    protected bool ExecuteStoredProcedure(string procedure)
    {
        bool ret = false;
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            ret = true;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }

        return ret;
    }

    protected DataTable ExecuteStoredProcedureReturnDataTable(string procedure)
    {
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    protected bool ExecuteStoredProcedureWithParams(string procedure, string[] parameters, object[] info)
    {
        bool ret = false;
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            for(int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameters[i], info[i]);
            }

            cmd.ExecuteNonQuery();
            ret = true;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }

        return ret;
    }

    protected DataTable ExecuteStoredProcedureWithParamsReturnDataTable(string procedure, string[] parameters, object[] info)
    {
        SqlConnection conn = new SqlConnection(connectionString);
        DataTable dt = new DataTable();

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameters[i], info[i]);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

}
