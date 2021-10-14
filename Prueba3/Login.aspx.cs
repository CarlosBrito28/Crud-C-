using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Prueba3
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dadtr;
        DataSet dts;
       int ContadorIntento=0;
        string stringConexion = "Data Source=DESKTOP-48T6K75;Initial Catalog = Medicamentos; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Contador"]) == null)
            {
                Session["Contador"] = 0;
            } 
        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection cnx = new SqlConnection(stringConexion);
            string consultaSql = "SELECT * FROM Usuarios WHERE Nombre='" + txtNombre.Text + "' AND Password='" + txtPassword.Text + "'";
            cnx.Open();
            SqlCommand cmd = new SqlCommand(consultaSql, cnx);
            dtr = cmd.ExecuteReader();
            if (dtr.Read())
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Session["Contador"]  = ((int)Session["Contador"])+ 1;

                if ( ((int)Session["Contador"]) == 4) {
                    Session["Contador"] = 0;
                    Response.Redirect("RecuperacionDePassword.aspx");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Datos De Usuario no encontrado"+ "tienes Oportunidades" + (3- (int)Session["Contador"]) +"');</script>");
                }
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