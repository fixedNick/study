using Binary;
using Basics;

CodeType type = CodeType.None;
switch (type)
{
    case CodeType.Binary:

        Binary.ConvertOddToEven.Converter.Main();
        Binary.MathOperations.BinaryMath.MultiplyByTwoInGrade(10, 5); // 10 * 2^5 = 32
        Binary.MathOperations.BinaryMath.DivideByTowInGrade(12, 2); // 12 / 4 = 3
        Binary.MathOperations.BinaryMath.DivideByTowInGrade(10, 2); // 10 / 4 = 2 (2 lost)
        Binary.MathOperations.BinaryCycles.Main();

        break;

    case CodeType.Basics:

        Basics.RefOut.Example.Main();
        Basics.Arrays.ReverseArray.Main();
        Basics.Arrays.SteppedArray.Main();

        break;
}


enum CodeType
{
    None,
    Binary,
    Basics
}