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
    public partial class Registro : System.Web.UI.Page
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
        protected void Registro_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(stringConexion);
            string consultaSql = "insert into Usuarios Values('" + txtRut.Text + "','" + txtNombre.Text + "','" + txtEdad.Text + "','" + txtPassword.Text + "')";
            SqlCommand cmd = new SqlCommand(consultaSql, cnx);
            cnx.Open();
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                   
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Error al registrar intente de nuevo" + "');</script>");
                }
                cnx.Close();
            }
            catch (SqlException ex)
            {
                Page.Response.Write("<script>alert('" + "Error al realizar el registro intente de nuevo" + "');</script>");  
            }
        }
    }
}
