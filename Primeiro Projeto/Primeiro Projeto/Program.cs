// Screen Sound
string mensagemDeBoasVindas = "Sejam bem vindos ao Screen Sound criado em C#";
//List<string> listaDasBandas = new List<string> { "Baco Exu do Blues", "Matue", "Racionais" };

Dictionary<string, List<int>> regristroDasBandas = new Dictionary<string, List<int>>();
regristroDasBandas.Add("Linkin Park", new List<int> { 10, 8, 6 });
regristroDasBandas.Add("The Beatles", new List<int>());


void Exibirlogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Exibirlogo();
    Console.WriteLine("\nDigite 1 para registrar uma Banda");
    Console.WriteLine("Digite 2 para exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma Banda");
    Console.WriteLine("Digite 4 para exibir a media de uma Banda");
    Console.WriteLine("Digite 5 para sair");

    Console.WriteLine("\nDigite a sua Opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   switch (opcaoEscolhidaNumerica )
    {
        case 1:
            RegistrarBanda();
            break; 
        case 2: ExibirListaDeBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4:
            ExibirMediaDasBandas();
            break;
        case 5:
            Console.WriteLine("Até mais, volte sempre! *_*");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    } 
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o Nome da Banda que deseja Registrar: ");
    string nomeDaBanda = Console.ReadLine();
    regristroDasBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($" A Banda {nomeDaBanda} foi registrada com sucesso! ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirListaDeBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas Registradas");

    //for (int i = 0;i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda {listaDasBandas[i]}");
    //    Console.WriteLine("*************************************\n");

    //}

    foreach (string banda in regristroDasBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    if(regristroDasBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota você dá a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        regristroDasBandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDasBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (regristroDasBandas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = regristroDasBandas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}


ExibirOpcoesDoMenu();

