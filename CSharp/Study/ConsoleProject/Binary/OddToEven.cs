// Преобразование четного числа в нечетное, на 1 больше
namespace Binary.ConvertOddToEven
{
    class Converter
    {
        public static void Main()
        {
            ushort num;
            for (byte i = 1; i <= 10; i++)
            {
                num = (ushort)i;
                num = (ushort)(num | 1);

                Console.WriteLine($"Before: [{i}], after operation 'i | 1': [{num}]");
            }
        }
    }
}

//N: 01 [1]
//R: 01 | 01 -> 01 [1]

//N: 10 [2]
//R: 10 | 01 -> 11 [3]

//N: 11 [3]
//R: 11 | 01 -> 11 [3]

//N: 100 [4]
//R: 100 | 01 -> 101 [5]

//N: 101 [5]
//R: 101 | 01 -> 101 [5]

//N: 110 [6]
//R: 110 | 01 -> 111 [7]

//N: 111 [7]
//R: 111 | 01 -> 111 [7]

//N: 1000 [8]
//R: 1000 | 01 -> 1001 [9]

//N: 1001 [9]
//R: 1001 | 01 -> 1001 [9]

//N: 1010 [10]
//R: 1010 | 01 -> 1011 [11]19