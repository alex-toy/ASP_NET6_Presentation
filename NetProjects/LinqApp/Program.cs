
int[] nombres = new int[] {1, 3, 4, 9, 12, 13, 98, 23, 42, 54 };

IEnumerable<int> multiples = from n in nombres where n%3 == 0 select n;

foreach (var item in multiples)
{
    Console.WriteLine(item);
}