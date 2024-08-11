# C# - Básico

**C#** é uma linguagem de programação moderna, robusta e de propósito geral, desenvolvida pela **Microsoft**. Ela foi projetada para ser simples, eficiente e orientada a objetos. C# oferece recursos avançados de programação, como tratamento de exceções, coleta de lixo automática e suporte a tipos de dados avançados, além de ser altamente integrada com o ecossistema **.NET**.

O .NET, por sua vez, é uma plataforma de desenvolvimento criada pela Microsoft, que inclui uma vasta coleção de bibliotecas, ferramentas e componentes para construir e executar aplicativos em diferentes sistemas operacionais e plataformas.

### Hello, World!

Abaixo é apresentado um simples trecho de código na linguagem C# que tem objetivo de exibir em um console (linha de comando) a mensagem **Hello, World!**.

```C#
Console.WriteLine("Hello, World!");
```

- ``Console`` é uma classe fornecida pelo C# que contém atributos e métodos para realizar operações de entrada e saída no console (linha de comando).
- ``WriteLine()`` é um método da classe Console usado para escrever um texto no console (linha de comando).
- ``"Hello, World!"`` é basicamente a mensagem que será exibida no console (linha de comando).
- ``;`` é um delimitador de instruções em C#, ou seja, ele indica o fim de uma instrução.

### Variáveis

C# é uma linguagem de programação **fortemente tipada**, isso quer dizer que cada variável declarada deve receber um tipo.

Os principais tipos de dados em C# são:

- ``int`` é um tipo de dado numérico de precisão inteira. Ele armazena números inteiros sem decimais.
- ``double`` é um tipo de dado numérico de ponto flutuante de precisão dupla. Ele é usado para armazenar números com decimais.
- ``char`` representa um único caractere Unicode. É usado para armazenar caracteres individuais, como letras, números e símbolos.
- ``string`` é um tipo de dado que representa uma sequência de caracteres. É usado para armazenar texto.
- ``bool`` representa um valor booleano, que pode ser ``true`` (verdadeiro) ou ``false`` (falso).

A declaração de uma nova variável em C# deve seguir a seguinte regra:

```C#
tipo nome = valor;
```

**Exemplo(s):**

```C#
string nome = "Fábio";
int idade = 30;
double altura = 1.90;
char sexo = "M";
bool estaSolteiro = true;
```

C# é **Case Sensitive**, isso significa que ``variavelA`` e ``VariavelA`` por exemplo, são consideradas diferentes devido à sensibilidade a letras **maiúsculas** e **minúsculas**, e ambas podem coexistir sem conflito. Este conceito se aplica a todos os tipos de identificadores como nomes de variáveis, funções, classes e outros elementos do código.

Caso o nome da variável seja composto, deve seguir o padrão **CamelCase**, ou seja, iniciar a primeira palavra com a letra **minúscula** e e as demais iniciar com letra **maiúscula**.

Caso o conteúdo de uma variável do tipo ``string`` possua muitos caracteres especiais ou quebras de linha, é recomendado a utilização de um tipo especial denominado **Verbatim Literal**. Ele é útil para criar strings que contenham muitas barras invertidas ou que precisam incluir múltiplas linhas.

**Exemplo(s):**

```C#
string caminhoDoArquivo = @"C:\Usuários\Usuário\Anotações.txt";
string textoMultilinha = @"Este
                           texto
                           possui
                           várias
                           linhas
                           ...";

```

O conteúdo de uma variável do tipo ``string`` pode ser "intercalado" entre strings e variáveis utilizando dois conceitos:

- **Concatenação**

```C#
string nome = "Fábio";
Console.WriteLine("Olá, meu nome é " + nome + "."); // Olá, meu nome é Fábio.
```

- **Interpolação**

```C#
string nome = "Fábio";
Console.WriteLine($"Olá, meu nome é {nome}."); // Olá, meu nome é Fábio.
```

```C#
string nome = "Fábio";
Console.WriteLine($"Olá, meu nome é {0}.", nome); // Olá, meu nome é Fábio.
```

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

### Funções

A declaração de uma nova função em C# deve seguir a seguinte regra:

```C#
tipo Nome()
{
    // Código ...
}
```

**Exemplo(s):**

```C#
void MostrarMeuNome()
{
    Console.WriteLine("Fábio");
}

MostrarMeuNome(); // Fábio
```

O termo reservado ``void`` indica que a função não irá retornar nenhum valor.

Caso o nome da função seja composto, deve seguir o padrão **PascalCase**, ou seja, todas as palavras devem iniciar com letra **maiúscula**.

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

#### Matemático

Os principais operadores matemáticos (aritméticos) em C# são:

``+`` adição

``-`` subtração

``*`` multiplicação

``/`` divisão

``%`` módulo (resto)

``++`` incremento

``--`` decremento

### Estruturas de Decisão

#### If ...

A declaração de uma estrutura de decisão ``if ...`` em C# deve seguir a seguinte regra:

```C#
if (condição)
{
    // Código quando a "condição" for verdadeira ...
}
```

**Exemplo(s):**

```C#
int idade = 30;

if (idade >= 18)
{
    Console.WriteLine("Possui maioridade civil.");
}
```

#### If ... Else ...

A declaração de uma estrutura de decisão ``if ... else ...`` em C# deve seguir a seguinte regra:

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

**Exemplo(s):**

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

A declaração de uma estrutura de decisão ``if ... else if ... else ...`` em C# deve seguir a seguinte regra:

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

**Exemplo(s):**

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

A declaração de uma estrutura de decisão ``switch`` em C# deve seguir a seguinte regra:

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

**Exemplo(s):**

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

### Coleções

#### Listas

A declaração de uma lista em C# deve seguir a seguinte regra:

```C#
List<tipo> nome = new List<tipo>();
```

**Exemplo(s):**

```C#
List<string> paises = new List<string>();

paises.Add("Brasil");
paises.Add("Áustria");
paises.Add("Estados Unidos");

Console.WriteLine(paises[0]); // Brasil
Console.WriteLine(paises[1]); // Áustria
Console.WriteLine(paises[2]); // Estados Unidos
```

### Estruturas de Repetição

#### For

A declaração de um ``for`` em C# deve seguir a seguinte regra:

```C#
for (inicialização; condição; incremento)
{
    // Código a ser executado ...
}
```

**Exemplo(s):**

```C#
List<string> paises = new List<string>();

paises.Add("Brasil");
paises.Add("Áustria");
paises.Add("Estados Unidos");

for (int indice = 0; indice < paises.Count; indice++)
{
    Console.WriteLine(paises[indice]);
}

// Brasil
// Áustria
// Estados Unidos
```

#### ForEach

A declaração de um ``foreach`` em C# deve seguir a seguinte regra:

```C#
foreach (tipo elemento in colecao)
{
    // Código a ser executado para cada elemento ...
}
```

**Exemplo(s):**

```C#
List<string> paises = new List<string>();

paises.Add("Brasil");
paises.Add("Áustria");
paises.Add("Estados Unidos");

foreach (string pais in paises)
{
    Console.WriteLine(pais);
}

// Brasil
// Áustria
// Estados Unidos
```

### Links Úteis

- [C# - Documentação Oficial](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [.NET Framework - Documentação Oficial](https://learn.microsoft.com/pt-br/dotnet/framework/)
- [Tutoriais do Visual Studio](https://learn.microsoft.com/pt-br/visualstudio/get-started/csharp/?view=vs-2022)
- [W3 Schools - C#](https://www.w3schools.com/cs/index.php)