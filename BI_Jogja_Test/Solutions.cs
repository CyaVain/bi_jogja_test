namespace BI_Jogja_Test
{
    class Solutions
    {
        public static void Case1(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("N HARUS LEBIH BESAR DARI 0");
                return;
            }

            Console.WriteLine("Case No.1");
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.Write("OKYES ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("OK ");
                }
                else if (i % 4 == 0)
                {
                    Console.Write("YES ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\n");
        }

        public static void Case2A(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("N HARUS LEBIH BESAR DARI 0");
                return;
            }

            Console.WriteLine("Case 2A");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }

            Console.Write("\n");
        }

        public static void Case2B(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("N HARUS LEBIH BESAR DARI 0");
                return;
            }

            Console.WriteLine("Case 2B");
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }

            Console.Write("\n");
        }

        public static void Case2C(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("N HARUS LEBIH BESAR DARI 0");
                return;
            }

            Console.WriteLine("Case 2C");
            bool status = false;
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(x);
                    if (x == n)
                    {
                        status = true;
                    }
                    else if (x == 1)
                    {
                        status = false;
                    }
                    if (status == false)
                    {
                        x++;
                    }
                    else
                    {
                        x--;
                    }
                }
                Console.Write("\n");
            }
        }

        public static void Case2D(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("N HARUS LEBIH BESAR DARI 0");
                return;
            }

            Console.WriteLine("Case 2D");
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(x);
                x++;
                Console.Write("\n");
            }
        }

        public static void Case3(int[] n)
        {
            if (n == null)
            {
                Console.WriteLine("N Tidak Boleh Kosong");
                return;
            }

            List<int> arrayBaru = new List<int>();

            Console.WriteLine("Case No.3");
            foreach (int angka in n)
            {
                if (angka % 3 != 0)
                {
                    arrayBaru.Add(angka);
                }
            }

            arrayBaru.Sort();

            foreach (int a in arrayBaru)
            {
                Console.Write($"{a} ");
            }
        }
    }
}