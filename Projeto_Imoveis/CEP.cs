using System; //Importa o namespace System, que contém classes fundamentais para o .NET Framework
using System.Collections.Generic; // Importa o namespace System.Collections.Generic, que contém interfaces e classes genéricas que permitem criar coleções fortemente tipadas
using System.Linq; //Importa o namespace System.Linq que fornece funcionalidades de consula para coleções de objetos
using System.Text;//Importa o namespace System.Text, que contém classes que representam codiginicação de caracteres Unicode
using System.Threading.Tasks;//Importa o namespace System.ThreadingTasks, que fornece tipos que simplificam o trabalho com operações assíncronas
using ViaCep;//Importa o namespace ViaCep, que contém classes para pesquisa de CEP
using System.Net.Http;//Importa o namespace System.Net.Http, que contém classes para enviar solicitações HTTP e receber respostas HTTP
using System.Runtime.Remoting.Channels;//Importa o namespace System.Runtime.Remoting.Channels, que contém classes que permitem a comunicação entre objetos em domínios de aplicativos diferentes
using Newtonsoft.Json; // Importa o namespace Newtonsoft.Json, que contém classes para trabalhar com JSON



namespace Projeto_Imoveis // Define o namespace do projeto, que agrupa as classes relacionadas
{
    public class CEP // Define uma classe pública chamada CEP que contém propriedades para armazenar e manipular informações de CEP
    {
        private static readonly HttpClient httpClient = HttpClientFactory.Instance; // Cira uma instância Singelton de HttpClient usando HttpClientFactory

        // Propriedades da classe CEP
        public string Cep { get; set; } //Propriedade para armazenar o CEP
        public string Logradouro { get; set; } //Propriedade para armazenar o logradouro
        public string Complemento { get; set; }// Propriedade para armazenar o complemento.
        public string Unidade { get; set; }// Propriedade para armazenar a Unidade 
        public string Bairro { get; set; }// Propriedade para armazenar o Bairro
        public string Localidade { get; set; }// Propriedade para armazenar a Localidade
        public string Uf { get; set; }// Propriedade para armazenar a UF (Unidade Federativa)
        public string Estado { get; set; }// Propriedade para armazenar o Estado
        public string Regiao { get; set; }// Propriedade para armazenar a Região
        public string Ibge { get; set; }// Propriedade para armazenar o código IBGE
        public string Gia { get; set; }// Propriedade para armazenar o código GIA
        public string Ddd { get; set; }// Propriedade para armazenar o DDD
        public string Siafi { get; set; }// Propriedade para armazenar o código SIAFI

        //Método assíncrono para pesquisar o CEP 
        public async Task<CEP> PesquisaCepAsync(string cep)
        {
            // Envia uma solicitação GET para a API ViaCep com o CEP fornecido
            HttpResponseMessage response = await httpClient.GetAsync($"ws/{cep}/json");
            // Garante que a resposta seja bem-sucedida 
            response.EnsureSuccessStatusCode(); 
            // Lê o conteúdo da resposta como uma string JSON
            var json = await response.Content.ReadAsStringAsync();
            // Desserializa a string JSON em um objeto CEP e o retorna
            return JsonConvert.DeserializeObject<CEP>(json); 
        }
        //Método assincrono para pesquisar um endereço
        public async Task <List<CEP>> PesquisaEnderecoAsync(string logradouro){
            //Envia uma solicitação GET para a API viaCEP com o logradouro, cidade e estado fornecidos
            var response = await httpClient.GetAsync($"ws/{logradouro}/json");
            // Garante que a resposta seja bem sucedida
            response.EnsureSuccessStatusCode();
            // Lê o conteúdo da resposta como uma string JSON
            var json = await response.Content.ReadAsStringAsync();
            // Desserializa a string JSON em uma lista de objetos CEP e a retorna
            return JsonConvert.DeserializeObject<List<CEP>>(json);
        }
    }
}

