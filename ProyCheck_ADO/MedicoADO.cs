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
    public class MedicoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;


        public Boolean InsertarMedico(MedicoBE objMedicoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarMedico";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@dniMedic", objMedicoBE.DniMedic);
                cmd.Parameters.AddWithValue("@nomMedico", objMedicoBE.NomMedico);
                cmd.Parameters.AddWithValue("@apeMedico", objMedicoBE.ApeMedico);
                cmd.Parameters.AddWithValue("@numColegiatura", objMedicoBE.NumColegiatura);
                cmd.Parameters.AddWithValue("@fechaNacimiento", objMedicoBE.FechaNacimiento);
                cmd.Parameters.AddWithValue("@emailMedico", objMedicoBE.EmailMedico);
                cmd.Parameters.AddWithValue("@fotoMedico", objMedicoBE.FotoMedico);
                cmd.Parameters.AddWithValue("@direcMedico", objMedicoBE.DirecMedico);
                cmd.Parameters.AddWithValue("@estado", objMedicoBE.Estado);
                cmd.Parameters.AddWithValue("@codEspecialidad", objMedicoBE.CodEspecialidad);
                cmd.Parameters.AddWithValue("@Login_Usuario", objMedicoBE.Login_usuario);
                cmd.Parameters.AddWithValue("@Usu_Registro", objMedicoBE.Usu_registro);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objMedicoBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@fec_ingreso", objMedicoBE.Fec_ingreso);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }   
            finally
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarMedico(MedicoBE objMedicoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarMedico";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@vCodMedico", objMedicoBE.CodMedico);
                cmd.Parameters.AddWithValue("@dniMedic", objMedicoBE.DniMedic);
                cmd.Parameters.AddWithValue("@nomMedico", objMedicoBE.NomMedico);
                cmd.Parameters.AddWithValue("@apeMedico", objMedicoBE.ApeMedico);
                cmd.Parameters.AddWithValue("@numColegiatura", objMedicoBE.NumColegiatura);
                cmd.Parameters.AddWithValue("@fechaNacimiento", objMedicoBE.FechaNacimiento);
                cmd.Parameters.AddWithValue("@emailMedico", objMedicoBE.EmailMedico);
                cmd.Parameters.AddWithValue("@fotoMedico", objMedicoBE.FotoMedico);
                cmd.Parameters.AddWithValue("@direcMedico", objMedicoBE.DirecMedico);
                cmd.Parameters.AddWithValue("@estado", objMedicoBE.Estado);
                cmd.Parameters.AddWithValue("@codEspecialidad", objMedicoBE.CodEspecialidad);
                cmd.Parameters.AddWithValue("@Login_Usuario", objMedicoBE.Login_usuario);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objMedicoBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objMedicoBE.Id_ubigeo);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
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

        public MedicoBE ConsultarMedico(String strCCod)
        {
            MedicoBE objMedicoBE = new MedicoBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarMedico";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vCodMedico", strCCod);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objMedicoBE.CodMedico = dtr["codMedico"].ToString();
                    objMedicoBE.DniMedic = dtr["dniMedic"].ToString();
                    objMedicoBE.NomMedico = dtr["nomMedico"].ToString();
                    objMedicoBE.ApeMedico = dtr["apeMedico"].ToString();
                    objMedicoBE.NumColegiatura = dtr["numColegiatura"].ToString();
                    objMedicoBE.FechaNacimiento = (DateTime)dtr["fechaNacimiento"];
                    objMedicoBE.EmailMedico = dtr["emailMedico"].ToString();
                    objMedicoBE.FotoMedico = dtr["fotoMedico"].ToString();
                    objMedicoBE.DirecMedico = dtr["direcMedico"].ToString();
                    objMedicoBE.Estado = Convert.ToInt16(dtr["estado"]);
                    objMedicoBE.DescEstado = dtr["descEstado"].ToString();
                    objMedicoBE.CodEspecialidad = dtr["codEspecialidad"].ToString();
                    objMedicoBE.NomEspecialidad = dtr["nomEspecialidad"].ToString();
                    objMedicoBE.Login_usuario = dtr["Login_usuario"].ToString();
                    objMedicoBE.Fech_reg = (DateTime)dtr["Fec_Reg"];
                    objMedicoBE.Usu_registro = dtr["Usu_Registro"].ToString();
                    
                    objMedicoBE.Usu_ult_mod = dtr["Usu_Ult_Mod"].ToString();
                    objMedicoBE.Id_ubigeo = dtr["Id_Ubigeo"].ToString();
                    objMedicoBE.NomUbigeo = dtr["nomUbigeo"].ToString();
                    objMedicoBE.Fec_ingreso = (DateTime)dtr["fec_ingreso"];

                    // objMedicoBE.Fech_ult_mod = (DateTime)dtr["Fech_Ult_Mod"];

                }
                dtr.Close();
                return objMedicoBE;
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

        public DataTable ListarMedico()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarMedico";
            cmd.Parameters.Clear();
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Medicos");

                return dts.Tables["Medicos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPacientesxMedico(String strCod, DateTime fecini)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_PacienteAtendidosxMedico";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@cod", strCod);
                cmd.Parameters.AddWithValue("@fecini", fecini);

                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PacientesxMedico");

                return dts.Tables["PacientesxMedico"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
