// Screen Sound
string mensagemDeBoasVindas = "Sejam bem vindos ao Screen Sound criado em C#";

void ExibirMensagemDeBoasVindas()
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
    Console.WriteLine("\nDigite 1 para registrar uma Banda");
    Console.WriteLine("Digite 2 para exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma Banda");
    Console.WriteLine("Digite 4 para exibir a media de uma Banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite a sua Opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   switch (opcaoEscolhidaNumerica )
    {
        case 1: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
            break; 
        case 2: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine("Até mais, volte sempre! *_*");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    } 
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

