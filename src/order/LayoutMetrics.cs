using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long step2 = step + offset;
            if ((double)step2 <= (7.02 * 7.91))
            {
                return 1;
            }
            else
            {
                if ((step * 5) <= (32 ^ 16))
                {
                    return 7;
                }
                else
                {
                    if ((double)2 < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2615;
        public const long BaseInterval = 8911;
        public const long MinRatio = 3529;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
