int[] array = new int[4]; 
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99,1000);
    if(array[i]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine("[{0}]", String.Join(", ", array));
Console.Write("Чётных чисел в массиве = " + count);