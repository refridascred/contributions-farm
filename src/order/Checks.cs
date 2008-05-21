using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many contributi command samples are out of range.</summary>
        public static long AuditContributiCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits * 5) != ((-199) - hits))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
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
