namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //singleResponsability();
            // openClosed();
            liskov();
            Console.ReadKey();
        }   
        static void liskov()
        {
            GerenciaPersitenciaFatura gp1 = new GerenciaPersitenciaFatura(new PersistenciaEmArquivo());
            gp1.executar(new Fatura());

            GerenciaPersitenciaFatura gp2 = new GerenciaPersitenciaFatura(new PersistenciaEmBD());
            gp2.executar(new Fatura());
        }
        static void openClosed()
        {
            new PersistenciaEmArquivo().salvar(new Fatura());
            new PersistenciaEmBD().salvar(new Fatura());
        }

        static void singleResponsability()
        {
            Produto produtoproduto = new Produto(1, "Milho", 2);

            CrudProduto crudProduto = new CrudProduto();
            crudProduto.salvar(produtoproduto);
            crudProduto.salvar(new Produto(2, "Trigo", 50));

            crudProduto.consultar();
        }
    }
}