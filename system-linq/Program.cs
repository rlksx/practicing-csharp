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
                new Produto{Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 100},
                new Produto{Id = 3, CategoriaId = 1, Nome = "Maquina de Lavar", Status = true, Valor = 600},
                new Produto{Id = 4, CategoriaId = 1, Nome = "TV", Status = false, Valor = 230},
                new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto{Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 160},
                new Produto{Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 20},
                new Produto{Id = 6, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 150},
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
            var resultado3 = from produto in listaProdutos where produto.Nome == "Arroz" || produto.Nome == "Feijão" select produto;
            var resultado4 = from produto in listaProdutos where produto.Nome.ToLower() == "feijão" select produto;
            var resultado5 = from produto in listaProdutos where produto.Nome.ToLower().Substring(0, 2) == "m" select produto;
            var resultado6 = from produto in listaProdutos where produto.Valor >= 150 && produto.Status == true select produto;
            var resultado7 = from produto in listaProdutos orderby produto.Id select produto;
            var resultado8 = from produto in listaProdutos where produto.Id >= 3 && produto.Id < 6 orderby produto.Id descending select produto;

            // executar a consulta
            // foreach (var item in resultado3)
            //     Console.WriteLine($"{item.Id} - {item.Nome} | {item.CategoriaId}");

            /* order by */
            var result = from prod in listaProdutos group prod by prod.CategoriaId into produtosAgrupados select produtosAgrupados;
            var result2 = from prod in listaProdutos orderby prod.CategoriaId group prod by prod.CategoriaId into produtosAgrupados select produtosAgrupados;

            //  produtos agrupados por categoria order by
            // foreach (var item in result2)
            // {
            //     Console.WriteLine($"Categoria {item.Key}"); // Key => produtosAgrupados
            //     foreach (var prod in item)
            //     {
            //         Console.WriteLine($"  Id: {prod.Id} - Nome: {prod.Nome}");
            //     }
            // }

            /* join */
            var result3 = from prod in listaProdutos join cat in listCategoria on prod.CategoriaId equals cat.Id
            select new 
            {
                prod,
                cat
            };

            var result4 = from prod in listaProdutos join cat in listCategoria on prod.CategoriaId equals cat.Id orderby cat.Id select new
            {
                prod,
                cat

            };

            foreach (var item in result4)
                Console.WriteLine($"Produto: {item.prod.Nome} | {item.cat.Nome}");
        }
    }
}