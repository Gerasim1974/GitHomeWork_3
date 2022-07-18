namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string[] sArr;
            int[] iArr = new int[3];
            do
            {
                try
                {
                    if (s.Length != 0)
                      {
                        Console.WriteLine("");
                      };
                    Console.WriteLine("Введите три целых числа используя в качестве разделителя пробел.");
                    s = (Console.ReadLine()).Trim();
                    sArr = s.Split(" ");
                    for (int i = 0; i < sArr.Length; i++)
                    {
                        iArr[i] = int.Parse(sArr[i]);
                    };
                    //step 1
                    if ((iArr[0] > 100) && (iArr[1] > 100))
                    {
                        Console.WriteLine("Каждое из чисел А и В  больше 100");
                    };
                    //step 2
                    if (
                        ((iArr[0] % 2 == 0) && (iArr[1] % 2 != 0)) ||
                        ((iArr[0] % 2 != 0) && (iArr[1] % 2 == 0))
                        )
                    {
                        Console.WriteLine("Только одно из чисел А и В четное");
                    };
                    //step 3
                    if (
                        (iArr[0] > 0) || (iArr[1] > 0)
                        )
                    {
                        Console.WriteLine("Хотя бы одно из чисел А и В положительное");
                    };
                    //step 4
                    if (
                        (iArr[0] % 3 == 0) && (iArr[1] % 3 == 0) && (iArr[2] % 3 == 0)
                        )
                    {
                        Console.WriteLine("Каждое из чисел А, В и С кратно 3");
                    };
                    //step 5
                    if (
                        ((iArr[0] < 50) && (iArr[1] >= 50) && (iArr[2] >= 50)) ||
                        ((iArr[0] >= 50) && (iArr[1] < 50) && (iArr[2] >= 50)) ||
                        ((iArr[0] >= 50) && (iArr[1] >= 50) && (iArr[2] < 50))
                        )
                    {
                        Console.WriteLine("Только одно из чисел А, В и С меньше 50");
                    };
                    //step 6
                    if (
                        (iArr[0] < 0) || (iArr[1] < 0) || (iArr[2] < 0)
                        )
                    {
                        Console.WriteLine("Хотя бы одно из чисел А, В и С отрицательное");
                    }
                }
                catch
                {
                    Console.WriteLine("Неопределенный формат строки");
                };
                Console.WriteLine("Для выхода нажмите <Esc>. Иначе нажмите любую кнопку...");
            } while ((int)((Console.ReadKey()).Key) != 27);
        }
    }
} 