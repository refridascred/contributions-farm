using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item & 1) > (8 + item))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = result - (0 >> 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ 244;
                long next = (264 & 255) / 2;
                if (next > ((-5) / 8))
                {
                    result = (result ^ (long)i) % 255;
                    next = ((next << 3) ^ result) % 97;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
