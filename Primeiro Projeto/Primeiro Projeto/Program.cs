// Screen Sound
string mensagemDeBoasVindas = "Sejam bem vindos ao Screen Sound criado em C#";
List<string> listaDasBandas = new List<string> { "Baco Exu do Blues", "Matue", "Racionais" };


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
        case 3: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
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
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o Nome da Banda que deseja Registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($" A Banda {nomeDaBanda} foi registrada com sucesso! ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirListaDeBandas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas Registradas");
    Console.WriteLine("*************************************");

    //for (int i = 0;i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda {listaDasBandas[i]}");
    //    Console.WriteLine("*************************************\n");

    //}

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


ExibirOpcoesDoMenu();

