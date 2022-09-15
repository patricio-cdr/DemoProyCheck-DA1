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
    public class PacienteADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        // Metodos de mantenimiento
        public Boolean InsertarPaciente(PacienteBE objPacienteBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarPaciente";
            cmd.Parameters.Clear();

            //Agregamos parametros 
            try
            {
                cmd.Parameters.AddWithValue("@vNom", objPacienteBE.NomPaciente);
                cmd.Parameters.AddWithValue("@vApe", objPacienteBE.ApePaciente);
                cmd.Parameters.AddWithValue("@vFNac", objPacienteBE.FechaNacimiento);
                cmd.Parameters.AddWithValue("@vDni", objPacienteBE.DniPaciente);
                cmd.Parameters.AddWithValue("@vSexo", objPacienteBE.Sexo);
                cmd.Parameters.AddWithValue("@vDir", objPacienteBE.DirecPaciente);
                cmd.Parameters.AddWithValue("@vSang", objPacienteBE.TipoSangre);
                cmd.Parameters.AddWithValue("@vFoto", objPacienteBE.FotoPaciente);
                cmd.Parameters.AddWithValue("@vEmail", objPacienteBE.EmailPaciente);
                cmd.Parameters.AddWithValue("@vFIngr", objPacienteBE.FechaIngreso);
                cmd.Parameters.AddWithValue("@vTelef", objPacienteBE.NumTelefono);
                cmd.Parameters.AddWithValue("@vEsta", objPacienteBE.Estado);
                cmd.Parameters.AddWithValue("@vTipo", objPacienteBE.TipoCliente);
                cmd.Parameters.AddWithValue("@vCEmpr", objPacienteBE.CodEmpresa);
                cmd.Parameters.AddWithValue("@vUsu_Reg", objPacienteBE.Usu_registro);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objPacienteBE.Id_ubigeo);

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


        public Boolean ActualizarPaciente(PacienteBE objPacienteBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarPaciente";
            cmd.Parameters.Clear();

            //Agregamos parametros 
            try
            {
                cmd.Parameters.AddWithValue("@vCod", objPacienteBE.CodPaciente);
                cmd.Parameters.AddWithValue("@vNom", objPacienteBE.NomPaciente);
                cmd.Parameters.AddWithValue("@vApe", objPacienteBE.ApePaciente);
                cmd.Parameters.AddWithValue("@vFNac", objPacienteBE.FechaNacimiento);
                cmd.Parameters.AddWithValue("@vDni", objPacienteBE.DniPaciente);
                cmd.Parameters.AddWithValue("@vSexo", objPacienteBE.Sexo);
                cmd.Parameters.AddWithValue("@vDir", objPacienteBE.DirecPaciente);
                cmd.Parameters.AddWithValue("@vSang", objPacienteBE.TipoSangre);
                cmd.Parameters.AddWithValue("@vFoto", objPacienteBE.FotoPaciente);
                cmd.Parameters.AddWithValue("@vEmail", objPacienteBE.EmailPaciente);
                cmd.Parameters.AddWithValue("@vFIngr", objPacienteBE.FechaIngreso);
                cmd.Parameters.AddWithValue("@vTelef", objPacienteBE.NumTelefono);
                cmd.Parameters.AddWithValue("@vEsta", objPacienteBE.Estado);
                cmd.Parameters.AddWithValue("@vTipo", objPacienteBE.TipoCliente);
                cmd.Parameters.AddWithValue("@vCEmpr", objPacienteBE.CodEmpresa);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objPacienteBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objPacienteBE.Id_ubigeo);

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


        public Boolean EliminarPaciente(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarPaciente";
            cmd.Parameters.Clear();

            //Agregamos parametros 
            try
            {
                cmd.Parameters.AddWithValue("@vCod", strcod);
                
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

        public PacienteBE ConsultarPaciente(String strCod)
        {
            PacienteBE objPacienteBE = new PacienteBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarPaciente";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vCod", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPacienteBE.CodPaciente = dtr["codPaciente"].ToString();
                    objPacienteBE.NomPaciente = dtr["nomPaciente"].ToString();
                    objPacienteBE.ApePaciente = dtr["apePaciente"].ToString();
                    objPacienteBE.FechaNacimiento = (DateTime)dtr["fechaNacimiento"];
                    objPacienteBE.DniPaciente = dtr["dniPaciente"].ToString();
                    objPacienteBE.Sexo = Convert.ToInt16(dtr["sexo"]);
                    objPacienteBE.DirecPaciente = dtr["direcPaciente"].ToString();
                    objPacienteBE.TipoSangre = dtr["tipoSangre"].ToString();
                    objPacienteBE.FotoPaciente = dtr["fotoPaciente"].ToString();
                    objPacienteBE.EmailPaciente = dtr["emailPaciente"].ToString();
                    objPacienteBE.FechaIngreso = (DateTime)dtr["fechaIngreso"];
                    objPacienteBE.NumTelefono = dtr["numTelefono"].ToString();
                    objPacienteBE.Estado = Convert.ToInt16(dtr["estado"]);
                    objPacienteBE.TipoCliente = Convert.ToInt16(dtr["tipoCliente"]);
                    objPacienteBE.CodEmpresa = dtr["codEmpresa"].ToString();
                    objPacienteBE.Fec_reg = (DateTime)dtr["Fec_reg"];
                    objPacienteBE.Usu_registro = dtr["Usu_Registro"].ToString();
                    objPacienteBE.Usu_ult_mod = dtr["Usu_Ult_Mod"].ToString();
                    objPacienteBE.Id_ubigeo = dtr["Id_Ubigeo"].ToString();

                }
                dtr.Close();
                return objPacienteBE;

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


        public DataTable ListarPaciente()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarPaciente";
            cmd.Parameters.Clear();
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Pacientes");

                return dts.Tables["Pacientes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ConsultarPacientesXEvaluaciones(String tipCli , Int16 cantEval)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_PacientesEvaluados";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@cantEval", cantEval);
                cmd.Parameters.AddWithValue("@tipCli", tipCli);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PacientesEval");
                return dts.Tables["PacientesEval"];
               

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
