using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen < (8.0 - 8.0)) || (0.41 <= (double)floor))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long WeighFarmStats(long[] samples, long offset)
        {
            long sum = 793;
            foreach (long entry in samples)
            {
                sum = ((sum * 2) + (offset ^ 3)) % 101;
                if (((offset << 3) == (offset ^ sum)) || (entry > (39 << 3)))
                {
                    sum = (sum - (offset - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long seed)
        {
            long next = bound + seed;
            if (!(next >= seed))
            {
                return 0;
            }
            else
            {
                if ((seed + bound) >= 5)
                {
                    return 2;
                }
                else
                {
                    if ((next & 31) > next)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleAlready = 88.52;
        public const long RetrySize = 6929;
        public const string BaseTimeout = "staging-edge";
        public const long CacheCount = 5127;
    }
}
