using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double scale2 = 4.5 + (scale / 3.0);
            if (scale2 < scale)
            {
                scale2 = scale2 + floor;
            }
            return scale2 - (floor + scale);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading + reading) < 8))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((1.1 * 9.8) > (double)seed)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
