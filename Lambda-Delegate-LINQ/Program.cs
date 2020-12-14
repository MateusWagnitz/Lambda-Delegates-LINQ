
#region Teoria

//Comparison<T>(System)
//https://msdn.microsoft.com/en-us/library/tfakywbh(v=vs.110).aspx
//public delegate int Comparison<in T>(T x, T y);
//Método Sort com Comparison<T> da classe List:
//https://msdn.microsoft.com/en-us/library/w56d4y5z%28v=vs.110%29.aspx

//Resumo da aula
//public void Sort(Comparison<T> comparison)
//• Referência simples de método como parâmetro
//• Referência de método atribuído a uma variável tipo delegate
//• Expressão lambda atribuída a uma variável tipo delegate
//• Expressão lambda inline
//https://github.com/acenelio/lambda1-csharp


//Transparência referencial
//using System;
//namespace Course
//{
//    class Program
//    {
//        public static int globalValue = 3;
//        static void Main(string[] args)
//        {
//            int[] vect = new int[] { 3, 4, 5 };
//            ChangeOddValues(vect);
//            Console.WriteLine(string.Join(" ", vect));
//        }
//        public static void ChangeOddValues(int[] numbers)
//        {
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (numbers[i] % 2 != 0)
//                {
//                    numbers[i] += globalValue;
//                }
//            }
//        }
//    }
//}
//Uma função possui transparência referencial se seu resultado for sempre o mesmo
//para os mesmos dados de entrada. Benefícios: simplicidade e previsibilidade.
//Exemplo de
//função que não é
//referencialmente
//transparente
//Funções são objetos de primeira ordem (ou primeira classe)
//class Program
//{
//    static int CompareProducts(Product p1, Product p2)
//    {
//        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//    }
//    static void Main(string[] args)
//    {
//        List<Product> list = new List<Product>();
//        list.Add(new Product("TV", 900.00));
//        list.Add(new Product("Notebook", 1200.00));
//        list.Add(new Product("Tablet", 450.00));
//        list.Sort(CompareProducts);
//        (...)
//Isso significa que funções podem, por exemplo, serem passadas como parâmetros de
//    métodos, bem como retornadas como resultado de métodos.
//    Inferência de tipos
//    List<Product> list = new List<Product>();
//        list.Add(new Product("TV", 900.00));
//        list.Add(new Product("Notebook", 1200.00));
//        list.Add(new Product("Tablet", 450.00));
//        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
//        foreach (Product p in list)
//        {
//            Console.WriteLine(p);
//        }
//        Expressividade / "como" vs. "o quê"
//    int sum = 0;
//        foreach (int x in list)
//        {
//            sum += x;
//        }
//        vs.
//    int sum = list.Aggregate(0, (x, y) => x + y);
//        O que são "expressões lambda" ?
//        Em programação funcional, expressão lambda corresponde a uma
//        função anônima de primeira classe.
//class Program
//    {
//        static int CompareProducts(Product p1, Product p2)
//        {
//            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//        }
//        static void Main(string[] args)
//        {
//            (...)
//list.Sort(CompareProducts);
//            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
//            (...)

//_________________________________________________________________________________________
//Resumo da aula

//        Cálculo Lambda = formalismo matemático base da programação funcional
//        Expressão lambda = função anônima de primeira classe


//Delegates
//• https://docs.microsoft.com/en-us/dotnet/standard/delegates-lambdas
//• É uma referência (com type safety) para um ou mais métodos
//• É um tipo referência
//• Usos comuns:
//• Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
//• Parametrização de operações por métodos (programação funcional)
//Delegates pré-definidos
//• Action
//• Func
//• Predicate

//_________________________________________________________________________________________
//Multicast delegates
//• Delegates que guardam a referência para mais de um método
//• Para adicionar uma referência, pode-se usar o operador +=
//• A chamada Invoke (ou sintaxe reduzida) executa todos os métodos na
//ordem em que foram adicionados
//• Seu uso faz sentido para métodos void

//_________________________________________________________________________________________
//Predicate(System)
//• Representa um método que recebe um objeto do tipo T e retorna um
//valor booleano
//• https://msdn.microsoft.com/en-us/library/bfcke1bz%28v=vs.110%29.aspx
//public delegate bool Predicate<in T>(T obj);
//Problema exemplo
//Fazer um programa que, a partir de uma lista de produtos, remova da
//lista somente aqueles cujo preço mínimo seja 100.
//List<Product> list = new List<Product>();
//list.Add(new Product("Tv", 900.00));
//list.Add(new Product("Mouse", 50.00));
//list.Add(new Product("Tablet", 350.50));
//list.Add(new Product("HD Case", 80.90));

//_________________________________________________________________________________________
//Action
//Action(System)
//• Representa um método void que recebe zero ou mais argumentos
//• https://msdn.microsoft.com/en-us/library/system.action%28v=vs.110%29.aspx
//public delegate void Action();
//public delegate void Action<in T>(T obj);
//public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
//public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
//(16 sobrecargas)

//Func(System)
//• Representa um método que recebe zero ou mais argumentos, e retorna
//um valor
//• https://msdn.microsoft.com/en-us/library/bb534960%28v=vs.110%29.aspx
//public delegate TResult Func<out TResult>();
//public delegate TResult Func<in T, out TResult>(T obj);
//public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
//public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2
//arg2, T3 arg3);
//(16 sobrecargas)

//_________________________________________________________________________________________
//LINQ - Language Integrated Query
//• É um conjunto de tecnologias baseadas na integração de funcionalidades de
//consulta diretamente na linguagem C#
//• Operações chamadas diretamente a partir das coleções
//• Consultas são objetos de primeira classe
//• Suporte do compilador e IntelliSense da IDE
//• Namespace: System.Linq
//• Possui diversas operações de consulta, cujos parâmetros tipicamente são
//expressões lambda ou expressões de sintaxe similar à SQL
//• Referência:
//• https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/index
//Três passos
//• Criar um data source (coleção, array, recurso de E/S, etc.)
//• Definir a query
//• Executar a query (foreach ou alguma operação terminal)

//Operações do LINQ
//• Filtering: Where, OfType
//• Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
//• Set: Distinct, Except, Intersect, Union
//• Quantification: All, Any, Contains
//• Projection: Select, SelectMany
//• Partition: Skip, Take
//• Join: Join, GroupJoin
//• Grouping: GroupBy
//• Generational: Empty
//• Equality: SequenceEquals
//• Element: ElementAt, First, FirstOrDefault
//Last, LastOrDefault, Single, SingleOrDefault
//• Conversions: AsEnumerable, AsQueryable
//• Concatenation: Concat
//• Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum
//Referências
//• https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b/view/SamplePack/1?sortBy=Popularity
//• https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b/view/SamplePack/2?sortBy=Popularity
//• https://odetocode.com/articles/739.aspx


//Resumo da aula
//• Where (operação "filter" / "restrição")
//• Select(operação "map" / "projeção")
//• OrderBy, OrderByDescending, ThenBy, ThenByDescending
//• Skip, Take
//• First, FirstOrDefault Last, LastOrDefault, Single, SingleOrDefault
//• Max, Min, Count, Sum, Average, Aggregate (operação "reduce")
//• GroupBy

//Operações básicas da álgebra relacional
//• Restrição
//• Projeção
//• Produto cartesiano
//• Junção (produto cartesiano + restrição de chaves correspondentes)

#endregion




using System;

namespace Lambda_Delegate_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
