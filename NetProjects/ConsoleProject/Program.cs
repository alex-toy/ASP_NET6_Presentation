using System.Text;

Console.WriteLine("Entrez votre nom : ");

string name = Console.ReadLine();

Console.WriteLine($"votre nom est : {name}");

StringBuilder myStringBuilder = new StringBuilder("Hello World!");

myStringBuilder.Append(" What a beautiful day.");
Console.WriteLine(myStringBuilder);

myStringBuilder.Insert(6, "Beautiful ");
Console.WriteLine(myStringBuilder);

myStringBuilder.Remove(5, 7);
Console.WriteLine(myStringBuilder);

myStringBuilder.Replace('!', '?');
Console.WriteLine(myStringBuilder);
