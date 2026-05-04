namespace GreedyAlgorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Выберете задание, введя его номер:" +
                "\n1. Путешествие" +
                "\n2. Интернет" +
                "\n>> ");
            int exercise = Convert.ToInt32(Console.ReadLine());
            switch (exercise)
            {
                case 1:
                    {
                        string[] input = Console.ReadLine().Split();
                        int distance = Convert.ToInt32(input[0]);
                        int distanceWithFull = Convert.ToInt32(input[1]);
                        input = Console.ReadLine().Split();
                        if (Convert.ToInt32(input[0]) == 0)
                        {
                            if (distanceWithFull >= distance)
                            {
                                Console.WriteLine("0");
                            }
                            else
                            {
                                Console.WriteLine("-1");
                            }
                            break;
                        }
                        else
                        {
                            int countOfGasStations = Convert.ToInt32(input[0]);
                            int[] gasStations = new int[countOfGasStations];
                            for (int j = 0; j < gasStations.Length; j++)
                            {
                                gasStations[j] = Convert.ToInt32(input[j + 1]);
                            }
                            int count = 0;
                            int current = 0;
                            int i = 0;
                            bool flag = true;
                            while (current + distanceWithFull < distance && flag)
                            {
                                int last = current;
                                while (i < gasStations.Length && gasStations[i] <= current + distanceWithFull)
                                {
                                    last = gasStations[i];
                                    i++;
                                }
                                if (last == current)
                                {
                                    count = -1;
                                    flag = false;
                                }
                                if (flag)
                                {
                                    current = last;
                                    count++;
                                }
                            }
                            SpecialMethods.ColorPrint(count.ToString(), ConsoleColor.Green);
                            break;
                        }
                    }
                case 2:
                    {
                        Console.WriteLine();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.Write("Ещё раз? (1 - да, 0 - нет)\n>> ");
            int repeat = Convert.ToInt32(Console.ReadLine());
            if (repeat == 1)
            {
                Main(args);
            }
        }
    }
}