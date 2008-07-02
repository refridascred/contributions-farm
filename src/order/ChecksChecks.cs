using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((floor - matches) > (floor >> 5))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = 7.5 - (double)423;
            if (gain2 > gain)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 - (gain2 * 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - floor;
        }
    }
}
