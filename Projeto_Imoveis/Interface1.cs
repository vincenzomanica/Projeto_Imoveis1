using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Imoveis
{
    public interface Base<T>
    {
        bool inserir(T obj);
        bool alterar(T obj);
        bool deletar (T obj);
        T ListarUm(string ID);
        List<T> ListarTodos();
    }

}
