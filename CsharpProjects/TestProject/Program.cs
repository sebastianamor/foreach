string[] inventorYs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string inventory  in inventorYs)
{
    if (inventory.StartsWith("C")) // al cambiar la letra cambia la separacion 
    {
        Console.WriteLine(inventory);
    }
}