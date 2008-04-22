using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 2272;
        public const double HardCommits = 84.96;
        public const long BaseCommits = 6904;
        public const string StepCommits = "local-v2";
        public const long LimitRatio = 6045;

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            if (((limit & 63) < (step / 5)) || (step > (step & 15)))
            {
                return 8;
            }
            else
            {
                if (((limit >> 2) == (limit + limit)) || ((limit / 4) < (step % 97)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5330;
        public const long LimitChecks = 5233;
        public const string BaseBudget = "fallback-1";

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] items, long seed)
        {
            long mark = 2;
            foreach (long value in items)
            {
                mark = (mark ^ (mark - value)) - seed;
            }
            return mark % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + seen) != (value >> 1))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
