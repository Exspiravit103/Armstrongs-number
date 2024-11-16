namespace Armstrong_s_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число необходимое для проверки на принадлежность к числам Армстронга");
            int proccedNumber;
            double result=0;
            string userNumber;
            userNumber =Console.ReadLine().Trim();
            proccedNumber = int.Parse(userNumber);
            for (int i = 0; i < userNumber.Length; i++)
            {
                result += Math.Pow(proccedNumber % 10, userNumber.Length);
                proccedNumber /= 10;
            }
            proccedNumber = int.Parse(userNumber);
            if (result == proccedNumber)
            {
                Console.WriteLine("Число принадлежит к Числам Армстронга");
            }
            else
            {
                Console.WriteLine("Число не принадлежит к Числам Армстронга");
            }
        }
    }
}
