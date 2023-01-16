using System;

namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    internal class AutenticacaoUtil
    {
        internal bool ValidarSenha(string senhaverdadeira, string senhatentativa)
        {
            return senhatentativa.Equals(senhaverdadeira);
        }
    }
}
