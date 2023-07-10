namespace BusinessLayerLibrary
{
    public class Fornecedor : Pessoa, IUsuario
    {
       
        public bool Logar()
        {
            if (Login == "daniel" && Senha == "1234")
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