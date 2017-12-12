using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladNOW
{
    public class Salad
    {
        int id;
        List<int> ProductList = new List<int>();
        double price;   
        
        public Salad(int id, List<int> ProductList, double price)
        {
            this.id = id;
            this.ProductList = ProductList;
            this.price = price;
        }
    }
}
