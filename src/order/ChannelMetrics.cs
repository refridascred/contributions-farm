using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long CountSessionRecordHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count < (count ^ value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
