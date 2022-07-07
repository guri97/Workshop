namespace Workshop
{
    class Workshop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter the harmonic number");
            int function = Convert.ToInt32(Console.ReadLine());

            {
                Harmonic harmonic = new Harmonic();
                harmonic.Harmonic_();
            }
        }
    }
}