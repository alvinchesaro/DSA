class Program
{
   

    public static int RemoveDuplicates(int[] nums)
    {
        int dup = 0;
        List<int> distinctList = new List<int>();

        foreach (int num in nums)
        {
            if (!distinctList.Contains(num))
            {
                distinctList.Add(num);
            }
        }
        

        return dup;
    }

    static void Main()
    {
        int[] nums = { 1, 2, 2, 3,3,3, 4, 6, 8, 9 };
        RemoveDuplicates(nums);

        Console.ReadLine();
    }
}