namespace Arquivos
{
    internal class Program
    {
        //static string path = @"C:\Users\vilson.moro\Desktop\entra21c#\teste.txt";
        static string path = @"C:\Users\kristina.kraft\Desktop\POO\Arquivo\documento.txt";
        
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine("1 - Gravar");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("3 - excluir");
                Console.WriteLine("4 - sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: gravar(); break;
                    case 2: lerArquivo(); break;
                    case 3: excluir(); break;
                }
            }


            criarArquivo();
            lerArquivo();
            Console.ReadKey();
        }
        static void gravar()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("Informe nome");
                    string nome = Console.ReadLine();
                    sw.WriteLine(nome);

                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("Informe nome");
                    string nome = Console.ReadLine();
                    sw.WriteLine(nome);
                }

            }


        }
        static void excluir()
        {
            File.Delete(path);
        }

        static void criarArquivo()
        {
            if (!File.Exists(path))
            {
                // File.CreateText(path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
        }
        static void lerArquivo()
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine(f.Message);
            }

        }
    }
}