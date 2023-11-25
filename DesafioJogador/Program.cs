string nomeJogador;

Console.WriteLine("--Bem-vindos ao torneio de Poker Devaria!--");

Console.WriteLine("Qual o nome do jogador?");

nomeJogador = Console.ReadLine().ToString();

switch (nomeJogador)
{
    case "Daniel":
    case "Rafael":
    case "Kaique":
    case "Douglas":
    case "Victor":
    case "Fulano": 
        Console.WriteLine("Jogador autorizado para o torneio de Poker!");
        break;
    default:
        Console.WriteLine("Jogador não autorizado para o torneio de Poker!");
        break;
}
