# C# - Básico

Este repositório tem por objetivo registrar anotações e armazenar projetos práticos pertinentes aos meus estudos da linguagem de programação C# básico no curso [C# - Criando Sua Primeira Aplicação](https://www.alura.com.br/curso-online-csharp-criando-primeira-aplicacao) da plataforma de estudos [Alura](https://www.alura.com.br/).

### Sumário

- [A Linguagem](#a-linguagem)
- [A Plataforma](#a-plataforma)
- [Hello World](#hello-world)
- [Comentários](#comentários)
- [Tipos de Dados](#tipos-de-dados)
- [Variáveis](#variáveis)
- [Operadores](#operadores)
- [Estruturas de Condição](#estruturas-de-condição)
- [Estruturas de Repetição](#estruturas-de-repetição)
- [Funções](#funções)
- [Links Úteis](#links-úteis)

### A Linguagem

**C#** é uma linguagem de programação moderna, robusta e de propósito geral, desenvolvida pela **Microsoft**. Ela foi projetada para ser simples, eficiente e orientada a objetos. C# oferece recursos avançados de programação, como tratamento de exceções, coleta de lixo automática e suporte a tipos de dados avançados, além de ser altamente integrada com o ecossistema **.NET**.

### A Plataforma

O .NET, por sua vez, é uma plataforma de desenvolvimento criada pela Microsoft, que inclui uma vasta coleção de bibliotecas, ferramentas e componentes para construir e executar aplicativos em diferentes sistemas operacionais e plataformas.

### Hello World

Abaixo é apresentado um simples trecho de código na linguagem C# que tem objetivo de exibir em um console (linha de comando) a famosa mensagem **Hello, World!**.

```C#
Console.WriteLine("Hello, World!");
```

- ``Console`` é uma classe fornecida pelo C# que contém atributos e métodos para realizar operações de entrada e saída no console (linha de comando).
- ``WriteLine`` é um método da classe Console usado para escrever um texto no console (linha de comando).
- ``"Hello, World!"`` é basicamente a mensagem que será exibida no console (linha de comando).
- ``;`` é um delimitador de instruções em C#, ou seja, ele indica o fim de uma instrução.

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

### Tipos de Dados

C# é uma linguagem de programação **fortemente tipada**, isso permite que um novo dado receba um tipo no momento de sua instância.

Os principais tipos de dados em C# são:

#### int

``int`` é um tipo de dado numérico de precisão inteira. Ele armazena números inteiros sem decimais.

#### double

``double`` é um tipo de dado numérico de ponto flutuante de precisão dupla. Ele é usado para armazenar números com decimais.

#### char

``char`` representa um único caractere UNICODE. É usado para armazenar caracteres individuais, como letras, números e símbolos.

> Ao declarar um caractere ``char`` deve-se utilizar aspas simples (').

#### string

``string`` é um tipo de dado que representa uma sequência de caracteres. É usado para armazenar texto.

> Ao declarar uma ``string`` deve-se utilizar aspas duplas (").

#### Concatenação

Consiste em unir duas ou mais strings para formar uma nova string utilizando o operador ``+``.

**Exemplo:**

```C#
string nome = "Fábio";
Console.WriteLine("Olá, meu nome é " + nome + "."); // Olá, meu nome é Fábio.
```

#### Interpolação

Consiste em unir duas ou mais strings para formar uma nova string de uma forma mais moderna e legível utilizando o operador ``$`` antes das aspas que delimitam a string.

**Exemplo:**

```C#
string nome = "Fábio";
Console.WriteLine($"Olá, meu nome é {nome}."); // Olá, meu nome é Fábio.
```

```C#
string nome = "Fábio";
Console.WriteLine($"Olá, meu nome é {0}.", nome); // Olá, meu nome é Fábio.
```

#### Verbatim Literal

Consiste em incluir caracteres especiais, como quebras de linha e barras invertidas, sem precisar de escape. Isso é feito usando o prefixo ``@`` antes das aspas que delimitam a string.

**Exemplo:**

```C#
string caminhoDoArquivo = @"C:\Usuários\Usuário\Anotações.txt";
string textoMultilinha = @"Linha 1
                           Linha 2
                           Linha 3";
```

#### bool

``bool`` representa um valor booleano, que pode ser ``true`` (verdadeiro) ou ``false`` (falso).

### Variáveis

A declaração de uma nova variável em C# deve seguir a seguinte regra:

```C#
tipo nome = valor;
```

**Exemplo:**

```C#
string nome = "Fábio";
int idade = 30;
double altura = 1.90;
char sexo = 'M';
bool estaSolteiro = true;
```

> C# é **Case Sensitive**. Isso significa que as variáveis ``variavelA`` e ``VariavelA`` por exemplo, são consideradas diferentes devido à sensibilidade a letras **maiúsculas** e **minúsculas**, e ambas podem coexistir sem conflito. Este conceito se aplica a todos os tipos de identificadores como nomes de variáveis, funções, classes e outros elementos do código.

> O nome da variável deve seguir o padrão **CamelCase**. Isso significa que se o nome da variável for composto deve-se iniciar a primeira palavra com a letra **minúscula** e as demais iniciar com a letra **maiúscula**.

### Coleções

#### Listas

A declaração de uma lista em C# deve seguir a seguinte regra:

```C#
List<tipo> nome = new List<tipo>();
```

**Exemplo:**

```C#
List<string> paises = new List<string>();

paises.Add("Áustria");
paises.Add("Brasil");
paises.Add("Estados Unidos");

Console.WriteLine(paises[1]); // Áustria
Console.WriteLine(paises[0]); // Brasil
Console.WriteLine(paises[2]); // Estados Unidos
```

### Operadores

#### Atribuição

Os principais operadores de atribuição em C# são:

``=`` simples

``+=`` adicional

``-=`` subtrativo

#### Comparação

Os principais operadores de comparação em C# são:

``==`` igual à ...

``!=`` diferente de ...

``>`` maior que ...

``<`` menor que ...

``>=`` maior ou igual que ...

``<=`` menor ou igual que ...

#### Lógicos

Os principais operadores lógicos em C# são:

``&&`` e

``||`` ou

``!`` negação

#### Matemáticos

Os principais operadores matemáticos (aritméticos) em C# são:

``+`` adição

``-`` subtração

``*`` multiplicação

``/`` divisão

``%`` módulo (resto)

``++`` incremento

``--`` decremento

### Estruturas de Condição

#### If

A declaração de uma estrutura de condição ``if ...`` em C# deve seguir a seguinte regra:

```C#
if (condição)
{
    // Código quando a "condição" for verdadeira ...
}
```

**Exemplo:**

```C#
int idade = 30;

if (idade >= 18)
{
    Console.WriteLine("Possui maioridade civil.");
}
```

#### If ... Else ...

A declaração de uma estrutura de condição ``if ... else ...`` em C# deve seguir a seguinte regra:

```C#
if (condição)
{
    // Código quando a "condição" for verdadeira ...
}
else
{
    // Código quando a "condição" for falsa ...
}
```

**Exemplo:**

```C#
int idade = 30;

if (idade >= 18)
{
    Console.WriteLine("Possui maioridade civil.");
}
else
{
    Console.WriteLine("Não possui maioridade civil.");
}
```

#### If ... Else If ... Else ...

A declaração de uma estrutura de condição ``if ... else if ... else ...`` em C# deve seguir a seguinte regra:

```C#
if (condição a)
{
    // Código quando a "condição a" for verdadeira ...
}
else if (condição b)
{
    // Código quando a "condição b" for verdadeira ...
}
else
{
    // Código quando a "condição a" e a "condição b" for falsa ...
}
```

**Exemplo:**

```C#
int idade = 30;

if (idade <= 12)
{
    Console.WriteLine("Criança.");
}
else if (idade <= 17)
{
    Console.WriteLine("Adolescente.");
}
else if (idade <= 64)
{
    Console.WriteLine("Adulto.");
}
else
{
    Console.WriteLine("Idoso.");
}
```

#### Switch

A declaração de uma estrutura de condição ``switch`` em C# deve seguir a seguinte regra:

```C#
switch(expressão) 
{
    case x:
        // Código quando a condição for satisfeita ...
        break;
    case y:
        // Código quando a condição for satisfeita ...
        break;

    ...

    default:
        // Código quando nenhuma das condições anteriores for satisfeita ...
        break;
}
```

**Exemplo:**

```C#
int dia = 4;

switch (dia)
{
    case 1:
        Console.WriteLine("Segunda-feira");
        break;
    case 2:
        Console.WriteLine("Terça-feira");
        break;
    case 3:
        Console.WriteLine("Quarta-feira");
        break;
    case 4:
        Console.WriteLine("Quinta-feira");
        break;
    case 5:
        Console.WriteLine("Sexta-feira");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
        break;
}
```

### Estruturas de Repetição

#### For

A declaração de uma estrutura de repetição ``for`` em C# deve seguir a seguinte regra:

```C#
for (inicialização; condição; incremento)
{
    // Código a ser executado enquanto a condição for verdadeira ...
}
```

**Exemplo:**

```C#
for (int indice = 0; indice < 5; indice++)
{
    Console.WriteLine("Fábio");
}

// Fábio
// Fábio
// Fábio
// Fábio
// Fábio
```

#### ForEach

A declaração de uma estrutura de repetição ``foreach`` em C# deve seguir a seguinte regra:

```C#
foreach (tipo elemento in coleção)
{
    // Código a ser executado para cada elemento da coleção ...
}
```

**Exemplo:**

```C#
List<string> paises = new List<string>();

paises.Add("Áustria");
paises.Add("Brasil");
paises.Add("Estados Unidos");

foreach (string pais in paises)
{
    Console.WriteLine(pais);
}

// Áustria
// Brasil
// Estados Unidos
```

### Funções

A declaração de uma nova função em C# deve seguir a seguinte regra:

```C#
tipo Nome()
{
    // Código ...
}
```

**Exemplo:**

```C#
void MostrarMeuNome()
{
    Console.WriteLine("Fábio");
}

MostrarMeuNome(); // Fábio
```

> O termo reservado ``void`` indica que a função não irá retornar nenhum valor.

> O nome da função deve seguir o padrão **PascalCase**. Isso significa que se o nome da função for composto todas as palavras devem iniciar com letra **maiúscula**.

### Links Úteis

- [C# - Documentação Oficial](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [.NET Framework - Documentação Oficial](https://learn.microsoft.com/pt-br/dotnet/framework/)
- [Tutoriais do Visual Studio](https://learn.microsoft.com/pt-br/visualstudio/get-started/csharp/?view=vs-2022)
- [W3 Schools - C#](https://www.w3schools.com/cs/index.php)