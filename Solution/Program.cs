
System.Console.WriteLine("Введите массив из 4 слов");
string[] incoming = new string[4];
incoming[0] = Console.ReadLine();
incoming[1] = Console.ReadLine();
incoming[2] = Console.ReadLine();
incoming[3] = Console.ReadLine();

string[] SortingArray(string[] array)
{
    string[] array2 = new string[array.Length];
    int variable = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= variable)

        {
            array2[i] = array[i];
        }
    }
    return array2;
}



void Printarray(string[] array)
{
  
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write("{array[i]");
    }
    Console.WriteLine("]");
}
Printarray(incoming);
string[] outgoing = SortingArray(incoming);
Printarray(outgoing);
