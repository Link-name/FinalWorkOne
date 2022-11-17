


string[] arrayString = new string [8] {"1234", "43", "dog", "cat", "world", "big", "3211", "333"}; 
string[] arrayFinal = new string[arrayString.Length];
int n = 3;
void ArraySecondСompletion (string[] arrayString, string[] arrayFinal, int n)
{
for (int i = 0; i < arrayString.Length; i++)
{
   if (arrayString[i].Length<= n)
   {
    arrayFinal[i]=arrayString[i];
   }
}
}
void PrintArray(string[] array)
{
    Console.Write("[");  
  for (int i = 0; i < array.Length-1; i++)
  {
    {
    array = array.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
    Console.Write($"\"{array[i]}\", ");
   
    } 
  } 
  Console.Write($"\"{array[array.Length-1]}\"");
  Console.Write("]");  
}
ArraySecondСompletion(arrayString, arrayFinal, n);
PrintArray(arrayString);
Console.Write(" => ");
PrintArray(arrayFinal);
