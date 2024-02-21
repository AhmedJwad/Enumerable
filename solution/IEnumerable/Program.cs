// See https://aka.ms/new-console-template for more information
using IEnumerable;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("================");
Console.WriteLine("IEnumerable");
Console.WriteLine("=============");

#region List
//Console.WriteLine("***List<T>");
//var product = new List<Product>()
//{
//    new Product{Id=1, Name="aaaa", Price=4554},
//    new Product{ Id=2, Name="bbbb", Price=6000},
//    new Product{Id=3, Name="cccc", Price=4444},
//    new Product{Id=4, Name="dddd", Price=8974},
//    new Product{Id=5, Name="eeee", Price=9632},
//    new Product{Id=6, Name="kkkk", Price=7412},
//    new Product{Id=7, Name="ffff", Price=1235},
//    new Product{Id=8, Name="qqqq", Price=0201},
//    new Product{Id=9, Name="ccc", Price=4500},
//};
////foreach (var item in list)
////{
////    Console.WriteLine(item);
////}

//Console.WriteLine("Original List =>");

////list.Insert(5, "asasdel");
////list.Remove("saad");

//for (int i = 0; i < product.Count; i++)
//{
//    Console.WriteLine(product[i]);
//}

//product = product.OrderBy(x => x.Name).ToList();
//Console.WriteLine("order  List =>");
//for (int i = 0; i < product.Count; i++)
//{
//    Console.WriteLine(product[i]);
//}
#endregion

#region Dictionary
//Console.WriteLine("***Dictionar<TKey, TValue>***");
//var fruits=new Dictionary<string, int>();
//fruits.Add("manzana", 1);
//fruits.Add("banan", 2);

//if (fruits.ContainsKey("limon"))
//{
//    fruits["limon"] += 20;

//}
//else
//{
//    fruits.Add("lemones", 20);
//}
//foreach (var item in fruits)
//{
//    Console.WriteLine($"{item.Key}=> {item.Value}");

//}
#endregion
#region Dictionary2
//Console.WriteLine("***Dictionar<TKey, TValue>***");
//var products = new Dictionary<int, Product>()
//{
//    {1, new Product{Id=1,Name="LIMON", Price=45525} },
//    {2, new Product{Id=2,Name="kiwi", Price=5020} },
//    {3, new Product{Id=3,Name="banan", Price=2500} }
//};


//if (products.ContainsKey(5))
//{
//    products[5].Price += 1.10M;

//}
//else
//{
//   products.Add(5, new Product { Id=4, Name="Apple" , Price=2000});
//}
//foreach (var item in products)
//{
//    Console.WriteLine($"{item.Key}=> {item.Value}");

//}


#endregion

#region LinkList
//Console.WriteLine("***LinkList<T>");
//var numbers=new LinkedList<int>();
//numbers.AddLast(10);
//numbers.AddLast(20);
//numbers.AddLast(30);
//numbers.AddLast(40);
//numbers.AddLast(50);
//numbers.AddLast(60);
//numbers.AddFirst(5);
//numbers.AddLast(65);
//var node30 = numbers.Find(30);
//numbers.AddAfter(node30!, 35);
//var node50 = numbers.Find(50);
//numbers.Remove(node50!);
//var pointer=numbers!.Last;
//while (pointer != null)
//{
//    Console.WriteLine(pointer.Value);
//    pointer = pointer.Previous;
//}

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

#endregion


#region Queue
//Console.WriteLine("****Queue<T>");
//var messages=new Queue<string>();
//messages.Enqueue("Hello");
//messages.Enqueue("hi");
//messages.Enqueue("welcome");
//messages.Enqueue("good morning");
//foreach (var item in messages)
//{
//    Console.WriteLine(item);
//}
//var messagepeaked=messages.Peek();
//Console.WriteLine($"Peaked{ messagepeaked}");
//var messageDequeue=messages.Dequeue();
//Console.WriteLine($"message dequeue{messageDequeue}");

//Console.WriteLine("New Queue");
//foreach (var item in messages)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("Dequeu proce=>");
//while(messages.Count > 0)
//{
//    var message=messages.Dequeue();
//    Console.WriteLine(message);
//}
#endregion
#region Stack 
Console.WriteLine("***Stack<T>***");
var numbers=new Stack<int>();
var random=new Random();
for (int i = 0; i < 10; i++)
{
    numbers.Push(i);
}

for (int i = 0; i < 10; i++)
{
    Console.Write($"{numbers.ElementAt(i)}\t");
}
foreach (var item in numbers)
{
    Console.Write($"{item}\t");
}
var numberpeeked=numbers.Peek();
Console.WriteLine($"Peeked...{numberpeeked}");
var numberpoped=numbers.Pop();
Console.WriteLine($"number poped....{numberpoped}");
Console.WriteLine("pop process");
while(numbers.Count > 0)
{
    var number=numbers.Pop();
    Console.Write($"{number}\t");
}
#endregion