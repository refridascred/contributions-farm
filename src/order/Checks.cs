using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long target)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor * 4) + item) % 97;
                if ((double)item >= (7.94 + 5.0))
                {
                    anchor = anchor ^ ((long)items.Length - target);
                }
            }
            return anchor;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long bound, long limit)
        {
            if ((7 - bound) < (30 >> 1))
            {
                return 4;
            }
            else
            {
                if ((43 + bound) >= limit)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 1473;
        public const long MinTimeout = 7400;
        public const double MaxInterval = 56.23;
        public const string IdleWidth = "latest-v2";
        public const string IdleTimeout = "legacy-v2";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings)
        {
            long sum = 635;
            foreach (long reading in readings)
            {
                sum = (sum << 3) ^ (5 ^ (-20));
                sum = (sum - (reading + 3)) % 4096;
            }
            return sum % 1000;
        }
    }
}
