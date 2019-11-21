using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Margille.Models;

namespace Margille.Data
{
    public class SeedingService
    {
        private MargilleContext _context;

        // Toda vez que uma instância de SeedingService for criada, também será criada uma instância do context.
        public SeedingService(MargilleContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // Testar se já existe algum dado na minha base de dados
            // A operação ANY do LINQ vai verificar se há algum registro nesta tabela
            if (    _context.Client.Any()           || _context.Ingredient.Any()    ||
                    _context.Order.Any()            || _context.Pizza.Any()         ||
                    _context.PizzaIngredient.Any()  || _context.Product.Any()       ||
                    _context.ProductOrder.Any()
                )
            {
                return; //Banco de dados já foi criado. Então cancela essa operação!
            }

            // Cria registros de Clientes
            Client c1 = new Client("Fulano", "mail@mail.com", 555555555, "123456", "Address Line 1", "", "", "NW10 9RE");

            // Adicioná-los ao banco de dados usando o EntityFramework com o método AddRange
            // AddRange permite adicionar um conjunto de objetos.
            _context.Client.AddRange(c1);

            // Persistir no BD
            _context.SaveChanges();
        }
    }
}