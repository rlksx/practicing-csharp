﻿﻿using System;
using System.Linq;

namespace system_linq {
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // fonte de dados
            var listaProdutos = new List<Produto>()
            {
                new Produto{Id = 1, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 100},
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

            /* sintaxe de método usando lambdaaaaaaaaa :) */
            var result = listaProdutos.Where(x => x.Id >= 2 && x.Id <= 6);
            result = result.OrderBy(x => x.Id);
            result = result.OrderByDescending(x => x.Id);
            result = result.Reverse();


            var result2 = listaProdutos.Where( x => FiltrarProdutoPorValor(x) );
            /* filtrando */
            static bool FiltrarProdutoPorValor(Produto produto) => produto.Valor > 60;

            // foreach (var item in result2)
            //     // Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} R${item.Valor}");
            
            /* Skip e Take */
            var result3 = listaProdutos.Skip(3).Take(3);

        foreach (var item in result3)
            Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Valor: R${item.Valor}");


            Console.ReadKey();
        }
    }
}