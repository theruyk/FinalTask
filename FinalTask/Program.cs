
string[] StartArray(int size)
{
  string[] startArray = new string[size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine($"Please, fill array{i}:\t");
    startArray[i] = Convert.ToString(Console.ReadLine());
  }
  return startArray;
}


string[] FinalArray(int size, string[] array)
{
  int j = 0;
  string[] finalArray = new string[size];
  for (int i = 0; i < array.Length; i++)
    {
      if (array[i].Length <= 3)
      {
         finalArray[j]= array[i];
         j++;
      } 
  }
  return finalArray;
}
int CurrentSize(string[] array)
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
  return current;
}

void ShowArray(string[] array) 
{
  for (int i = 0; i < array.Length; i++)
  {
    {
      Console.Write(array[i] + " "); 
    }
  }
  Console.WriteLine();
}


Console.WriteLine("Imput the size of array");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = StartArray(size);
ShowArray(newArray);

CurrentSize(newArray);
int sizeOfFinalArray = CurrentSize(newArray);
Console.WriteLine($"{sizeOfFinalArray}");

string[] finalRRAY = FinalArray(sizeOfFinalArray, newArray);
ShowArray(finalRRAY);
