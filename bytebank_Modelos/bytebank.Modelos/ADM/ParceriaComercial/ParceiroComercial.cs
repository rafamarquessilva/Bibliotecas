using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        private AutenticacaoUtil Autenticacao = new AutenticacaoUtil();

        public bool Autenticar(string senha)
        {
            return Autenticacao.ValidarSenha(this.Senha, senha);
        }
    }
}
