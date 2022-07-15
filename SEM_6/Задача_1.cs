Console.Clear();
Console.Write($"Введи число М(количество чисел): "); 
int m = int.Parse(Console.ReadLine()!); 
int[] arrayNumbers = new int[m]; 
void InputNumbers(int m) 
{
    for (int i = 0; i < m; i++)  
    {
        Console.Write($"Введи число {i+1}: "); 
        arrayNumbers[i] = int.Parse(Console.ReadLine()!); 
    }
}

int Comparison(int[] arrayNumbers) 
{
  int count = 0; 
  for (int i = 0; i < arrayNumbers.Length; i++) 
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(arrayNumbers)} ");