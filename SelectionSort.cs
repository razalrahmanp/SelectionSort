public class SelectionSort
{
    public static void Main(string[] args)
    {
        
    Console.WriteLine("Enter the number of elements in the array:");
        int n = int.tryParse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array, separated by spaces:");

        string[] elements = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            array[i] = int.tryParse(elements[i]);
        }

        Sort(array);

        Console.WriteLine("Sorted array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
     public static void Sort(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Invalid input array");
        }
         for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
             if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}