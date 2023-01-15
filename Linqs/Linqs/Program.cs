using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqs
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Lista 
            var listaItens = new List<Item>()
            {
                new Item{Id = 3, Name = "Celular", Categoria = 1, Status = true, Valor = 2000, Categorias =
                    new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 1, Name = "Eletronico", Status = true
                        }
                    }
                },
                new Item{Id = 2, Name = "Computador", Categoria = 1, Status = true, Valor = 4000,  Categorias =
                    new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 1, Name = "Eletronico", Status = true
                        }
                    }
                },
                new Item{Id = 1, Name = "Geladeira", Categoria = 1, Status = true, Valor = 2500,  Categorias =
                    new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 1, Name = "Eletronico", Status = true
                        }
                    }
                },
                new Item{Id = 4, Name = "Microondas", Categoria = 1, Status = true, Valor = 350,  Categorias =
                    new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 1, Name = "Eletronico", Status = true
                        }
                    }
                },
                new Item{Id = 5, Name = "Tapete", Categoria = 4, Status = true, Valor = 60,  Categorias =
                    new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 4, Name = "Casa", Status = true
                        }
                    }
                }
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria{ Id = 1, Name = "Eletronico", Status = true},
                new Categoria{ Id = 2, Name = "Alimento", Status = true},
                new Categoria{ Id = 3, Name = "Vestuario", Status = true},
                new Categoria{ Id = 4, Name = "Casa", Status = true}
            };

            //Linq Filtragem de primeiro, ultimo ou unico
            //var resultado = listaItens.First();
            //var resultado = listaItens.FirstOrDefault();
            //var resultado = listaItens.FirstOrDefault(x => x.Id == 70);
            //var resultado = listaItens.Last();
            //var resultado = listaItens.LastOrDefault(x => x.Id == 70);
            //var resultado = listaItens.Single(x => x.Id == 4);

            //Console.WriteLine($"Nome: {resultado.Name} | Status: {resultado.Status}");

            //Console.ReadLine();

            //--------------------------------------------------------------------------------

            //Linq filtro e ordenação
            //where
            //var resultado = listaItens.Where(x => x.Id >= 2 && x.Id <= 5);
            //var resultado = listaItens.Where(x => x.Id == 2 || x.Id == 4);
            //var resultado = listaItens.Where(x => FiltraProdutoPorValor(x));

            //Order By
            //resultado = resultado.OrderBy(x => x.Id);

            //Order By Descending
            //resultado = resultado.OrderByDescending(x => x.Id);

            //Revert
            //resultado = resultado.Reverse();

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"ID: {item.Id} | Nome {item.Name}");
            //}
            //Console.ReadLine();


            //--------------------------------------------------------------------------------


            //Select 

            //Transformando o Objeto
            //var response = listaItens.Select(x => new ProdutoResponse() 
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    Valor = x.Valor
            //});
            //foreach (var i in response)
            //{
            //    Console.WriteLine($"Id: {i.Id} Nome:{i.Name} Valor:{i.Valor}");
            //}


            //Selecionando coluna especifica
            //var response = listaItens.Select(x => x.Name);
            //foreach (var i in response)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //Console.ReadLine();

            //SelectMany - retorna uma lista dentro de um objeto 
            //var listaCategoria = listaItens.SelectMany(x => x.Categorias);

            //foreach (var i in listaCategoria)
            //{
            //    Console.WriteLine($"{i.Id} {i.Name}");
            //}

            //Console.ReadLine();

            //SelectMany - retornando apenas uma dado de cada item da lista
            //var listaCategoria = listaItens.SelectMany(x => new 
            //List<string>(x.Categorias.Select(y => y.Name)));

            //foreach (var name in listaCategoria)
            //{
            //    Console.WriteLine($"{name}");
            //}

            //Console.ReadLine();


            //--------------------------------------------------------------------------------


            //Take e Skip
            //Pegar itens da lista de acordo com sua ordem 
            //var tresPrimeiros = listaItens.Take(3);

            //Ignora iens da lista de acordo com sua ordem
            //var dispensaTresPrimeiros = listaItens.Skip(3);

            //Pegar produtos do meio por take e skip
            //var response = listaItens.Skip(1).Take(3);

            //Console.WriteLine(" 3 Primeiros ");
            //foreach (var item in tresPrimeiros)
            //{
            //    Console.WriteLine($"Id: {item.Id} | Name: {item.Name}");
            //}

            //Console.WriteLine(" Depois  dos 3 Primeiros ");
            //foreach (var item in dispensaTresPrimeiros)
            //{
            //    Console.WriteLine($"Id: {item.Id} | Name: {item.Name}");
            //}

            //foreach (var item in response)  
            //{
            //    Console.WriteLine($"Id: {item.Id}, Nome: {item.Name}");
            //}

            //Console.ReadLine();


            //--------------------------------------------------------------------------------


            //Valor total da lista
            var valortotal = listaItens.Sum(x => x.Valor);

            //valor da média dos produtos
            var mediaValorProdutos = listaItens.Average(x => x.Valor);

            //quantidade de itens na lista
            var qtd = listaItens.Count();
            var qtdMaior90 = listaItens.Count(x => x.Valor > 90);

            Console.WriteLine($"valor total {valortotal}");
            Console.WriteLine($"media {mediaValorProdutos}");
            Console.WriteLine($"quantidade {qtd}");
            Console.WriteLine($"quantidade {qtdMaior90}");

            //cria uma lista com um range de numero
            var range = Enumerable.Range(1, 15);
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            //cria uma lista com itens semelhantes
            var produtosIguais = Enumerable.Repeat(new Item() { Id = 1 }, 5);
            foreach (var item in produtosIguais)
            {
                Console.WriteLine(item.Id);
            }

            Console.ReadLine();
        }

        //static bool FiltraProdutoPorValor(Item item)
        //{
        //    return item.Valor > 50;
        //}
    }
}
