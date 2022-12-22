
string [] StartArray(int size)
{
  string [] startArray = new string[size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine($"Please, fill array{i}:\t");
    startArray [i]= Convert.ToString(Console.ReadLine());
  }
  return startArray;


}

void CurrentSize (string [] array)
{
   int current = 0;
   int i = 0;
 while (i < array.Length)
  {
    if (array[i].Length <= 3)
    {
      current++;
      i++;
    }
    else i++;
  }
Console.WriteLine($"The size of new array: {current}");
}

void Show2dArray(string [] array) // двумерного массива
{
  for (int i = 0; i < array.Length; i++)
  {
    {
      Console.Write(array[i] + " "); // вывод значений
    }
}
Console.WriteLine();
}








Console.WriteLine("Imput the size of array" );
int size = Convert.ToInt32(Console.ReadLine());
/*
Console.WriteLine("Please, fill array" );

string a = Convert.ToString(Console.ReadLine());

string b = Convert.ToString(Console.ReadLine());

string c = Convert.ToString(Console.ReadLine());
*/
string [] newArray = StartArray(size);
Show2dArray(newArray);

CurrentSize(newArray);