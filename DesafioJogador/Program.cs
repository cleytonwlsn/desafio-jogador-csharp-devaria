string nomeJogador;

Console.WriteLine("--Bem-vindos ao torneio de Poker Devaria!--");

Console.WriteLine("Qual o nome do jogador?");

nomeJogador = Console.ReadLine().ToString();

bool validacaoJogador;

switch (nomeJogador)
{
    case "Daniel":
    case "Rafael":
    case "Kaique":
    case "Douglas":
    case "Victor":
    case "Fulano": 
        Console.WriteLine("Jogador autorizado para o torneio de Poker!");
        validacaoJogador = true;
        break;
    default:
        Console.WriteLine("Jogador não autorizado para o torneio de Poker!");
        validacaoJogador = false;
        break;
}

if(validacaoJogador)
{
    Console.WriteLine("Quantas vitórias você conquistou?");
    int vitorias = Convert.ToInt32(Console.ReadLine());
    int pontuacaoAtual = VerificarPontuacao(vitorias);
    Console.WriteLine("Você possui " + pontuacaoAtual.ToString() + " pontos no torneio.");
    int pontuacaoNova = BonificarPontuacao(pontuacaoAtual);
    Console.WriteLine("Parabéns, você ganhou 1 ponto bônus por participar do torneio. Sua pontuação agora é " + pontuacaoNova.ToString() + " pontos.");

}

// Método de verificação da Pontuação do jogador.
int VerificarPontuacao (int vitorias)
{
    const int fatorVitoria = 3;

    int pontuacao = fatorVitoria * vitorias;

    return pontuacao;
}
// Método de Bonificação por participação no torneio.
int BonificarPontuacao (int pontuacaoAtual)
{
    int pontuacaoNova = pontuacaoAtual;

    pontuacaoNova++;

    return pontuacaoNova;
}