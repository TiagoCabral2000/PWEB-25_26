using System.Security.Cryptography.X509Certificates;

string[] ListaUm = { "C#", "Aprender C#","ASP.NET MVC com C#",
    "Entity Framework","Bootstrap","Identity",
    "Lambda","Delegates","Linq","POO com C# "
};
string[] ListaDois = { "C#", "ASP.NET MVC", "Linq", "Lambda e C#" };
int[] Numeros = { 10, 23, 54, 77, 85, 12, 1, 4, 53 };

// ______________ Alinea a) ______________
// Obtenha a lista de todos os elementos da ListaUm, ordenados por ordem alfabética
var listaA = new List<string>();
listaA = ListaUm.OrderBy(x => x).ToList(); //insere cada elemento da ListaUm na lista na posição certa ordenada alfabeticamente

Console.WriteLine("\n -> ALINEA a):");
foreach (var x in listaA)
    Console.WriteLine(x);

// ______________ Alinea b) ______________
// Obtenha a lista de todos os elementos da ListaUm que tenham menos de seis carateres
var listaB = new List<string>();
listaB = ListaUm.Where(x => x.Length < 6).ToList();

Console.WriteLine("\n -> ALINEA b):");
foreach (var x in listaB)
    Console.WriteLine(x);

// ______________ Alinea c) ______________
// Apresente o número total de elementos da ListaUm que incluem o texto “C#"

var listaC = new List<string>();
listaC = ListaUm.Where(x => x.Contains("C#")).ToList();

Console.WriteLine("\n -> ALINEA c):");
foreach (var x in listaC)
    Console.WriteLine(x);
Console.WriteLine("TOTAL: {0}", listaC.Count);

// ______________ Alinea d) ______________
// Construa uma lista em que cada elemento da lista representa o número de palavras de cada
// um dos elementos da ListaUm. Considere que o carater espaço é o separador entre as
// palavras e que não existe mais do que um espaço entre as palavras

var numeropalavras = ListaUm.Select(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);

Console.WriteLine("\n -> Alinea d)");
foreach (var n in numeropalavras)
    Console.WriteLine(n);


// ______________ Alinea e) ______________
// Calcule a média dos elementos de Numeros

var media = (from n in Numeros
    select n).Average();
Console.WriteLine("\n -> Alinea e)");
Console.WriteLine(media);
// Alternativa: Console.WriteLine(Numeros.Average());


// ______________ Alinea f) ______________
// Obtenha o valor máximo existente no conjunto Numeros

var maximo = (from n in Numeros
    select n).Max();

Console.WriteLine("\n -> Alinea f)");
Console.WriteLine(maximo);
// Alternativa: Console.WriteLine(Numeros.Max());

// ______________ Alinea g) ______________
// Obtenha o conjunto de elementos de Numeros que pertençam ao intervalo [1, 25],
// ordenados por ordem decrescente

var exercicio6 = Numeros.Where(n => n > 1 && n <= 25).OrderByDescending(n => n);

Console.WriteLine("\n -> Alinea g)");
foreach (var x in exercicio6)
    Console.WriteLine(x);


// ______________ Alinea h) ______________
// Obtenha o conjunto definido pelos elementos comuns às duas listas, ListaUm e ListaDois.
// O conjunto definido é a interceção da ListaUm com a ListaDois

Console.WriteLine("\n -> Alinea h)");
Console.WriteLine("\n----- Alinea h1) -----");
var intersecao = from s in ListaUm
    where ListaDois.Contains(s)
    select s;

var intersecao2 = ListaUm.Intersect(ListaDois);

foreach (var x in intersecao)
    Console.WriteLine(x);

Console.WriteLine("\n----- Alinea h2) -----");
foreach (var x in intersecao2)
    Console.WriteLine(x);

// ______________ Alinea i) ______________
// Obtenha o conjunto definido por todos os elementos das listas ListaUm e ListaDois e no
// qual não devem existir elementos repetidos. O conjunto definido é a reunião da ListaUm
// com a ListaDois

var reuniao = ListaUm.Union(ListaDois);

Console.WriteLine("\n -> Alinea i)");
foreach (var x in reuniao)
    Console.WriteLine(x);

// ______________ Alinea j) ______________
// Agrupe os elementos existentes em Numeros em grupo de números pares e ímpares

//se quero ter uma lista de nums pares e uma de impares, vou agrupar o conjunto de numeros pelo resultado do resto da divisao

var solucao = Numeros.GroupBy(n => n % 2);

Console.WriteLine("\n -> Alinea j)");
foreach (var x in solucao)
{
    Console.WriteLine();
    Console.Write(x.Key == 0 ? "Numeros Pares: " : "Numeros Impares: ");
    foreach (var y in x) Console.Write(y + " ");
}

// ______________ Alinea k) ______________
// Obtenha o produto de todos os números (pertencentes a Numeros) inferiores a trinta

var produto = Numeros.Where(n => n < 30).Aggregate((a, b) => a * b);

Console.WriteLine("\n -> Alinea k)");
Console.WriteLine(produto);

// ______________ Alinea l) ______________
//Obtenha e apresente a lista de todos os elementos que tenham a palavra C# e, para cada
// elemento, apresente a primeira e a última palavra (Listagem 2). Se no elemento existir
// apenas uma palavra (como no primeiro caso de Listagem 2) deve mostrar “NÃO TEM” na
// “última palavra”. Considere o seguinte ciclo foreach para apresentar o resultado da
// instrução a implementar:

var strings = ListaUm.Where(s => s.Contains("C#"));

var solucao2 = from s in strings
    let palavras = s.Split(' ', StringSplitOptions.RemoveEmptyEntries)
    select new
    {
        str = s,
        sInicial = palavras.First(),
        sFinal = (palavras.Length > 1) ? palavras.Last() : "NÃO TEM"
    };


Console.WriteLine("\n -> Alinea l)");
foreach (var s in solucao2)
    Console.WriteLine("String: " + s.str + "\n\t Primeira Palavra: "
                      + s.sInicial + "\n\t Ultima Palavra: " + s.sFinal);