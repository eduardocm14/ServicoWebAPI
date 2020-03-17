using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicoWebAPI.Models;
using ServicoWebAPI.Util;

namespace ServicoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        Autenticacao AutenticacaoServico;

        public ClientesController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autenticacao(context);
        }

        // GET: Todos Clientes
        [HttpGet]
        [Route("listagem")]
        public List<Cliente> Listagem()
        {
            return new Cliente().PesquisarAll();
        }

        // GET: Por codigo de Cliente
        [HttpGet]
        [Route("listagem/{id}")]
        public Cliente RetornarCliente(int id)
        {                       
            return new Cliente().PesquisarCodigo(id);
        }

        // POST: api/Conexao
        [HttpPost]
        [Route("registrar")]
        public ReturnAllService Registrar([FromBody] Cliente cliente)
        {
            ReturnAllService retorno = new ReturnAllService();

            try
            {
                cliente.Cadastrar();
                retorno.Result = true;
                retorno.ErrorMessage = "Cliente cadastrado com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao cadastrar cliente: " + ex.Message;
            }

            return retorno;
        }

        // PUT: api/Conexao
        [HttpPut]
        [Route("atualizar/{id}")]
        public ReturnAllService Atualizar(int id, [FromBody] Cliente cliente)
        {
            ReturnAllService retorno = new ReturnAllService();

            try
            {
                cliente.Id = id;
                cliente.Atualizar();
                retorno.Result = true;
                retorno.ErrorMessage = "Cliente atualizado com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao atualizar cliente: " + ex.Message;
            }

            return retorno;
        }

        // DELETE: api/Conexao/5
        [HttpDelete]
        [Route("excluir/{id}")]
        public ReturnAllService Excluir(int id)
        {
            ReturnAllService retorno = new ReturnAllService();

            try
            {
                AutenticacaoServico.Autenticar();
                new Cliente().Excluir(id);

                retorno.Result = true;
                retorno.ErrorMessage = "Cliente excluído com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao Excluir cliente: " + ex.Message;
            }

            return retorno;

        }
    }
}
