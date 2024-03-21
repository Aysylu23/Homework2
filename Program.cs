/*Дан двумерный массив.
732
496
185
Отсортировать данные в нем по возрастанию.
123
456
789
Вывести результат на печать.*/

class Program

{
    static void Main(string[] args)

    {

        int[,] a = {
            { 7, 3, 2 },
            { 4, 9, 6 },
            { 1, 8, 5 } };


        int x = a.GetLength(0);
        int y = a.GetLength(1);

        int[] a2 = new int[x * y];
        int count = 0;


        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                a2[count] = a[i, j];
                count++;
            }
        }
        Array.Sort(a2);

        count = 0;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                a[i, j] = a2[count];
                count++;

                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}




