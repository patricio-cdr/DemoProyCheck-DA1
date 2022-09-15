using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyCheck_BE;

namespace ProyCheck_ADO
{
    public class UsuarioADO
    {

        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strLogin)
        {   
            UsuarioBE objUsuario = new UsuarioBE();
            cnx.ConnectionString = Miconexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuario";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@vLogin", strLogin);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    dtr.Read();

                    objUsuario.Login_usu = dtr["Login_Usuario"].ToString();
                    objUsuario.Password_usu = dtr["Pass_Usuario"].ToString();
                    objUsuario.Nivel_usu = (int) dtr["Niv_Usuario"];
                    objUsuario.Est_usu = (int) dtr["Est_Usuario"];
                    objUsuario.Fec_registro = (DateTime) dtr["Fec_Registro"];
                    objUsuario.Usu_registro = dtr["Usu_Registro"].ToString();
                }

                dtr.Close();
                return objUsuario;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
