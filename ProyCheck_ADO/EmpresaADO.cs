using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos
using System.Data;
using System.Data.SqlClient;
using ProyCheck_BE;

namespace ProyCheck_ADO
{
    public class EmpresaADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        // Metodos de mantenimiento
        public Boolean InsertarEmpresa(EmpresaBE objEmpresaBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarEmpresa";
            cmd.Parameters.Clear();

            //Agregamos parametros 
            try
            {
                cmd.Parameters.AddWithValue("@VRaz_soc_empl", objEmpresaBE.Raz_soc_emp);
                cmd.Parameters.AddWithValue("@VDir_emp", objEmpresaBE.Dir_emp);
                cmd.Parameters.AddWithValue("@VTel_emp", objEmpresaBE.Tel_emp);
                cmd.Parameters.AddWithValue("@VRuc_emp", objEmpresaBE.Ruc_emp);
                cmd.Parameters.AddWithValue("@VRep_emp", objEmpresaBE.Rep_emp);
                cmd.Parameters.AddWithValue("@VId_ubigeo", objEmpresaBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Vestado", objEmpresaBE.Estado);
                cmd.Parameters.AddWithValue("@vUsu_Reg", objEmpresaBE.Usu_registro);


                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }


        public Boolean ActualizarEmpresa(EmpresaBE objEmpresaBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarEmpresa";
            cmd.Parameters.Clear();

            //Agregamos parametros 
            try
            {
                cmd.Parameters.AddWithValue("@VcodEmpresa", objEmpresaBE.CodEmpresa);
                cmd.Parameters.AddWithValue("@VRaz_soc_emp", objEmpresaBE.Raz_soc_emp);
                cmd.Parameters.AddWithValue("@VDir_emp", objEmpresaBE.Dir_emp);
                cmd.Parameters.AddWithValue("@VTel_emp", objEmpresaBE.Tel_emp);
                cmd.Parameters.AddWithValue("@VRuc_emp", objEmpresaBE.Ruc_emp);
                cmd.Parameters.AddWithValue("@VRep_emp", objEmpresaBE.Rep_emp);
                cmd.Parameters.AddWithValue("@VId_ubigeo", objEmpresaBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Vestado", objEmpresaBE.Estado);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objEmpresaBE.Usu_ult_mod);

                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }


        public Boolean EliminarEmpresa(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarEmpresa";
            cmd.Parameters.Clear();

            //Agregamos parametros 
            try
            {
                cmd.Parameters.AddWithValue("@VcodEmpresa", strcod);

                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public EmpresaBE ConsultarEmpresa(String strCod)
        {
            EmpresaBE objEmpresaBE = new EmpresaBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarEmpresa";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@VcodEmpresa", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpresaBE.CodEmpresa = dtr["codEmpresa"].ToString();
                    objEmpresaBE.Raz_soc_emp = dtr["Raz_soc_emp"].ToString();
                    objEmpresaBE.Dir_emp = dtr["Dir_emp"].ToString();
                    objEmpresaBE.Tel_emp = dtr["Tel_emp"].ToString();
                    objEmpresaBE.Ruc_emp = dtr["Ruc_emp"].ToString();
                    objEmpresaBE.Rep_emp = dtr["Rep_emp"].ToString();
                    objEmpresaBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objEmpresaBE.Fec_Ingreso = Convert.ToDateTime(dtr["fec_Ingreso"]);
                    objEmpresaBE.Estado = Convert.ToInt16(dtr["estado"]);
                    objEmpresaBE.Fec_reg = Convert.ToDateTime(dtr["Fec_reg"]);
                    objEmpresaBE.Usu_registro = dtr["Usu_Registro"].ToString();
                    //objEmpresaBE.Fec_ult_mod = Convert.ToDateTime(dtr["Fec_Ult_Mod"]);
                    objEmpresaBE.Usu_ult_mod = dtr["Usu_Ult_Mod"].ToString();                   

                }
                dtr.Close();
                return objEmpresaBE;

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

        public DataTable ListarEmpresa()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarEmpresa";
            cmd.Parameters.Clear();
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empresas");

                return dts.Tables["Empresas"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarEmpresaxUbicacion(String dep, String prov, String dist)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EmpresaxUbicacion";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@departamento", dep);
                cmd.Parameters.AddWithValue("@provincia", prov);
                cmd.Parameters.AddWithValue("@distrito", dist);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "EmpresaxUbicacion");

                return dts.Tables["EmpresaxUbicacion"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
