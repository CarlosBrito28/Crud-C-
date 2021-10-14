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
    public partial class RecuperacionDePassword : System.Web.UI.Page
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

        protected void RecuperarPassword_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection cnx = new SqlConnection(stringConexion);
            string consultaSql = "select Nombre,Edad,Rut from Usuarios Where Nombre='"+txtNombre.Text+"' AND Edad='"+txtEdad.Text+"' AND Rut='" + txtRut.Text + "'";
            cnx.Open();
            SqlCommand cmd = new SqlCommand(consultaSql, cnx);
            dtr = cmd.ExecuteReader();
            if (dtr.Read())
            {
                Response.Redirect("NuevaClave.aspx");
            }
            else
            {

                Page.Response.Write("<script>alert('" + "Datos No encontrado" + "');</script>");
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
