namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sAll = "";
            string[] sArray;
            char[] Sign;
            do
            {
                if (sAll.Length != 0)
                {
                    Console.WriteLine("");
                }
                try
                {
                    Console.WriteLine("input into spase integer numb 1, integer numb 1 and Operation from (+, -, /, *)");
                    sAll = (Console.ReadLine()).Trim();
                    sArray = sAll.Split(new char[] { ' ' });
                    Sign = sArray[2].ToCharArray();
                    switch (Sign[0])
                    {
                        case '-':
                            Console.WriteLine($"{sArray[0]} {sArray[1]} : {int.Parse(sArray[0]) - int.Parse(sArray[1])}");
                            break;
                        case '+':
                            Console.WriteLine($"{sArray[0]} {sArray[1]} : {int.Parse(sArray[0]) + int.Parse(sArray[1])}");
                            break;
                        case '/':
                            Console.WriteLine($"{sArray[0]} {sArray[1]} : {int.Parse(sArray[0]) / int.Parse(sArray[1])}");
                            break;
                        case '*':
                            Console.WriteLine($"{sArray[0]} {sArray[1]} : {int.Parse(sArray[0]) * int.Parse(sArray[1])}");
                            break;
                        default:
                            Console.WriteLine("Unknow operator!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Unknown string format!");
                }
                Console.WriteLine("For exit enter <Esc>. Else enter any key...");
            } while ((int)((Console.ReadKey()).Key) != 27);
        }
    }
}