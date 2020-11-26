using System;

namespace Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---Sistema de passagens Aéreas---");
            Console.WriteLine("---------------------------------");

            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];
            bool senhaValida;

            do
            {
                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);      // chamando método;

            } while (!senhaValida);          // ponto de interrogação (!) significa negaçao ;
            Console.Clear();                // limpar tela;

            int escolha;
            int contador = 0;

            do
            {
                
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("[2] - Cadastrar destino ");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                            //Cadsatrare passagem
                            string resposta;

                            do
                            {
                                if (contador<5)
                                {
                                    Console.WriteLine($"DIgite o nome do {contador+1}º passageiro");
                                    nomes[contador] = Console.ReadLine();

                                    Console.WriteLine($"DIgite a origem do {contador+1}º passageiro");
                                    origem[contador] = Console.ReadLine();

                                    Console.WriteLine($"DIgite o destino do {contador+1}º passageiro");
                                    destino[contador] = Console.ReadLine();

                                    Console.WriteLine($"DIgite a data do {contador+1}º passageiro");
                                    data[contador] = Console.ReadLine();
                                    contador++;
                                    
                                }else{
                                    Console.WriteLine("Limite excedido de passagens");
                                    break;
                                }
                                    Console.WriteLine("Gostaria de cadastrar um novo passagiero? s/n" );
                                    resposta = Console.ReadLine();

                            } while (resposta == "s");

                        break;

                        case 2:
                            //Listar pasasagens
                            for (var i = 0; i < 5; i++)
                            {
                                Console.WriteLine($"Passageiro {nomes[i]}");
                            };
                        break;

                        case 0:
                            //Sair
                        break;

                    default:
                            Console.WriteLine("Opção inválida!");
                        break;
                }
                
            } while (escolha != 0);

            //Funções

            bool EfetuarLogin(string senha){

                if (senha == "123456")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Senha incorreta!");
                    return false;
                }

            }  // Fim do efetuar login

        }
    }
}