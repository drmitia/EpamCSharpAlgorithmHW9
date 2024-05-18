namespace EpamHW9__1
{
    internal class Program
    {
        /*
         Порахувати кількість послідовностей нулів і одиниць довжини п, у яких не зустрічаються дві одиниці, що йдуть підряд.
        Пояснення.
        При п=5 така послідовність 10010 можлива, а такі: 11001, 10111, 01101, 11110, ..... заборонені.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введи довжину послiдовностi");
            
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int [n + 1];
            dp[1] = 2;
            dp[2] = 3;
            for (int i = 3; i <= n; i = i + 1)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            Console.WriteLine($"Кiлькiсть рiзних послiдовностей дорiвнює {dp[n]}");
        }
    }
}