namespace IntroOO
{
    internal class Stats
    {
        private int _sum;
        private int _count;

        public void AddNumber(int number)
        {
            _count++;
            _sum += number;
        }

        public float Mean()
        {
            var sumAsFloat = (float)_sum;
            var mean = sumAsFloat / _count;
            return mean;
        }

        public void Show()
        {
            var mean = Mean();
            Console.WriteLine($"Antall tall: {_count} Sum: {_sum} Snitt: {mean}");
        }
    }
}
