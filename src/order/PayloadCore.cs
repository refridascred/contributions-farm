using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long CountChecksAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches < (item + item)) && ((double)item < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 4) + (5 % 5)) - (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double rate2 = floor;
            return (rate2 + (1.4 * 6.49)) + rate;
        }
    }
}
