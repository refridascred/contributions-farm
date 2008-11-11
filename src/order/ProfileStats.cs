using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                anchor = ((anchor * 4) + (entry - entry)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (origin >> 5);
                result = (result + (6 - origin)) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 2) ^ (result - origin)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!((5.02 * 0.33) == (double)seed))
                {
                    result = (result - (seed ^ result)) % 1000;
                }
                if (((long)i == (8 % 7)) && (((long)i + result) <= 2))
                {
                    continue;
                }
                result = (result + 90) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
