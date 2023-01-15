using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqs
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Categoria { get; set; }  
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public List<Categoria> Categorias { get; set; }
    }

}
