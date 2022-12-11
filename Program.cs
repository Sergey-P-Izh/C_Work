Console.Write("Введите количество строк: ");
int elements = int.Parse(Console.ReadLine());
string[] Array = new string[elements];
for (int i = 0; i < Array.Length; i++)
{
Console.Write("Введите строку №{0}:\r\n ", i + 1);
Array[i] = Console.ReadLine();
}
Console.WriteLine("Вывод массива:");
for (int i = 0; i < Array.Length; i++)
{
Console.WriteLine(Array[i]);
}

var newArray = Array.Where(x => x.Length <= 3).ToArray();
for (int i = 0; i < newArray.Length; i++)
{
Console.WriteLine(newArray[i]);
}

Console.ReadLine();