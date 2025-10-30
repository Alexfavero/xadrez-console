using tabuleiro;
using xadrez_console;
using xadrez;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.terminada)
            {
                Console.Clear();

                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine("Origem: ");
                Posicao origem = Tela.lerPoicaoXadrez().toPosicao();
                Console.WriteLine("Destino: ");
                Posicao destino = Tela.lerPoicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);
            }

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }


        Console.ReadLine();
    }
}