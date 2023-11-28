using BancoDeDados.entidade;
using BancoDeDados.dao;
namespace BancoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contato();
            Locais():
             Console.ReadKey();
        }
        static void Contato() 
        {
            Contato ct = new Contato(1, "Maria", "maria@gmail.com", "(47)9988-1234");
            DaoContato daoContato = new DaoContato();
            if (daoContato.salvar(ct))
            {
                Console.WriteLine("Contato salvo com sucesso");
            }
        }
        static void Local() 
        {
            Locais lc = new Locais(1, "nome","rua","numero","cidade","UF");   
            DaoLocais daoLocal = new DaoLocais();
            if (DaoLocais.salvar(lc)) 
            {
                Console.WriteLine("Locais salvo com sucesso");
            }
        }

    }
}
