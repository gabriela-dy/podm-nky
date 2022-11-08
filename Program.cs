int a = 0; // do a si přiřadíme na začátku 0

if (a == 0) // pokud je a 0, dáme do něj jedničku
    a = 1;
if (a == 1) // pokud je a 1, dáme do něj nulu
    a = 0;

Console.WriteLine(a);
Console.ReadKey();
