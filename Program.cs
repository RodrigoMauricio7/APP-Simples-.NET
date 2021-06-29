using System;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                                            
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            
            Console.WriteLine("Series a seu dispor.");
            Console.ReadLine();
            
        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o id da séire: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void visualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            var seire = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void AtualizarSerie()

        {
            Console.WriteLine("Digite o id da Séire: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da séire: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da séire: ");
            int entradaDescricao = int.Parse(Console.ReadLine());


            Serie AtualizarSerie = new Serie(
                id: indiceSerie,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, AtualizarSerie);
        }    

        private static void ListarSeries()

        {
            Console.WriteLine("Listar a Serie: ");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine('Nenhuma Série Cadastrada.');
                return;
            }    

            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("ID {0}: {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "* Excluido *" : "")); 
            }

            
        }

        private static void InserirSerie()

        {
            Console.WriteLine("Inserir uma nova série.");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da séire: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da séire: ");
            int entradaDescricao = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(
                id: repositorio.proximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao;
            );
             repositorio.Insere(novoArtilheiro);          
      
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Informações sobre Brasileirão a seu dispor!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Artilheiros");
            Console.WriteLine("2- Incluir novo Artilheiro");
            Console.WriteLine("3- Atualizar Artilheiro");
            Console.WriteLine("4- Excluir Artilheiro");
            Console.WriteLine("5- Visualizar Artilheiro");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
