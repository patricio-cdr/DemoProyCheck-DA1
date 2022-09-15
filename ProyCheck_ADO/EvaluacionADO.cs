using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyCheck_BE;

namespace ProyCheck_ADO
{
    public class EvaluacionADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarEvaluacion(EvaluacionBE objEvaluacionBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarEvaluacion";
            cmd.Parameters.Clear();

            try
            {

                cmd.Parameters.AddWithValue("@vFecEva",objEvaluacionBE.Fec_eva);
                cmd.Parameters.AddWithValue("@vEstado", objEvaluacionBE.Estado);
                cmd.Parameters.AddWithValue("@vCodMedico", objEvaluacionBE.Cod_medico);
                cmd.Parameters.AddWithValue("@vCodAuditor", objEvaluacionBE.Cod_auditor);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objEvaluacionBE.Usu_registro);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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

        public Boolean ActualizarEvaluacion(EvaluacionBE objEvaluacionBE)
        {

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarEvaluacion";
            cmd.Parameters.Clear();

            try
            {

                cmd.Parameters.AddWithValue("@vCodEva",objEvaluacionBE.Cod_evaluacion);
                cmd.Parameters.AddWithValue("@vFecEva", objEvaluacionBE.Fec_eva);
                cmd.Parameters.AddWithValue("@vEstado", objEvaluacionBE.Estado);
                cmd.Parameters.AddWithValue("@vCodMedico", objEvaluacionBE.Cod_medico);
                cmd.Parameters.AddWithValue("@vCodAuditor", objEvaluacionBE.Cod_auditor);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objEvaluacionBE.Usu_ult_mod);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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

        public Boolean EliminarEvaluacion(String strCod)
        {

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarEvaluacion";
            cmd.Parameters.Clear();

            try
            {

                cmd.Parameters.AddWithValue("@vCod", strCod);
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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

        public EvaluacionBE ConsultarEvaluacion(String strCod)
        {
            EvaluacionBE objEvaluacionBE = new EvaluacionBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarEvaluacion";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@vCod",strCod);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    dtr.Read();

                    objEvaluacionBE.Nombre_pac = dtr["Nombre_Paciente"].ToString();
                    objEvaluacionBE.Apellido_pac = dtr["Apellido_Paciente"].ToString();
                    objEvaluacionBE.Fec_nac = dtr["Fecha_Nacimiento"].ToString();
                    objEvaluacionBE.Edad = (int)dtr["Edad"];
                    objEvaluacionBE.Dni_paciente = dtr["dniPaciente"].ToString();
                    objEvaluacionBE.Lugar_trabajo = dtr["Lugar_de_trabajo"].ToString();
                    objEvaluacionBE.Tipo_examen = dtr["Tipo_Examen"].ToString();
                    objEvaluacionBE.Fec_eva = (DateTime)dtr["Fecha_Evaluacion"];
                    objEvaluacionBE.Peso_paciente = (float)dtr["Peso_Paciente_Kg"];
                    objEvaluacionBE.Sangre = dtr["sangre"].ToString();
                    objEvaluacionBE.Orina = dtr["orina"].ToString();
                    objEvaluacionBE.Ekg = dtr["ekg"].ToString();
                    objEvaluacionBE.Spirometria = dtr["spirometria"].ToString();
                    objEvaluacionBE.Psicologia = dtr["psicologia"].ToString();
                    objEvaluacionBE.RayosX = dtr["rayosX"].ToString();
                    objEvaluacionBE.Audicion = dtr["audicion"].ToString();
                    objEvaluacionBE.Vista = dtr["vista"].ToString();
                    objEvaluacionBE.Recomendaciones = dtr["recomendaciones"].ToString();
                    objEvaluacionBE.Nom_med_eva = dtr["Nombre_Medico_Evaluador"].ToString();
                    objEvaluacionBE.Ape_med_eva = dtr["Apellidos_Medico_Evaluador"].ToString();
                    objEvaluacionBE.Nom_med_aud = dtr["Nombre_Medico_Auditor"].ToString();
                    objEvaluacionBE.Ape_med_aud = dtr["Apellido_Medico_Auditor"].ToString();
                }

                dtr.Close();
                return objEvaluacionBE;
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

        public DataTable ListarEvaluacion()
        {

            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarEvaluaciones";
            cmd.Parameters.Clear();

            try
            {

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Evaluaciones");

                return dts.Tables["Evaluaciones"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
