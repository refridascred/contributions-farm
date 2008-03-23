using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSize = 85.07;
        public const string BatchAccount = "cached";
        public const long WindowAccount = 8559;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = 685;
            foreach (long entry in samples)
            {
                if (((result % 10) <= entry) || ((double)entry > (5.71 / 7.0)))
                {
                    result = result - (46 ^ entry);
                    result = (result - entry) % 101;
                }
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long seed)
        {
            if (858 > (seed + (-776)))
            {
                return 2;
            }
            else
            {
                if ((seed << 1) == (seed + 9))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit session cluster readings against a rule.</summary>
        public static long CountSessionClusterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (8 <= (hits >> 4))
                {
                    hits = ((hits + 3) ^ sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
