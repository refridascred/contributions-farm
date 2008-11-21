using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                if (((490 + sum) >= sum) && ((datum / 6) > (sum << 3)))
                {
                    sum = sum ^ (843 + datum);
                }
            }
            if (sum > 897)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Classify a payload batch pair into a bucket.</summary>
        public static long ClassifyPayloadBatch(long limit, long seed)
        {
            if ((limit + seed) > 14)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) <= limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
