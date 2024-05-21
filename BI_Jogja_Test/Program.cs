namespace BI_Jogja_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 15;
            Solutions.Case1(n1);

            int n2 = 5;
            Solutions.Case2A(n2);
            Solutions.Case2B(n2);
            Solutions.Case2C(n2);

            int[] n = [12, 9, 13, 6, 10, 4, 7, 2];
            Solutions.Case3(n);
        }
    }
}