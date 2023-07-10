using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary
{
    public interface IUsuario
    {
        bool Logar();

        bool ResetPassword();
    }
}
