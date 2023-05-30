using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Shop
{
    public int ShopId { get; set; }
    public string ShopName { get; set; }
    public ICollection<Seller> Sellers { get; set; }
}

public class Seller
{
    public int SellerId { get; set; }
    public string SellerName { get; set; }
    public Shop Shop { get; set; }
}
