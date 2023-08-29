using BusinessLayerLibrary;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_Daniel
{
    public partial class Grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            DataSet ds = forn.Listar();

            
            gridFornecedores.DataSource = ds; 
            gridFornecedores.DataBind();


            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "usuario";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }
    }
}