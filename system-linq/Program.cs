using System;
using System.Linq;

namespace system_linq {
    class Program
    {
        public static void Main(string[] args)
        {
            // fonte de dados
            var listaProdutos = new List<Produto>()
            {
                new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto{Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 20},
                new Produto{Id = 3, CategoriaId = 1, Nome = "Xbox 360", Status = true, Valor = 600},
                new Produto{Id = 4, CategoriaId = 1, Nome = "TV", Status = true, Valor = 230},
                new Produto{Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 80},
                new Produto{Id = 6, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 150},
                new Produto{Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 100}
            };

            var listCategoria = new List<Categoria>() 
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{Id = 3, Status = true, Nome = "Vestuario"}
            };

            // criar consulta linq
            
            /* selecinando todos os produtos, sem filtros */
            var resultado1 = from produto in listaProdutos select produto;
            /* filtrando resultado */ /* SQL sintaxe kkk */
            var resultado2 = from produto in listaProdutos where produto.Valor > 150 select produto;

            // executar a consulta
            foreach (var item in resultado2)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} | {item.CategoriaId}");
            }
        }
    }
}