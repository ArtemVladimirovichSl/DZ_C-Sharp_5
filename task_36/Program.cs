int[] array = new int[4];
int Sum = 0;
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    if(i%2 != 0)
    {
        Sum += array[i];
        count++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.Write("Сумма элементов, стоящих на нечётных позициях = " + Sum);