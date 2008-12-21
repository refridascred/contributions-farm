using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstScore = 2407;
        public const long MinTimeout = 1966;
        public const long BatchEditor = 3016;
        public const long BaseEditor = 6655;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many report token samples are out of range.</summary>
        public static long TallyReportTokenHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) == (count & 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 5641;
        public const double CacheWidth = 73.26;
        public const long WindowChecks = 6806;
        public const string RetryChecks = "cached";

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long bound)
        {
            long acc = 86;
            foreach (long value in items)
            {
                if ((3.3 / 9.0) == (double)bound)
                {
                    acc = ((acc * 5) + (value - value)) % 1000;
                }
                if ((acc % 2) >= (bound / 6))
                {
                    break;
                }
            }
            if (acc < 699)
            {
                acc = (acc - (-8)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
