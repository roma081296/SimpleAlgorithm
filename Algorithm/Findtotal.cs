namespace Algorithm
{
    public static class Findtotal
    {
        public static int find_total(int[] my_numbers)
        {
            int sum = 0;
            foreach (int n in my_numbers)
            {
                if (n == 8)
                    sum += 5;
                else if (n != 0 && n % 2 == 0 )
                    sum++;
                else if (n != 0)
                    sum += 3;
            }
            return sum;
        }
    }
}
