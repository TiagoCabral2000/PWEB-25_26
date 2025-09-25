List<string> ListaStrings = new List<string>()
{
    "C#", "Entity Framework", "ASP.NET MVC com C#", 
    "Linq", "Lambda", "Identity Framework"
};


var ListA = new List<string>();
foreach (var x in ListaStrings)  //Simplesmente percorre "ListaStrings" - se uma string contiver 'c#', adiciona à ListA
    if (x.Contains("C#")) ListA.Add(x); 

var ListB = from s in ListaStrings  //query sintaxe
            where s.Contains("C#")
                            select s;

var ListC = ListaStrings.Where(l => l.Contains("C#")); //metodos de extensao


Console.WriteLine("Lista A:");
foreach (var x in ListA)
    Console.WriteLine(x);

Console.WriteLine("Lista B:");
foreach (var x in ListB)
    Console.WriteLine(x);

Console.WriteLine("Lista C:");
foreach (var x in ListC)
    Console.WriteLine(x);