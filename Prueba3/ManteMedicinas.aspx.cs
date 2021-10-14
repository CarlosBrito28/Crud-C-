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
    public partial class ManteMedicinas : System.Web.UI.Page
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dat;
        DataSet dts;
        string cadena = "Data Source=DESKTOP-48T6K75;Initial Catalog = Medicamentos; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection(cadena);
                cnx.Open();

                SqlCommand cmd = new SqlCommand("sp_Insertar_Medicamentos", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@Nom", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Pre", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@Cant", txtStock.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Page.Response.Write("<script>alert('" + "Registro Realizado" + "');</script>");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Problemas al registrar" + "');</script>");
                }
                cnx.Close();
                cmd.Dispose();
                cnx.Dispose();
            }
            catch (SqlException error)
            {
                Response.Write("El error fue:" + error.Message);
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection(cadena);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("sp_Buscar_Medicamento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod", txtCodigo.Text);

                dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    txtNombre.Text = dtr.GetString(1);
                    txtPrecio.Text = dtr.GetValue(2).ToString();
                    txtStock.Text = dtr.GetInt32(3).ToString();
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Medicina No encontrada" + "');</script>");
                }
                cnx.Close();
                cmd.Dispose();
                cnx.Dispose();
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
                SqlConnection cnx = new SqlConnection(cadena);
                cnx.Open();

                SqlCommand cmd = new SqlCommand("sp_Eliminar_Medicamento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod", txtCodigo.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Page.Response.Write("<script>alert('" + "Medicina eliminada" + "');</script>");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "No se pudo eliminar" + "');</script>");
                }
                cnx.Close();
                cmd.Dispose();
                cnx.Dispose();
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
                SqlConnection cnx = new SqlConnection(cadena);
                cnx.Open();

                SqlCommand cmd = new SqlCommand("sp_Modificar_Medicamento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@Nom", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Pre", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@Cant", txtStock.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Page.Response.Write("<script>alert('" + "Datos Modificados" + "');</script>");
                }
                else
                {
                    Page.Response.Write("<script>alert('" + "Problemas al Modificar" + "');</script>");
                }
                cnx.Close();
                cmd.Dispose();
                cnx.Dispose();
            }
            catch (SqlException error)
            {
                Response.Write("El error fue:" + error.Message);
            }
        }
    }
}