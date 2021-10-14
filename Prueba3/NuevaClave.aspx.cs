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
    public partial class NuevaClave : System.Web.UI.Page
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

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection cnx = new SqlConnection(stringConexion);
            string consultaSql = "UPDATE Usuarios SET Password='" + txtPassword.Text + "' WHERE Rut='" + txtRut.Text + "' ";
            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(consultaSql, cnx);
            if (cmd2.ExecuteNonQuery() > 0)
            {
                Page.Response.Write("<script>alert('" + "Contraseña actualizada" + "');</script>");
                Response.Redirect("Login.aspx");
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

    }
}
