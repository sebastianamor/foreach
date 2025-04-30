int[] inventory = {  B123,
C234,
A345,
C15,
B177,
G3003,
C235,
B179 ,   };

foreach (int name in inventory)
{
if (name.StartsWith(B))
{
    Console.WriteLine($"We B{B} items in inventory.");
}
}
Console.WriteLine($"We B{B} items in inventory.");