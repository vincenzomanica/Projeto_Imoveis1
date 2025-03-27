using System; //Importa o namespace System que contem classe fundamentais para .NET Framework.
using System.Collections.Generic; // Importa o namespace System.Collections.Generic, que contém interfaces e classes que definem coleções genéricas
using System.Drawing;
using System.Linq;// Importa o namespace System.Linq que fornece funcionalidades de consulta para coleções
using System.Text;// Imporra o namespace System.Text que contpém classes que representam codifcações 
using System.Threading.Tasks; //Importa o namespace NewtonSofton.Json, que contém classes para trabalhar com JSON

namespace Projeto_Imoveis // Define o namespace do projeto, que agrupa classes relacionadas.
{
    // Define uma interface pública chamada IViaCepClient.
    public interface IViaCepClient
    {
        // Declara um método assíncrono que retorna um objeto CEP com base no CEP fornecido.
        Task<CEP> SearchAsync(string cep);

        // Declara um método assíncrono que retorna uma lista de objetos CEP com base no logradouro, cidade e estado fornecidos.
        Task<List<CEP>> SearchByAddressAsync(string estado, string cidade, string logradouro);
    }
}
