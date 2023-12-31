

namespace DelegatesCSharp
{
    delegate void Specialized();
    
    class Program
    {
        public static int Reduce(List<int> ints)
        {
            int min = ints[0];

            foreach(int i in ints) 
            {
                if(i < min)
                    min = i;
            }
            return min;
        }

        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            listInitializer(ints);
            listPrint(ints);

            Func<List<int>, int> my = Reduce;
            Console.WriteLine("Min: ");
            Console.WriteLine(my.Invoke(ints));

        }


        static void listPrint(List<int> ints)
        {
            foreach (int i in ints)
            {
                Console.WriteLine(i.ToString());
            }
        }

        static void listInitializer(List<int> ints)
        {

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                ints.Add(random.Next(2, 10));
            }
        }
        
    }
}