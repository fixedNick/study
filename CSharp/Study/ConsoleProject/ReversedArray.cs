namespace Basics.Arrays
{
    class ReverseArray
    {
        public static void Main()
        {
            int[] BaseArray = new int[10];
            int[] ReverseArray = new int[10];

            for (int i = 0; i<BaseArray.Length; i++)
                BaseArray[i] = i;

            if (ReverseArray.Length >= BaseArray.Length)
                for (int i = 0, j = ReverseArray.Length - 1;
                    i<BaseArray.Length;
                    i++, j--)
                    ReverseArray[j] = BaseArray[i];

            Console.Write("Base: ");
            foreach (var b in BaseArray)
                Console.Write(b + " ");

            Console.WriteLine();

            Console.Write("Reversed: ");
            foreach (var b in ReverseArray)
                Console.Write(b + " ");

        }
    }
}

/*
for( int i = 0 ; i < ReverseArray.Length ; i++ ) 
    System.Console.WriteLine("ReverseArray[{0}]: {1}", i, ReverseArray[i]);

*/
