﻿using System;
using System.Linq;

namespace system_linq {
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            // fonte de 2
            var listaProdutos = new List<Produto>()
            {
                new Produto{Id = 2, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 100},
                new Produto{Id = 2, CategoriaId = 1, Nome = "Maquina de Lavar", Status = true, Valor = 600},
                new Produto{Id = 4, CategoriaId = 1, Nome = "TV", Status = false, Valor = 230},
                new Produto{Id = 3, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto{Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 160},
                new Produto{Id = 7, CategoriaId = 3, Nome = "Short", Status = true, Valor = 20},
                new Produto{Id = 6, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 150},
            };

            var listCategoria = new List<Categoria>() 
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{Id = 3, Status = true, Nome = "Vestuario"}
            };

            /* First e Last*/
            // OrDefault retorna o valor padrão do tipo.
            // var result = listaProdutos.First(x => x.Id == 70);
            // var result2 = listaProdutos.FirstOrDefault(x => x.Id == 70);

            // var result3 = listaProdutos.Last(x => x.Id == 1);
            // var result4 = listaProdutos.LastOrDefault(); 

            /* Single */
            // se houver mais que um elemento com mesmo valor ocorre um erro:
            // System.InvalidOperationException: Sequence contains more than one matching element.
            // var result5 = listaProdutos.Single(x => x.Id == 2);

            var result6 = listaProdutos.SingleOrDefault(x => x.Id == 2);
 
            Console.WriteLine($"{result6?.Id} - Nome: {result6?.Nome}");

            Console.ReadKey();
        }
    }
}