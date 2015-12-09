using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Decimal CartTotal { get; set; }
        public string Message { get; set; }
    }
}
