# JotaoEletro_Padronizado
Utilização de Padrões em um Projeto de Software não padronizado
------------
```bash
# Linguagem Utilizada
CSharp

# Tipo de Aplicação
Console Aplication

# Padrões de Projeto Implementados
Padrão Criacional - Builder 
Padrão Comportamental - Mediator

# Repositório da aplicação não padronizada
https://github.com/jotacisio/JotaoEletro
```
### Builder

A utilização desse padrão de projeto possibilitou a separação da criação da construção dos objetos **Servidor** e **Cliente** da sua instanciação.
Outra vantagem foi generalização da construção desses objetos por meio de uma classe **Usuario** que contem uma classe Builder dentro. 
Agora, quando for necessário criar novos atributos de **Cliente** ou **Servidor**, basta alterar essa Classe **Usuario**.

#### Classes alteradas

- Versão Anterior -
[Cliente.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Cliente.cs) |
[Servidor.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Servidor.cs) |
[Principal.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Principal.cs)

- Versão Atual -
[Cliente.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Cliente.cs) |
[Servidor.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Servidor.cs) |
[Usuario.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Usuario.cs)

### Mediator
A utilização desse padrão de projeto possibilitou a comunicação generalizada das classes **Servidor** e **Cliente**, por intermédio da Classe **Mediator**.
Essa nova implementação estabeleceu um meio genérico para que o Servidor obtenha dados do Cliente e visse versa.

#### Classes alteradas
- Versão Anterior -
[Cliente.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Cliente.cs) |
[Servidor.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Servidor.cs) |
[Principal.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Principal.cs) |
[Program.cs](https://github.com/jotacisio/JotaoEletro/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Program.cs) 

- Versão Atual -
[Cliente.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Cliente.cs) |
[Servidor.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Servidor.cs) |
[Usuario.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Usuario.cs) |
[Mediator.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Mediator.cs) |
[Colleague.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Colleague.cs) |
[Program.cs](https://github.com/jotacisio/JotaoEletro_Padronizado/blob/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/Program.cs) 

### Programa Executável
- Versão Atual -
[JotaoEletros.exe](https://raw.githubusercontent.com/jotacisio/JotaoEletro_Padronizado/master/Programa%20lojas%20Jot%C3%A3o%20Eletros/bin/Release/Programa%20lojas%20Jot%C3%A3o%20Eletros.exe)
