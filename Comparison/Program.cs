using Comparison.Entities;
using System;
using System.Collections.Generic;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problema
            //Problema
            //• Suponha uma classe Product com os atributos name e price. Suponha que precisamos ordenar uma lista de objetos Product.
            //• Podemos implementar a comparação de produtos por meio da
            //implementação da interface IComparable<Product>
            //• Entretanto, desta forma nossa classe Product não fica fechada
            //para alteração: se o critério de comparação mudar,
            //precisaremos alterar a classe Product.
            //• Podemos então usar outra sobrecarga do método "Sort" da
            //classe List:
            //public void Sort(Comparison<T> comparison)
            #endregion

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));                              //compararison
            //list.Sort(CompareProducts);                                                                         //Delegate
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());              //Lambda
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));                                //Lambda inline
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }



        }

        //static int CompareProducts(Product p1, Product p2)                   //Delegate
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}

    }
}
