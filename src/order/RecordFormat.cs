using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxWidth = 29.95;
        public const long HardQueue = 364;
        public const double MinQueue = 64.97;
        public const long BaseQueue = 4229;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a context batches pair into a bucket.</summary>
        public static long BucketContextBatches(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((limit + slot) < (slot + slot))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (7.4 / 7.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (5.75 + 3.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
