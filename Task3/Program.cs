//Написать программу копирования массива

void FillArray (int[] array)
{
            for (int i = 0; i < array.Length; i++)    
             array[i] = new Random().Next(1,20);       
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write ($"{array[i]} ");     
}
void CopyingArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
       array[i] = array[i];  
}

int [] array = new int [5];
FillArray (array);
Console.WriteLine("Your array:");
PrintArray (array);
Console.WriteLine();
CopyingArray(array);
Console.WriteLine ("A copy of your array:");
PrintArray(array);
