
string[] StartArray(int size) // Создание первого массива
{
  string[] startArray = new string[size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine($"Please, fill array{i}:\t");
    startArray[i] = Convert.ToString(Console.ReadLine());
  }
  return startArray;
}


string[] FinalArray(int size, string[] array) //Создание второго массива 
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
int CurrentSize(string[] array) // Метод нахождения длины второго массива
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

void ShowArray(string[] array) //Метод для вывода массивов в консоль 
{
  for (int i = 0; i < array.Length; i++)
  {
    {
      Console.Write(array[i] + " "); 
    }
  }
  Console.WriteLine();
}


Console.WriteLine("Input the size of array");
int size = Convert.ToInt32(Console.ReadLine());

string[] startArray = StartArray(size);
ShowArray(startArray);

CurrentSize(startArray);
int sizeOfFinalArray = CurrentSize(startArray);
Console.WriteLine($"{sizeOfFinalArray}");

string[] finalArray = FinalArray(sizeOfFinalArray, startArray);
ShowArray(finalArray);
