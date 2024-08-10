# C# - Básico

**C#** é uma linguagem de programação moderna, robusta e de propósito geral, desenvolvida pela **Microsoft**. Ela foi projetada para ser simples, eficiente e orientada a objetos. C# oferece recursos avançados de programação, como tratamento de exceções, coleta de lixo automática e suporte a tipos de dados avançados, além de ser altamente integrada com o ecossistema **.NET**.

O .NET, por sua vez, é uma plataforma de desenvolvimento criada pela Microsoft, que inclui uma vasta coleção de bibliotecas, ferramentas e componentes para construir e executar aplicativos em diferentes sistemas operacionais e plataformas.

### Hello, World!

Abaixo é apresentado um simples trecho de código na linguagem C# que tem objetivo de exibir em um console (linha de comando) a frase **Hello, World!**.

```C#
Console.WriteLine("Hello, World!");
```

- ``Console`` é uma classe fornecida pelo C# que contém atributos e métodos para realizar operações de entrada e saída no console (linha de comando).
- ``WriteLine()`` é um método da classe Console usado para escrever um texto no console (linha de comando).
- ``"Hello, World!"`` é basicamente a mensagem que será exibida no console (linha de comando).
- ``;`` é um delimitador de instruções em C#. Ele indica o fim da instrução.

### Variáveis

C# é uma linguagem de programação **fortemente tipada**, isso quer dizer que cada variável declarada deve receber um tipo.

Os principais tipos de dados em C# são:

- **int**
- **double**
- **char**
- **string**
- **bool**

A declaração de uma nova variável em C# deve seguir a seguinte regra:

```C#
tipo nomeDaVariavel = valor;
```

**Exemplo:**

```C#
string nome = "Fábio";
int idade = 30;
double altura = 1.90;
char sexo = "M";
bool estaSolteiro = true;
```

Caso o nome da nova variável seja de forma composta, deve seguir o padrão **CamelCase**, ou seja, iniciar a primeira palavra com a letra **minúscula** e e as demais iniciar com letra **maiúscula**.

### Comentários

Existem duas formas de escrever comentários em um código C#:

- **Linha Única**

```C#
// Este é um comentário em linha única ...
```

- **Múltiplas Linhas**

```C#
/*

Este é um comentário
em múltiplas linhas
...

*/
```

### Links Úteis

- [C# - Documentação Oficial](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [.NET Framework - Documentação Oficial](https://learn.microsoft.com/pt-br/dotnet/framework/)
- [Tutoriais do Visual Studio](https://learn.microsoft.com/pt-br/visualstudio/get-started/csharp/?view=vs-2022)