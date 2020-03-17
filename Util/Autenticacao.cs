using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoWebAPI.Util
{
    public class Autenticacao
    {
        public static string TOKEN = "123qwe123asd123zxc";
        public static string FALHA_AUTENTICACAO = "Falha na Autenticação[Token informado é inválido]";
        readonly IHttpContextAccessor contextAccessor;

        public Autenticacao(IHttpContextAccessor pContext)
        {
            contextAccessor = pContext;
        }

        public void Autenticar()
        {
            try
            {
                string TokenRecebido = contextAccessor.HttpContext.Request.Headers["Token"].ToString();

                if (!string.Equals(TOKEN, TokenRecebido))
                {
                    throw new Exception(FALHA_AUTENTICACAO);
                }                
            }
            catch (Exception)
            {
                throw new Exception(FALHA_AUTENTICACAO);
            }
        }
    }
}
