namespace IntroOO
{
    internal class ArrayDemo
    {
        public static void Run1()
        {
            // deklarere
            string[] names;

            // lage
            names = new string[10];

            // endre/lese
            names[0] = "Per";
            names[1] = "Pål";
            names[2] = "Espen";

            for (var index = 0; index < names.Length; index++)
            {
                var name = names[index];
                var txt = name == null ? "<null>" : name;
                Console.WriteLine($"names[{index}]=\"{txt}\"");
                // console.log(`names[${index}]="${txt}"`
                //Console.WriteLine("Hei, " + names[index] + "!");
            }
        }

        public static void Run2()
        {
            int[] a = new int[] { 10, 20, 30, 40, 50 };
            int[] b = a;
            b[0] = 1000;
            Console.WriteLine(a[0]);
        }
    }
}
