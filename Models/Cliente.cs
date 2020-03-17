using ServicoWebAPI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoWebAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data_Cadastro { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Data_Nascimento { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }   
        public string Cidade { get; set; }
        public string UF { get; set; }

        readonly DAL objDAL = new DAL();

        string sql = string.Empty;

        public void Cadastrar()
        {            

            sql = "INSERT INTO cliente(nome, data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email, cep, logradouro, numero, bairro, complemento, cidade, uf) " +
                  $"VALUES('{Nome}','{DateTime.Now.ToString("yyyy-MM-dd")}','{Cpf_Cnpj}','" +
                  $"{DateTime.Parse(Data_Nascimento).ToString("yyyy/MM/dd")}','" +
                  $"{Tipo}','{Telefone}','{Email}','{Cep}','{Logradouro}','{Numero}'," +
                  $"'{Bairro}','{Complemento}','{Cidade}','{UF}')";

            objDAL.ExecutarInsertUpDateDelete(sql);
        }


        public void Atualizar()
        {

            sql =  "UPDATE cliente SET " +
                   $"nome = '{Nome}', " +
                   $"data_cadastro = '{DateTime.Now.ToString("yyyy-MM-dd")}', " +
                   $"cpf_cnpj = '{Cpf_Cnpj}', " +
                   $"data_nascimento = '{DateTime.Parse(Data_Nascimento).ToString("yyyy/MM/dd")}', " +
                   $"tipo = '{Tipo}', " +
                   $"telefone = '{Telefone}', " +
                   $"email = '{Email}', " +
                   $"cep = '{Cep}', " +
                   $"logradouro = '{Logradouro}', " +
                   $"numero = '{Numero}', " +
                   $"bairro = '{Bairro}', " +
                   $"complemento = '{Complemento}', " +
                   $"cidade = '{Cidade}', " +
                   $"uf= '{UF}' where id = {Id}";
               
            objDAL.ExecutarInsertUpDateDelete(sql);
        }       

        public void Excluir(int id)
        {            
            sql = $"DELETE FROM cliente WHERE id={id}";

            objDAL.ExecutarInsertUpDateDelete(sql);
        }

        public List<Cliente> PesquisarAll()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            sql = "SELECT * FROM cliente ORDER BY 1";

            DataTable dados = objDAL.RetornarDataTable(sql);

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                Cliente cliente = new Cliente()
                {
                    Id = int.Parse(dados.Rows[i]["id"].ToString()),
                    Nome = dados.Rows[i]["Nome"].ToString(),
                    Data_Cadastro = dados.Rows[i]["Data_Cadastro"].ToString(),
                    Cpf_Cnpj = dados.Rows[i]["Data_Nascimento"].ToString(),
                    Data_Nascimento = dados.Rows[i]["Data_Nascimento"].ToString(),
                    Tipo = dados.Rows[i]["Tipo"].ToString(),
                    Telefone = dados.Rows[i]["Telefone"].ToString(),
                    Email = dados.Rows[i]["Email"].ToString(),
                    Cep = dados.Rows[i]["Cep"].ToString(),
                    Logradouro = dados.Rows[i]["Logradouro"].ToString(),
                    Numero = dados.Rows[i]["Numero"].ToString(),
                    Bairro = dados.Rows[i]["Bairro"].ToString(),
                    Cidade = dados.Rows[i]["Cidade"].ToString(),
                    UF = dados.Rows[i]["UF"].ToString()
                };

                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        public Cliente PesquisarCodigo(int id)
        {
            
            sql = $"SELECT * FROM cliente where id = {id}";

            DataTable dados = objDAL.RetornarDataTable(sql);

            Cliente cliente = new Cliente()
            {
                Id = int.Parse(dados.Rows[0]["id"].ToString()),
                Nome = dados.Rows[0]["Nome"].ToString(),
                Data_Cadastro = dados.Rows[0]["Data_Cadastro"].ToString(),
                Cpf_Cnpj = dados.Rows[0]["Data_Nascimento"].ToString(),
                Data_Nascimento = dados.Rows[0]["Data_Nascimento"].ToString(),
                Tipo = dados.Rows[0]["Tipo"].ToString(),
                Telefone = dados.Rows[0]["Telefone"].ToString(),
                Email = dados.Rows[0]["Email"].ToString(),
                Cep = dados.Rows[0]["Cep"].ToString(),
                Logradouro = dados.Rows[0]["Logradouro"].ToString(),
                Numero = dados.Rows[0]["Numero"].ToString(),
                Bairro = dados.Rows[0]["Bairro"].ToString(),
                Cidade = dados.Rows[0]["Cidade"].ToString(),
                UF = dados.Rows[0]["UF"].ToString()
            };

            return cliente;
        }       
    }
}
