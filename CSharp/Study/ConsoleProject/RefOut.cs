// ref и out
// Перед передачей переменной в качестве аргумента с модификаторо ref ( по ссылке ) -
// - данная переменная обязана быть проинициализированна, то есть иметь ссылку на объект
// При передаче ссылки через ref инициализация в момент передачи аргумента невозможна

// ref используется для передачи в метод какой-то информации извне, для дальнейшей работы с ней.
// out испльзуется для получения информации из метода.
// Так же перменную с модификатором out можно создать во-время передачи аргумента
namespace Basics.RefOut
{
    class Ma
    {
        public static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /*
            public static void SwapOut ( out int a, out int b ) { 
                // Такая реализация невозможна т.к. на выходе переменные out должны четко иметь значение
                int temp = a;
                a = b;
                b = temp;
            }
        */

        // Пример использования out
        public static String ErrorMessage = "Высота менее 100 метров";
        public static bool RealExampleMethod(int width, out int height)
        {
            height = 1;
            width *= 20;

            height = width * 15;

            if (height > 100)
                return true;
            else
                return false;
        }
    }

    class Example
    {
        public static void Main()
        {
            int a = 10, b = 15;

            Ma.SwapRef(ref a, ref b); // a и b уже имеют ссылки на объекты
            System.Console.WriteLine("A: {0}, B{1}", a, b); // A: 15, B: 10

            // error at class method
            //Ma.SwapOut( out a, out b );
            //System.Console.WriteLine("A: {0}, B{1}", a,b); // A: 10, B: 15

            // Пример использования out

            Int32 Width = 25;

            if (Ma.RealExampleMethod(Width, out int Height))
                Console.WriteLine("Полученная высота: {0}", Height);
            else
                Console.WriteLine(Ma.ErrorMessage);
        }
    }
}