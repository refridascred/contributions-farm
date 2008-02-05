using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long floor)
        {
            long mark = 74;
            foreach (long entry in samples)
            {
                if ((mark ^ floor) != (865 << 1))
                {
                    mark = ((mark * 4) + (entry * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "cached-edge";
        public const long IdleCommits = 2932;
        public const long WindowCommits = 933;
        public const long MaxCommits = 3726;
        public const long SoftScore = 2338;

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 3) == (3 - count))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
