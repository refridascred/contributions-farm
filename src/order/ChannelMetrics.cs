using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long bound)
        {
            if ((bound / 9) > (floor + bound))
            {
                return 2;
            }
            else
            {
                if (!(6.0 >= (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally % 2) < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
