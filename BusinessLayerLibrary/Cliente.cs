using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary
{
    public class Cliente : Pessoa, IUsuario
    {
        public bool Logar()
        {
            if (Login == "david" && Senha == "9876")
                return true;
            else
                return false;
        }

        public bool ResetPassword()
        {
            return true;            
        }
    }
}
