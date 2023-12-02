using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebCinestar.db
{
    public class Db
    {
        public Db(string v)
        {
        }

        SqlConnection cn; = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;

        public Db(string cnn)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnn].ConnectionString );
            cmd = new SqlCommand("", cn);
        }


        internal void Sentencia(string sql)
        {
            cmd = new SqlCommand(sql, cn);

            
        }
        internal DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);
            return dt;
        }
        internal DataRow GetDataRow()
        {
            DataTable dt = getDataTable();
            if ( dt != null || dt.Rows.Count > 0 )
                return getDataTable().Rows[0];

            return null;
        }
    }
}