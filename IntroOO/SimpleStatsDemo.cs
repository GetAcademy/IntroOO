namespace IntroOO
{
    internal class SimpleStatsDemo
    {
        public static void Run1()
        {
            var stats = new Stats();

            while (true)
            {
                Console.Write("Skriv et tall: ");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                stats.AddNumber(number);
                stats.Show();
            }
        }


        public static void Run2()
        {
            var stats1 = new Stats();
            var stats2 = new Stats();
            stats1.AddNumber(1);
            stats1.AddNumber(2);
            stats2.AddNumber(2);
            stats2.AddNumber(3);
            stats1.Show();
            stats2.Show();

        }
    }
}
