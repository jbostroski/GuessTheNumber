using System.ComponentModel.Design;
using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        Random randNum = new Random();
        var sorteio = randNum.Next(1, 25);
        string usuario;
       

       while (true)
        {
            Console.WriteLine("CHARADA... Tente adivinhar o número que pensei... Vai de 1 ao 25.");
            Console.WriteLine("Digite um número ou tecle 'S' para sair do jogo.");
            usuario = Console.ReadLine();

            if (usuario == "s")
            {
                Console.WriteLine("VOCÊ SAIU DO JOGO!");
                break;
            }

            if (int.TryParse(usuario, out int palpite))
            {

                if (palpite == sorteio)
                {

                    Console.WriteLine("PARABÉNS, você acertou! O número é: " + sorteio);
                    break;
                } else
                {
                    Console.WriteLine("ERROU!! tente novamente:");
                }             
            }
            else
            {
                Console.WriteLine("Comando inválido. Tecle 'S' para sair do jogo, ou digite um número:");
            }
        }
    }
}