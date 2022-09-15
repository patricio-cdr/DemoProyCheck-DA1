using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyCheck_ADO
{
    public class AnalisisADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ConsultarAnalisis(String strEstado)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarAnalisis";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vEstado", strEstado);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "AnalisisCliente");
                return dts.Tables["AnalisisCliente"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAnalisis()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarAnalisis";
            cmd.Parameters.Clear();
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Analisis");

                return dts.Tables["Analisis"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
