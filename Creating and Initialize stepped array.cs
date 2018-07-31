int[][] BaseArray = new int[2][];
// var BaseArray = new int [2][];

for ( int i = 0; i < BaseArray.Length; i++)
{
    BaseArray[i] = new int[(i+1)*2];
    Console.WriteLine("Массив BaseArray[{0}] создан на {1} ячеек", i, BaseArray[i].Length);

    for (int k = 0; k < BaseArray[i].Length; k++)
    {
        BaseArray[i][k] = k + i * 2;
        Console.Write("[ [{0}][{1}] = {2} ]", i, k, BaseArray[i][k]);
    }
    Console.WriteLine(); Console.WriteLine();
}

Console.ReadKey();

// Неявная типизация и инициализация ступенчатого массива

var BaseArray = new[] {
    new[] {1,2,3,4},
    new[] {1,2},
    new[] {32,66,84,134,55}
};

// Неявная типизация и инициализация двумерного массива типа double, размерностью 2x4

var BaseArray = new[,] { 
    {1.2, 2.7},
    {2.22, 7.21},
    {6.23, -7.21},
    {-81.0, 2.21}
 };