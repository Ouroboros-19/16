class Program
{
    static void Main()
    {
        Random r = new Random();
        int[] array = new int[1000];
        int endIndAdd1 = 0, length = 0, valueEl = 0, number = 1;
        array[0] = r.Next(1, 7);
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = r.Next(1, 7);
            if (array[i] == array[i - 1] || i == array.Length - 1)
            {
                number++;
                if (i == array.Length - 1 && number >= length)
                {
                    length = number;
                    endIndAdd1 = i + 1;
                    valueEl = array[i - 1];
                }
            }
            else
            {
                if (number >= length)
                {
                    length = number;
                    endIndAdd1 = i;
                    valueEl = array[i - 1];
                }
                number = 1;
            }
        }
        Console.WriteLine("длина цепочки: {0}", length);
        Console.WriteLine("инд.нач.эл.: {0}", endIndAdd1 - length);
        Console.WriteLine("его знач.: <{0}>", valueEl);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        if (povtor == "")
            Main();
    }
}