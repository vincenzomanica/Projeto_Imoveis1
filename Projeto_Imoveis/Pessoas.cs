/*using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Projeto_Imoveis
{
    public class Pessoas : Base<Pessoas>
    {
        private string arquivoPath = @"C:\Users\vincenzo.manica\ListaPessoas.json";

        public string ID { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string EstadoCivil { get; set; }
        public string DataDeNascimento { get; set; }
        public string Genero { get; set; }

        public async Task<bool> AlterarAsync(Pessoas obj)
        {
            //Modificando os atributos
            List<Pessoas> pessoas = await ListarTodos();
            try
            {
                foreach (Pessoas p in pessoas)
                {
                    if (p.ID == obj.ID)
                    {
                        p.ID = obj.ID;
                        p.CPF = obj.CPF;
                        p.Nome = obj.Nome;
                        p.Telefone = obj.Telefone;
                        p.Logradouro = obj.Logradouro;
                        p.Numero = obj.Numero;
                        p.Cidade = obj.Cidade;
                        p.UF = obj.UF;
                        p.CEP = obj.CEP;
                        p.Bairro = obj.Bairro;
                        p.DataDeNascimento = obj.DataDeNascimento;
                        p.EstadoCivil = obj.EstadoCivil;
                        p.Genero = obj.Genero;
                    }
                }
                //Regravando o arquivo 

                string jsonString = JsonConvert.SerializeObject(pessoas);
                await File.WriteAllTextAsync(arquivoPath, jsonString);

                //Retornando valor booleano verdadeiro
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool deletar(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = ListarTodos();
                foreach (Pessoas p in pessoas)
                {
                    if (p.ID == obj.ID)
                    {
                        pessoas.Remove(p);
                        break;
                    }

                }
                string json = JsonConvert.SerializeObject(pessoas);
                File.WriteAllText(arquivoPath, json);
                return true;

            }
            catch
            {
                return false;
            }

        }

        public bool inserir(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = ListarTodos();

                pessoas.Add(obj);

                var JsonString = JsonConvert.SerializeObject(pessoas);

                File.WriteAllText(arquivoPath, JsonString);

                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Pessoas>> ListarTodosAsync()
        {
            try
            {
                string arquivoPath = @"C:\Users\vincenzo.manica\ListaPessoas.json";

                string json = File.ReadAllText(arquivoPath);

                return JsonConvert.DeserializeObject<List<Pessoas>>(json);
            }
        }

        public Pessoas ListarUm(int ID)
        {
            List<Pessoas> pessoas = ListarTodos();

            foreach (Pessoas pessoa1 in pessoas)
            {
                if (pessoa1.ID.Equals(ID))
                {
                    return pessoa1;

                }
            }
            return new Pessoas();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Projeto_Imoveis
{
    public class Pessoas : Base<Pessoas>
    {
        protected string arquivoPath = @"C:\Users\vincenzo.manica\ListaPessoas.json";

        private string ID { get; set; }
        private string Telefone { get; set; }
        private string CPF { get; set; }
        private string Nome { get; set; }
        private string Cidade { get; set; }
        private string UF { get; set; }
        private string Logradouro { get; set; }
        private string Bairro { get; set; }
        private string Numero { get; set; }
        private string CEP { get; set; }
        private string EstadoCivil { get; set; }
        private string DataDeNascimento { get; set; }
        private string Genero { get; set; }

        public bool alterar(Pessoas obj)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AlterarAsync(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = await ListarTodosAsync();
                var pessoa = pessoas.Find(p => p.ID == obj.ID);
                if (pessoa != null)
                {
                    pessoa.CPF = obj.CPF;
                    pessoa.Nome = obj.Nome;
                    pessoa.Telefone = obj.Telefone;
                    pessoa.Logradouro = obj.Logradouro;
                    pessoa.Numero = obj.Numero;
                    pessoa.Cidade = obj.Cidade;
                    pessoa.UF = obj.UF;
                    pessoa.CEP = obj.CEP;
                    pessoa.Bairro = obj.Bairro;
                    pessoa.DataDeNascimento = obj.DataDeNascimento;
                    pessoa.EstadoCivil = obj.EstadoCivil;
                    pessoa.Genero = obj.Genero;

                    string jsonString = JsonConvert.SerializeObject(pessoas);
                    await File.WriteAllTextAsync(arquivoPath, jsonString);
                    return true;
                }
                return false;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public bool deletar(Pessoas obj)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletarAsync(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = await ListarTodosAsync();
                var pessoa = pessoas.Find(p => p.ID == obj.ID);
                if (pessoa != null)
                {
                    pessoas.Remove(pessoa);
                    string jsonString = JsonConvert.SerializeObject(pessoas);
                    await File.WriteAllText(arquivoPath, jsonString);
                    return true;
                }
                return false;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public bool inserir(Pessoas obj)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InserirAsync(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = await ListarTodosAsync();
                obj.ID = Guid.NewGuid().ToString();
                pessoas.Add(obj);
                string jsonString = JsonConvert.SerializeObject(pessoas);
                await File.WriteAllTextAsync(arquivoPath, jsonString);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public List<Pessoas> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pessoas>> ListarTodosAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(arquivoPath);
                return JsonConvert.DeserializeObject<List<Pessoas>>(json);
            }
            catch (IOException)
            {
                return new List<Pessoas>();
            }
        }

        public Pessoas ListarUm(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<Pessoas> ListarUmAsync(string id)
        {
            List<Pessoas> pessoas = await ListarTodosAsync();
            return pessoas.Find(p => p.ID == id) ?? new Pessoas();
        }
    }
}/*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks; // Adicione esta linha para importar o namespace correto

namespace Projeto_Imoveis
{
    public class Pessoas : Base<Pessoas>
    {
        protected string arquivoPath = @"C:\Users\vincenzo.manica\ListaPessoas.json";

        private string ID { get; set; }
        private string Telefone { get; set; }
        private string CPF { get; set; }
        private string Nome { get; set; }
        private string Cidade { get; set; }
        private string UF { get; set; }
        private string Logradouro { get; set; }
        private string Bairro { get; set; }
        private string Numero { get; set; }
        private string CEP { get; set; }
        private string EstadoCivil { get; set; }
        private string DataDeNascimento { get; set; }
        private string Genero { get; set; }


        public async Task<bool> AlterarAsync(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = await ListarTodosAsync();
                var pessoa = pessoas.Find(p => p.ID == obj.ID);
                if (pessoa != null)
                {
                    pessoa.CPF = obj.CPF;
                    pessoa.Nome = obj.Nome;
                    pessoa.Telefone = obj.Telefone;
                    pessoa.Logradouro = obj.Logradouro;
                    pessoa.Numero = obj.Numero;
                    pessoa.Cidade = obj.Cidade;
                    pessoa.UF = obj.UF;
                    pessoa.CEP = obj.CEP;
                    pessoa.Bairro = obj.Bairro;
                    pessoa.DataDeNascimento = obj.DataDeNascimento;
                    pessoa.EstadoCivil = obj.EstadoCivil;
                    pessoa.Genero = obj.Genero;

                    string jsonString = JsonConvert.SerializeObject(pessoas);
                    File.WriteAllText(arquivoPath, jsonString);
                    return true;
                }
                return false;
            }
            catch (IOException)
            {
                return false;
            }
        }

      

        public async Task<bool> DeletarAsync(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = await ListarTodosAsync();
                var pessoa = pessoas.Find(p => p.ID == obj.ID);
                if (pessoa != null)
                {
                    pessoas.Remove(pessoa);
                    string jsonString = JsonConvert.SerializeObject(pessoas);
                   File.WriteAllText(arquivoPath, jsonString);
                    return true;
                }
                return false;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public bool inserir(Pessoas obj)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InserirAsync(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = await ListarTodosAsync();
                obj.ID = Guid.NewGuid().ToString();
                pessoas.Add(obj);
                string jsonString = JsonConvert.SerializeObject(pessoas);
                 File.WriteAllText(arquivoPath, jsonString);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public List<Pessoas> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pessoas>> ListarTodosAsync()
        {
            try
            {
                string json =  File.ReadAllText(arquivoPath);
                return JsonConvert.DeserializeObject<List<Pessoas>>(json);
            }
            catch (IOException)
            {
                return new List<Pessoas>();
            }
        }

        

        public async Task<Pessoas> ListarUmAsync(string id)
        {
            List<Pessoas> pessoas = await ListarTodosAsync();
            return pessoas.Find(p => p.ID == id) ?? new Pessoas();
        }
    }
}