using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace show_do_milhão_iesb_edition
{
    class Program
    {
      
    static void Main(string[] args)
        {
            string nome, funca;
            int tentativa = 3;
            int entrada, entrada2, entrada3, entrada4, entrada5, entrada6, entrada7, entrada8, entrada9, entrada10, entradafinal;
            int premio = 5;
                        Console.WriteLine("Seja Bem Vindo ao Show do Milhão: IESB Edition!");
            Console.WriteLine("Olá, qual é seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("E qual é sua função no IESB?");
            funca = Console.ReadLine();
            Console.WriteLine("Perfeito! " + funca + " " + nome);
            Console.WriteLine("Hora de jogar o Show do Milhão: IESB Edition! Valendo 1 milhão de reais em fichas da cantina que vale mais do que dinheiro.");
            Console.WriteLine("Você está Pronto/a para Jogar?");
            Console.WriteLine("Pergunta Numero 1:");
            Console.WriteLine("Quantos Campus a instituição IESB tem até agora?");
            Console.WriteLine("1) Três campus, duas escolas");
            Console.WriteLine("2) Um Campus, três escolas");
            Console.WriteLine("3) Quatro Campus, uma escola");
            Console.WriteLine("4) Quatro Campus, nenhuma escola");
            Console.WriteLine("Digite sua resposta");
            entrada = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada == 3)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio++;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }
            }

            Console.WriteLine("Pergunta Numero 2:");
            Console.WriteLine("Qual é o Slogan do IESB?");
            Console.WriteLine("1) Educação de Qualidade a preço baixo!");
            Console.WriteLine("2) a Teoria e a Prática Juntos");
            Console.WriteLine("3) Mais que uma escola, uma familia");
            Console.WriteLine("4) Draco dorminus nunquant tintilandus");
            Console.WriteLine("Digite sua resposta");
            entrada2 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada2 == 2)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 2;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }
            }
            Console.WriteLine("Pergunta Numero 3:");
            Console.WriteLine("a Professora Eda, Reitora do IESB, faz parte da Mesa de Diretores de uma Faculdade Americana. Qual dessas?");
            Console.WriteLine("1) University of Phoenix");
            Console.WriteLine("2) University of Alabama");
            Console.WriteLine("3) University of Washington");
            Console.WriteLine("4) University of Pennsilvania");
            Console.WriteLine("Digite sua resposta");
            entrada3 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada3 == 4)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 3;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }
            }
           
            Console.WriteLine("Pergunta Numero 4:");
            Console.WriteLine("Todo semestre, os alunos precisam fazer algo chamado P.I. O que a Sigla Significa?");
            Console.WriteLine("1) Projeto Imersivo");
            Console.WriteLine("2) Projeto Integrador");
            Console.WriteLine("3) Pasta Inteligente");
            Console.WriteLine("4) Protótipo Intermediário");
            Console.WriteLine("Digite sua resposta");
            entrada4 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada4 == 2)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 4;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }


            }
                        
            Console.WriteLine("Pergunta Numero 5:");
            Console.WriteLine("Os Cursos de Design e Jogos são os cursos mais lucrativos do Campus Sul. Qual desses nomes não é de um dos Coordenadores?");
            Console.WriteLine("1) Bob Nelson da Silva, Design de Interiores");
            Console.WriteLine("2) Antônio Amaro da Silva Jr, Design Gráfico");
            Console.WriteLine("3) Felipe 'Hunterfox' Ferreira Costa, Jogos Digitais ");
            Console.WriteLine("4) Maísa Abranches, Design de Moda");
            Console.WriteLine("Digite sua resposta");
            entrada5 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada5 == 1)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 5;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }


            }
            
            Console.WriteLine("Pergunta Numero 6:");
            Console.WriteLine("Oh Não! Sua Internet Caiu! Você precisa que o pessoal da informática resete sua senha! Qual o nome do departamento responsável?");
            Console.WriteLine("1) CDD");
            Console.WriteLine("2) CBT");
            Console.WriteLine("3) CPD");
            Console.WriteLine("4) CDP");
            Console.WriteLine("Digite sua resposta");
            entrada6 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada6 == 3)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio*6;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }
                
                            }
            if (tentativa == 0)
            {
                Console.WriteLine("Oh não! Você Zerou suas tentativas. Fim de Jogo! Seu prêmio foi " + premio + " reais em Fichas da Cantina que valem mais do que barras de ouro!");
            }
            Console.WriteLine("Pergunta Numero 7:");
            Console.WriteLine("No IESB Campus Sul, tem dois restaurantes dentro da faculdade. Qual o nome deles?");
            Console.WriteLine("1) Starbucks e Casa do Pão de Queijo");
            Console.WriteLine("2) Megamilk e Cafezinho da Cida");
            Console.WriteLine("3) Café Mania e Mega Mate");
            Console.WriteLine("4) Cafezinho da Cida e Starbucks");
            Console.WriteLine("Digite sua resposta");
            entrada7 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada7 == 3)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 6;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }

            }
            if (tentativa == 0)
            {
                Console.WriteLine("Oh não! Você Zerou suas tentativas. Fim de Jogo! Seu prêmio foi " + premio + " reais em Fichas da Cantina que valem mais do que barras de ouro!");
            }
            Console.WriteLine("Pergunta Numero 8:");
            Console.WriteLine("Você está Quase lá. Qual é o Salgado mais Oleoso do Café Mania?");
            Console.WriteLine("1) Coxinha");
            Console.WriteLine("2) Enroladinho");
            Console.WriteLine("3) Kibe");
            Console.WriteLine("4) Todas Acima");
            Console.WriteLine("Digite sua resposta");
            entrada8 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada8 == 4)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 6;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }

            }
            if (tentativa == 0)
            {
                Console.WriteLine("Oh não! Você Zerou suas tentativas. Fim de Jogo! Seu prêmio foi " + premio + " reais em Fichas da Cantina que valem mais do que barras de ouro!");
            }
            Console.WriteLine("Pergunta Numero 9:");
            Console.WriteLine("Boatos de um Easter Egg estranho rola sobre o campus. Qual o nome dele?");
            Console.WriteLine("1) Molotovinho");
            Console.WriteLine("2) IESBinho");
            Console.WriteLine("3) Joãozinho");
            Console.WriteLine("4) Lulinha");
            Console.WriteLine("Digite sua resposta");
            entrada9 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada9 == 1)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 6;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }

            }
            if (tentativa == 0)
            {
                Console.WriteLine("Oh não! Você Zerou suas tentativas. Fim de Jogo! Seu prêmio foi " + premio + " reais em Fichas da Cantina que valem mais do que barras de ouro!");
            }
            Console.WriteLine("Pergunta Numero 10:");
            Console.WriteLine("Molotovinho pode ser encontrado em vários lugares no IESB Campus Sul. Qual dessas alternativas é verdadeira?");
            Console.WriteLine("1) Garagem, Reprografia, Cantina");
            Console.WriteLine("2) Ateliê DA3-4, Escadaria lateral do Bloco H, Mesa na sala HC6");
            Console.WriteLine("3) Ateliê de Maquetes, Ateliê DA3-4, Fumódromo");
            Console.WriteLine("4) Nenhuma das Anteriores");
            Console.WriteLine("Digite sua resposta");
            entrada10 = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entrada10 == 2)
                {
                    Console.WriteLine("Certa Reposta!");
                    premio = premio * 6;
                    break;
                }
                else
                {
                    tentativa--;
                    Console.WriteLine("Resposta errada! (" + tentativa + " Tentativas Restantes)");
                    break;
                }

            }
            if (tentativa == 0)
            {
                Console.WriteLine("Oh não! Você Zerou suas tentativas. Fim de Jogo! Seu prêmio foi " + premio + " reais em Fichas da Cantina que valem mais do que barras de ouro!");
            }
            Console.WriteLine("Agora, a Pergunta Valendo Um Milhão de Reais em Fichas da Cantina que valem mais do que barras de ouro!");
            Console.WriteLine("IESB - Instituto de Educação Superior de Brasilia possui um nome 'secreto'! Qual nome é esse?");
            Console.WriteLine("1) CEdB - Centro Educacional de Brasília");
            Console.WriteLine("2) IEET - Instituto Educacional em Tecnologia");
            Console.WriteLine("3) Escola de Educação Superior Eda Machado");
            Console.WriteLine("4) CESB - Centro Educacional Superior de Brasilia");
            Console.WriteLine("Digite sua resposta");
            entradafinal = int.Parse(Console.ReadLine());
            while (tentativa != 0)

            {

                if (entradafinal == 4)
                {
                    Console.WriteLine("Certa Reposta! Você ganhou um milhão de reais em Fichas da Cantina, que valem mais do que Barras de ouro!");
                    Console.WriteLine("Fim de Jogo! Quer jogar de novo? Digite 1! Se não, Digite 2");
                
                    
                                    }
                else
                {
                    Console.WriteLine("Resposta errada! Você perdeu! seu prêmio foi de " + premio + " reais em fichas da Cantina que valem mais do que barras de ouro!");
                  

                }

            
            
            }

                   }
        

    }
}
    

