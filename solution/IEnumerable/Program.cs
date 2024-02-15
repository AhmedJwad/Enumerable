// See https://aka.ms/new-console-template for more information
using IEnumerable;

Console.WriteLine("================");
Console.WriteLine("IEnumerable");
Console.WriteLine("=============");

#region List
Console.WriteLine("***List<T>");
var product = new List<Product>()
{
    new Product{Id=1, Name="aaaa", Price=4554},
    new Product{ Id=2, Name="bbbb", Price=6000},
    new Product{Id=3, Name="cccc", Price=4444},
    new Product{Id=4, Name="dddd", Price=8974},
    new Product{Id=5, Name="eeee", Price=9632},
    new Product{Id=6, Name="kkkk", Price=7412},
    new Product{Id=7, Name="ffff", Price=1235},
    new Product{Id=8, Name="qqqq", Price=0201},
    new Product{Id=9, Name="ccc", Price=4500},
};
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

Console.WriteLine("Original List =>");

//list.Insert(5, "asasdel");
//list.Remove("saad");

for (int i = 0; i < product.Count; i++)
{
    Console.WriteLine(product[i]);
}

product = product.OrderBy(x => x.Name).ToList();
Console.WriteLine("order  List =>");
for (int i = 0; i < product.Count; i++)
{
    Console.WriteLine(product[i]);
}
#endregion

#region Dictionary
Console.WriteLine("***Dictionar<TKey, TValue>***");
var fruits=new Dictionary<string, int>();
fruits.Add("manzana", 1);
fruits.Add("banan", 2);

if (fruits.ContainsKey("limon"))
{
    fruits["limon"] += 20;

}
else
{
    fruits.Add("lemones", 20);
}
foreach (var item in fruits)
{
    Console.WriteLine($"{item.Key}=> {item.Value}");

}
#endregion
#region Dictionary2
Console.WriteLine("***Dictionar<TKey, TValue>***");
var products = new Dictionary<int, Product>()
{
    {1, new Product{Id=1,Name="LIMON", Price=45525} },
    {2, new Product{Id=2,Name="kiwi", Price=5020} },
    {3, new Product{Id=3,Name="banan", Price=2500} }
};


if (products.ContainsKey(5))
{
    products[5].Price += 1.10M;

}
else
{
   products.Add(5, new Product { Id=4, Name="Apple" , Price=2000});
}
foreach (var item in products)
{
    Console.WriteLine($"{item.Key}=> {item.Value}");

}


#endregion