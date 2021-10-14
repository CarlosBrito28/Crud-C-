using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Prueba3
{
    public partial class MantenedorDeUsuarios : System.Web.UI.Page
    {

        StringBuilder errorMessages = new StringBuilder();

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dadtr;
        DataSet dts;
        string stringConexion = "Data Source=DESKTOP-48T6K75;Initial Catalog = Medicamentos; Integrated Security = True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection cnx = new SqlConnection(stringConexion);
            string consultaSql = "select Nombre,Edad,Password from Usuarios Where Rut='" + txtRut.Text + "'";
            cnx.Open();
            SqlCommand cmd = new SqlCommand(consultaSql, cnx);
            dtr = cmd.ExecuteReader();
            if (dtr.Read())
            {
                txtNombre.Text = dtr.GetString(0);
                txtEdad.Text = dtr.GetInt32(1).ToString();
                txtPassword.Text = dtr.GetString(2);
            }
            else
            {
                Page.Response.Write("<script>alert('" + "Datos No Encontrados" + "');</script>");
            }
            cnx.Close();
        }
            catch (SqlException error)
            {
                Response.Write("El error fue:" + error.Message);
            }
        }


        
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection(stringConexion);
                string consultaSql = "update Usuarios set Nombre='" + txtNombre.Text + "',Edad=" + txtEdad.Text + ",Password='" + txtPassword.Text + "' Where Rut='" + txtRut.Text + "'";
                cnx.Open();
                SqlCommand cmd2 = new SqlCommand(consultaSql, cnx);
                if (cmd2.ExecuteNonQuery() > 0)
                {
                    Page.Response.Write("<script>alert('" + "Datos Actualizados " + "');</script>");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Datos No Actualizados" + "');</script>");
                }
                cnx.Close();
            }
            catch (SqlException error)
            {
                Response.Write("El error fue:" + error.Message);
            }
        }


    
    protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection(stringConexion);
                string consultaSql = "delete from Usuarios Where Rut='" + txtRut.Text + "'";
                cnx.Open();
                SqlCommand cmd = new SqlCommand(consultaSql, cnx);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Page.Response.Write("<script>alert('" + "Registro Eliminado" + "');</script>");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Problemas al eliminar el Registro" + "');</script>");
                }
                cnx.Close();
            }
            catch (SqlException error)
            {
                Response.Write("El error fue:" + error.Message);
            }
        }


    }
}

