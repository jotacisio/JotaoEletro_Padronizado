using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    public class Usuario : Mediator
    {
        public static List<Usuario> ListaServ = new List<Usuario>();
        public static List<Usuario> ListaCli = new List<Usuario>();


        private String nome1, RG1, CPF1, Data1, senha1, limite;
        int numero1 = 0;

        public string nome { set { nome1 = value; } get { return nome1; } }
        public string rg { set { RG1 = value; } get { return RG1; } }
        public string cpf { set { CPF1 = value; } get { return CPF1; } }
        public string data { set { Data1 = value; } get { return Data1; } }
        public string senha { set { senha1 = value; } get { return senha1; } }
        public int numero { set { } get { return numero1; } }
        public string limiteconta { set { limite = value; } get { return limite; } }

        private Usuario(Builder builder)
        {
            this.nome = builder.nome;
            this.rg = builder.rg;
            this.cpf = builder.cpf;
            this.data = builder.data;
            this.senha = builder.senha;
            this.numero = builder.numero;
            this.limiteconta = builder.limiteconta;
        }
        public class Builder
        {
            private String nome1, RG1, CPF1, Data1, senha1, limite;
            int numero1;

            public string nome { set { nome1 = value; } get { return nome1; } }
            public string rg { set { RG1 = value; } get { return RG1; } }
            public string cpf { set { CPF1 = value; } get { return CPF1; } }
            public string data { set { Data1 = value; } get { return Data1; } }
            public string senha { set { senha1 = value; } get { return senha1; } }
            public int numero { set { } get { return numero1; } }
            public string limiteconta { set { limite = value; } get { return limite; } }

            public Builder ConstruirNome(String nome)
            {
                this.nome1 = nome;
                return this;
            }
            public Builder ConstruirRG(String rg)
            {
                this.RG1 = rg;
                return this;
            }
            public Builder ConstruirCPF(String cpf)
            {
                this.CPF1 = cpf;
                return this;
            }
            public Builder ConstruirData(String data)
            {
                this.Data1 = data;
                return this;
            }
            public Builder ConstruirSenha(String senha)
            {
                this.senha1 = senha;
                return this;
            }
            public Builder ConstruirLimiteConta(String limiteconta)
            {
                this.limite = limiteconta;
                return this;
            }
            public Builder ConstruirNumero(int numero)
            {
                this.numero1 = numero;
                return this;
            }
            public Usuario build { get { return new Usuario(this); } }
        }
        //-------Métodos de organização(Perfumaria)------------------------------
        public void saudacao() { Console.WriteLine("Inserido com sucesso!!!"); }
        public void perfumaria() { Console.WriteLine("_________________________________________________"); }
        //-----------------------------------------------------------------------
        //Implementação do Mediator
        private Servidor serv = null;
        private Cliente cli = null;

        public void changed(Colleague c)
        {
            if(c.GetType() == typeof(serv)){
                this.opeCliente((Cliente) c);
		    }
            else if (c.GetType() == typeof(cli))
            {
                this.opeServidor((Servidor) c);
		    }
        }

        private void opeCliente(Cliente cli)
        {
            String clienteData = cli.getDadosServidor();
            Servidor.ClienteData(clienteData);
        }

        private void opeServidor(Servidor s)
        {
            String servidorData = s.getDadosCliente();
            Cliente.ServidorData(servidorData);
        }
    }
}
