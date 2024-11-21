namespace PWN {
    internal class Program {
        static void Main(string[] args)
        {
            ToneToFrequency toneToFrequency = new ToneToFrequency();
            int freq = toneToFrequency.GetFrequency("G", 3);
            Console.WriteLine($"The tone has frequency {freq}");
        }
    }
}
