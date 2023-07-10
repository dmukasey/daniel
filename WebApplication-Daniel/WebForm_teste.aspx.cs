using BusinessLayerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_Daniel
{
    public partial class WebForm_teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            //if (txt_user.Text == "daniel" && txt_pass.Text == "1234")
            //    Response.Redirect("default.aspx");
            //else
            //    lbl_mensagem.Text = "Erro no login";

            if (rbl_tipo.Items[0].Selected)
            {
                Fornecedor fornec = new Fornecedor();
                fornec.Login = txt_user.Text;
                fornec.Senha = txt_pass.Text;
                if (EfetuarLogin(fornec)==true) //true não é necessário, por padrão já estaria subentendido
                    Response.Redirect("default.aspx");
                else
                    lbl_mensagem.Text = "Erro no login";


            }
            else
            {
                Cliente client = new Cliente();
                client.Login = txt_user.Text;
                client.Senha = txt_pass.Text;
                if (EfetuarLogin(client)==true)
                    Response.Redirect("default.aspx");
                else
                    lbl_mensagem.Text = "Erro no login";
            }
        }

        private bool EfetuarLogin(IUsuario usuario)
        {
            if (usuario.GetType() == typeof(BusinessLayerLibrary.Cliente))
                return ((BusinessLayerLibrary.Cliente)usuario).Logar();  //CAST  conversão explicita 

            else if (usuario.GetType() == typeof(BusinessLayerLibrary.Fornecedor))
                return ((BusinessLayerLibrary.Fornecedor)usuario).Logar();

            else 
                return false;
          
        }
    }
}