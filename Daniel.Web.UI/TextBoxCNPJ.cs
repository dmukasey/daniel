using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace Daniel.Web.UI
{
    public class TextBoxCNPJ : TextBox
    {

        public TextBoxCNPJ()
        {
            base.Text = "Digite seu cnpj";
            base.MaxLength = 18;
            base.Attributes.Add("onkeyup", "{if(this.value.length==2 ||this.value.length==6){this.value += \".\";}if (this.value.length==10){this.value += \"/\";;}if (this.value.length==15){this.value += \"-\";}}");
            base.Attributes.Add("onKeyPress", "{ var tecla = (window.Event) ? event.which : event.keyCode;  if ((tecla > 47 && tecla < 58) || tecla == 8){return true;}else{return false;}}");
        }
    }
}
