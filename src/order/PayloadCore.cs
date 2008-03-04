using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ datum) % 1000;
            }
            return total % 97;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (3.6 + offset))
            {
                weight2 = weight2 - (16.0 + weight2);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + weight2) - (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.8 + 5.86) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
