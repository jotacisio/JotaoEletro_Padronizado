using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    class Servidor : Usuario
    {
        private String DadosCliente = "";
        public String getDadosCliente()
        {
            return DadosCliente;
        }
        public static void ClienteData(String data)
        {
            Console.WriteLine("Dados do Servidor: " + data);
        }
        int contador = 0;
        private Cliente objCli;

        public Servidor(Cliente objCli)
        {
            // TODO: Complete member initialization
            this.objCli = objCli;
        }
        //---------------------------------------------------------------------------------------------------------
        public void InserirServ()
        {
            for (int i = 0; i < 3; i++)
            {
                
                Usuario servidor = null;
                //-------------------------------------------------------------------
                Console.WriteLine("Numero de inscrição do Servidor é: " + servidor.numero);
                servidor = new Usuario.Builder().ConstruirNumero(contador++).build;
                Console.WriteLine("Nome do Servidor: ");
                servidor = new Usuario.Builder().ConstruirNome(Console.ReadLine()).build;
                Console.WriteLine("CPF do Servidor: ");
                servidor = new Usuario.Builder().ConstruirCPF(Console.ReadLine()).build;
                Console.WriteLine("RG do Servidor: ");
                servidor = new Usuario.Builder().ConstruirRG(Console.ReadLine()).build;
                Console.WriteLine("Data de nascimento do Servidor: ");
                servidor = new Usuario.Builder().ConstruirData(Console.ReadLine()).build;
                Console.WriteLine("Senha do Servidor(de no Mínimo quatro dígitos): ");
                servidor = new Usuario.Builder().ConstruirSenha(Console.ReadLine()).build;
                //-------------------------------------------------------------------                
                ListaServ.Add(servidor);
                //-------------------------------------------------------------------
                perfumaria();
                Console.WriteLine();
                saudacao();
                Console.WriteLine();
                perfumaria();
            }
            pausaclass();
        }
        public void BuscarServ()
        {
            string N1;
            Console.WriteLine("Senha do Servidor: ");
            N1 = Console.ReadLine();
            int AUX = 0;
            Boolean acheiServ = false;
            //-------------------------------------------------------------------
            while ((acheiServ == false) && (AUX < 3))
            {
                if (ListaServ[AUX].senha == N1)
                {
                    acheiServ = true;
                    perfumaria();
                    perfumaria();
                    Console.WriteLine("Nome do Servidor:" + ListaServ[AUX].nome);
                    Console.WriteLine("CPF do Servidor:" + ListaServ[AUX].cpf);
                    Console.WriteLine("RG do Servidor:" + ListaServ[AUX].rg);
                    Console.WriteLine("Data de nascimento do Servidor:" + ListaServ[AUX].data);
                    Console.WriteLine("Numero de inscrição do Servidor:" + ListaServ[AUX].numero);
                    perfumaria();
                    perfumaria();
                }
                AUX++;
            }
            //-------------------------------------------------------------------
            if (acheiServ == false)
            {
                Console.WriteLine("Cliente não encontrado!!!");
            }
            //-------------------------------------------------------------------
        }
        public void ListarServ()
        {
            //-------------------------------------------------------------------
            if (ListaServ.Count == 0)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Servidor inseridos!!!");
                Console.ResetColor();
            }
            //-------------------------------------------------------------------
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    perfumaria();
                    perfumaria();
                    Console.WriteLine("Nome do Servidor:" + ListaServ[i].nome);
                    Console.WriteLine("CPF do Servidor:" + ListaServ[i].cpf);
                    Console.WriteLine("RG do Servidor:" + ListaServ[i].rg);
                    Console.WriteLine("Numero de inscrição do Servidor:" + ListaServ[i].numero);
                    perfumaria();
                    perfumaria();
                }
            }
            //-------------------------------------------------------------------
        }
        public void Senhagerente()
        {
            string senhaGerente = "jotao";

            Console.WriteLine("Inserir senha do gerente(senha ta no método SenhaGerente) :");
            senhaGerente = Console.ReadLine();
            //------------------------------------------------------------------- 
            if (senhaGerente == "jotao")
            {
                Console.WriteLine("Senha correta!!! ");
                ListarServ();
            }
            //-------------------------------------------------------------------
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite uma senha valida!!!");
                Console.ResetColor();
            }
            //-------------------------------------------------------------------
        }
        public void pausaclass()
        {
            int escolha = 0;
            //-------------------------------------------------------------------
            while (escolha != 2012)
            {
                Console.WriteLine("Deseja substituir os servidores inseridos?");
                Console.WriteLine("1 - sim");
                Console.WriteLine("2 - não\n");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    //-------------------------------------------------------------------
                    case 1:
                        Console.WriteLine();
                        perfumaria();
                        Console.WriteLine("A empresa ta crescendo!!!");
                        perfumaria();
                        Console.WriteLine();
                        InserirServ();
                        break;
                    //-------------------------------------------------------------------
                    case 2: 
                        if (escolha != 2012)
                        {
                            escolha = 2012;
                            Console.WriteLine();
                            perfumaria();
                            Console.WriteLine("Obrigado pela atenção!!!");
                            perfumaria();
                            Console.WriteLine();
                        }
                        break;
                    //-------------------------------------------------------------------
                    default:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Digite um valor valido(1 ou 2)");
                        Console.WriteLine();
                        Console.ResetColor();
                        break;
                    //-------------------------------------------------------------------
                }
            }
        }
    }
}


