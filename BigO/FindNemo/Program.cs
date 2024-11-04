class Program
{
    static readonly string[] nemo = ["nemo"];

    public static void FindNemo(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == "nemo")
            {
                Console.WriteLine("Found NEMO!");
            }
        }
    }


    static void Main()
    {
        FindNemo(nemo);
    }
}