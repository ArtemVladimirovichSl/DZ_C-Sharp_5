double[] array = {3, 7, 22, 2, 78};
double min = array[0]; 
double max = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(min > array[i])
    {
        min = array[i]; 
    }
    if(max < array[i])
    {
        max = array[i];
    }
}
Console.Write("Разница между максимальным и минимальным элементами массива = " + (max - min));