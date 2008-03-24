using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count * 5) <= (2 * 5))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) >= 6)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
