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
       public static string arquivoPath = @"C:\Users\vincenzo.manica\ListaPessoas.json";

        public string ID { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
.        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero {get; set; }
        public string CEP { get; set; }


        
        public static bool alterar(Pessoas obj)
        {
            //Modificando os atributos
            List<Pessoas> pessos = ListarTodos();
            try
            {
                foreach (Pessoas p in pessos)
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
                    }
                }
                //Regravando o arquivo 

                string jsonString = JsonConvert.SerializeObject(pessos);
                File.WriteAllText(arquivoPath, jsonString); 

                //Retornando valor booleano verdadeiro
                return true;
            }

            catch
            {
                return false;
            }
        }

        public static bool deletar(Pessoas obj)
        {
            try
            {
                List<Pessoas> pessoas = | ListarTodos();
                foreach (Pessoas p in pessoas)
                {
                    if (p.ID == obj.ID)
                    {
                        pessoas.Remove(p);
                        break;
                    }

                }
                string json = JsonConvert.SerializeObject(pessoas);
                File.WriteAllText(json, arquivoPath);
                return true;

            }
            catch
            {
                return false;
            }

        }

        public static bool inserir(Pessoas obj)
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

        public static List<Pessoas> ListarTodos()
        {
            string arquivoPath = @"C:\Users\vincenzo.manica\ListaPessoas.json";

            string json = File.ReadAllText(arquivoPath);

            return JsonConvert.DeserializeObject<List<Pessoas>>(json);
        }

        public static Pessoas ListarUm(int ID)
        {
            List<Pessoas> pessoas =| ListarTodos();

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
