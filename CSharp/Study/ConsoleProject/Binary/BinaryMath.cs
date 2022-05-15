namespace Binary.MathOperations
{
    class BinaryMath
    {
        // При смещении бит умножение/деление происходит на 2*<кол-во бит>
        public static void MultiplyByTwoInGrade(int x, int gradeOfTwo)
        {
            Console.WriteLine($"{x} * (2 ^ {gradeOfTwo} [{Math.Pow(2, gradeOfTwo)}]) = {x << gradeOfTwo}");
        }
        public static void DivideByTowInGrade(int x, int gradeOfTwo)
        {
            Console.WriteLine($"{x} / (2 ^ {gradeOfTwo} [{Math.Pow(2, gradeOfTwo)}]) = {x >> gradeOfTwo}");
        }
    }
}

//N: 10
//R: 10 << 1 = 10 * 2
//R: 00001010 << 1 = 00010100 [20]

//N: 20
//R: 20 << 2 = 20 * 4
//R: 00010100 << 2 = 01010000 [80]

//N: 80
//R: 80 >> 1 = 80 / 2
//R: 01010000 >> 1 = 00101000 [40]

//N: 40
//R: 40 >> 2 = 40 / 4
//R: 00101000 >> 2 = 00001010 [10]

//1
//10
//11
//100
//101
//110
//111
//1000
//1001
//1010
//1011
//1100
//1101
//1110
//1111
//10000
//10001
//10010
//10011
//10100
//10101
//10110
//10111
//11000
//11001
//11010
//11011
//11100
//11101
//11110
//11111