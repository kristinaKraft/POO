using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // filtrarPares();
            // filtrarImpares();
            // filtrarAlunos();
            // aprovados();
            // Reprovados();
            // MaiorMedia();
            MenorMedia();


            Console.ReadKey();

        }
        static void filtrarPares()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            /* consulta usando LINQ */
            var pares =
            from num in numbers
            where (num % 2) == 0
            select num;
            Console.WriteLine("Pares");
            /* executar consulta */
            foreach (int n in pares)
            {
                Console.WriteLine(n);
            }

        }
        static void filtrarImpares()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            /* consulta usando LINQ */
            var impares =
                from num in numbers
                where (num % 2) != 0
                select num;
            Console.WriteLine("Impares");
            /* executar consulta */
            foreach (int n in impares)
            {
                Console.WriteLine(n);
            }

        }
        static void filtrarAlunos()
        {
            // Crie uma fonte de dados usando um inicializador de coleção.
            List<Estudante> estudantes = new()
            {
                new Estudante {Id=1,Nome="Salsicha",SobreNome="Escube",Pontuacao = new List<int> {97, 92, 81, 60}},
                new Estudante {Id=2,Nome="Scooby",SobreNome="Bedoo",Pontuacao = new List<int> {75, 84, 91, 39}},
                new Estudante {Id=3,Nome="Bob",SobreNome="Esponja",Pontuacao = new List<int> {88, 94, 65, 91}},
                new Estudante {Id=4,Nome="Patrick",SobreNome="Bobs",Pontuacao = new List<int> {97, 89, 85, 82}},
                new Estudante {Id=5,Nome="Magali",SobreNome="Souza",Pontuacao = new List<int> {35, 72, 91, 70}},
                new Estudante {Id=6,Nome="Monica",SobreNome="Silva",Pontuacao = new List<int> {99, 86, 90, 94}},
                new Estudante {Id=7,Nome="Cascao",SobreNome="Souza",Pontuacao = new List<int> {93, 92, 80, 87}},
                new Estudante {Id=8,Nome="Cebolinha",SobreNome="Sasi",Pontuacao = new List <int> {92, 90, 83, 78}}
            };

            IEnumerable<Estudante> estudanteQuery =
             from estudante in estudantes
                 //where estudante.Pontuacao.Average();
                 //where estudante.Nome.StratsWith("C")// Nome começando com C.
                 //orderby estudante.Pontuacao.Average() descending //Média da Pontuação decrescente
                 //orderby estudante.Pontuacao.Average() ascending //Média da Pontuação crescente

             where estudante.Pontuacao[0] >= 90 //selecionado só quem tem nota maior 90 ou igual que 90
             select estudante;

            //List<Estudante> lista = estudanteQuery.Tolist();
            Estudante[] lista = estudanteQuery.ToArray();
            foreach (Estudante est in lista)
            {
                Console.WriteLine($"Id{est.Id} Nome: {est.Nome} SobreNome: {est.SobreNome} Media: {est.Pontuacao.Average()}");
            }

        }
        static void aprovados()
        {
            //Criar método para mostrar os alunos aprovados;
            List<Estudante> estudantes = new()
            {
                new Estudante {Id=1,Nome="Salsicha",SobreNome="Escube",Pontuacao = new List<int> {97, 92, 81, 60}},
                new Estudante {Id=2,Nome="Scube",SobreNome="Bedoo",Pontuacao = new List<int> {75, 84, 91, 39}},
                new Estudante {Id=3,Nome="Bob",SobreNome="Esponja",Pontuacao = new List<int> {88, 94, 65, 91}},
                new Estudante {Id=4,Nome="Patrick",SobreNome="Bobs",Pontuacao = new List<int> {97, 89, 85, 82}},
                new Estudante {Id=5,Nome="Magali",SobreNome="Souza",Pontuacao = new List<int> {35, 72, 91, 70}},
                new Estudante {Id=6,Nome="Monica",SobreNome="Silva",Pontuacao = new List<int> {99, 86, 90, 94}},
                new Estudante {Id=7,Nome="Cascao",SobreNome="Souza",Pontuacao = new List<int> {93, 92, 80, 87}},
                new Estudante {Id=8,Nome="Cebolinha",SobreNome="Sasi",Pontuacao = new List <int> {92, 90, 83, 78}},
            };

            IEnumerable<Estudante> estudanteQuery =
             from estudante in estudantes
             where estudante.Pontuacao.Average() >= 70 //selecionado só quem tem média maior 70 ou igual que 70 aprovado
             select estudante;

            //List<Estudante> lista = estudanteQuery.Tolist();
            Estudante[] lista = estudanteQuery.ToArray();
            foreach (Estudante est in lista)
            {
                Console.WriteLine($"Id{est.Id} Nome: {est.Nome} SobreNome: {est.SobreNome} Media: {est.Pontuacao.Average()} Aprovado");
            }
        }
        static void Reprovados()
        {
            //Criar método para mostrar os alunos Reprovados;
            List<Estudante> estudantes = new()
            {
                new Estudante {Id=1,Nome="Salsicha",SobreNome="Escube",Pontuacao = new List<int> {97, 92, 81, 60}},
                new Estudante {Id=2,Nome="Scooby",SobreNome="Bedoo",Pontuacao = new List<int> {75, 84, 91, 39}},
                new Estudante {Id=3,Nome="Bob",SobreNome="Esponja",Pontuacao = new List<int> {88, 94, 65, 91}},
                new Estudante {Id=4,Nome="Patrick",SobreNome="Bobs",Pontuacao = new List<int> {97, 89, 85, 82}},
                new Estudante {Id=5,Nome="Magali",SobreNome="Souza",Pontuacao = new List<int> {35, 72, 91, 70}},
                new Estudante {Id=6,Nome="Monica",SobreNome="Silva",Pontuacao = new List<int> {99, 86, 90, 94}},
                new Estudante {Id=7,Nome="Cascao",SobreNome="Souza",Pontuacao = new List<int> {93, 92, 80, 87}},
                new Estudante {Id=8,Nome="Cebolinha",SobreNome="Sasi",Pontuacao = new List <int> {65, 50, 63, 48}}
            };

            IEnumerable<Estudante> estudanteQuery =
             from estudante in estudantes
             where estudante.Pontuacao.Average() < 70 //selecionado só quem tem média menor que 70 está reprovado
             select estudante;

            //List<Estudante> lista = estudanteQuery.Tolist();
            Estudante[] lista = estudanteQuery.ToArray();
            foreach (Estudante est in lista)
            {
                Console.WriteLine($"Id{est.Id} Nome: {est.Nome} SobreNome: {est.SobreNome} Media: {est.Pontuacao.Average()} Reprovado");
            }
        }
        static void MaiorMedia()
        {
            //Criar método para retornar a maior média e a maior nota;

            List<Estudante> estudantes = new()
            {
                new Estudante {Id=1,Nome="Salsicha",SobreNome="Escube",Pontuacao = new List<int> {97, 92, 81, 60}},
                new Estudante {Id=2,Nome="Scooby",SobreNome="Bedoo",Pontuacao = new List<int> {75, 84, 91, 39}},
                new Estudante {Id=3,Nome="Bob",SobreNome="Esponja",Pontuacao = new List<int> {88, 94, 65, 91}},
                new Estudante {Id=4,Nome="Patrick",SobreNome="Bobs",Pontuacao = new List<int> {97, 89, 85, 82}},
                new Estudante {Id=5,Nome="Magali",SobreNome="Souza",Pontuacao = new List<int> {35, 72, 91, 70}},
                new Estudante {Id=6,Nome="Monica",SobreNome="Silva",Pontuacao = new List<int> {99, 86, 90, 94}},
                new Estudante {Id=7,Nome="Cascao",SobreNome="Souza",Pontuacao = new List<int> {93, 92, 80, 87}},
                new Estudante {Id=8,Nome="Cebolinha",SobreNome="Sasi",Pontuacao = new List <int> {65, 50, 63, 48}}
            };

            Console.WriteLine($"Maior Media:");

            var Media =
            from estudante in estudantes
            let media = estudante.Pontuacao.Average()
            select media;

            Console.WriteLine($"{Media.Max()}");

            Console.WriteLine($"Maior nota: ");

            var Nota =
            from estudante in estudantes
            let nota = estudante.Pontuacao.Max()
            select nota;

            var x = Nota.Max();
            Console.WriteLine($"{x}");



        }

        static void MenorMedia()
        {
            //Criar método para retornar a menor média e a menor nota;

            List<Estudante> estudantes = new()
            {
                new Estudante {Id=1,Nome="Salsicha",SobreNome="Escube",Pontuacao = new List<int> {97, 92, 81, 60}},
                new Estudante {Id=2,Nome="Scooby",SobreNome="Bedoo",Pontuacao = new List<int> {75, 84, 91, 39}},
                new Estudante {Id=3,Nome="Bob",SobreNome="Esponja",Pontuacao = new List<int> {88, 94, 65, 91}},
                new Estudante {Id=4,Nome="Patrick",SobreNome="Bobs",Pontuacao = new List<int> {97, 89, 85, 82}},
                new Estudante {Id=5,Nome="Magali",SobreNome="Souza",Pontuacao = new List<int> {35, 72, 91, 70}},
                new Estudante {Id=6,Nome="Monica",SobreNome="Silva",Pontuacao = new List<int> {99, 86, 90, 94}},
                new Estudante {Id=7,Nome="Cascao",SobreNome="Souza",Pontuacao = new List<int> {93, 92, 80, 87}},
                new Estudante {Id=8,Nome="Cebolinha",SobreNome="Sasi",Pontuacao = new List <int> {65, 50, 63, 48}}
            };

            Console.WriteLine($"Menor Media:");

            var Media =
            from estudante in estudantes
            let media = estudante.Pontuacao.Average()
            select media;

            Console.WriteLine($"{Media.Min()}");

            Console.WriteLine($"Menor nota: ");

            var Nota =
            from estudante in estudantes
            let nota = estudante.Pontuacao.Min()
            select nota;

            var x = Nota.Min();
            Console.WriteLine($"{x}");
        }

    }
}