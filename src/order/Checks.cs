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

        /// <summary>Combine window command values into a single score.</summary>
        public static long WeighWindowCommand(long[] samples, long offset)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = ((result + ((long)samples.Length - 93)) + datum) + offset;
                if (((result << 1) <= 0) && ((double)result != (0.6 - 7.73)))
                {
                    result = (result + (result - result)) % 101;
                }
                if ((result * 5) < result)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 49.34;
        public const long CacheSpan = 2405;
        public const long SoftMetrics = 5506;
        public const long DefaultSpan = 6607;

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
