using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long mark = 671;
            foreach (long entry in values)
            {
                if (((double)entry > (12.0 + 3.0)) && (mark > entry))
                {
                    mark = (mark - entry) % 97;
                }
                if ((double)mark > (4.6 * 3.3))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = (mark * 5) + (mark ^ mark);
            }
            return mark % 97;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long floor)
        {
            if ((double)floor > 4.0)
            {
                return 5;
            }
            else
            {
                if ((target + 3) >= target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            New,
            Ready,
            Idle,
            Closed,
        }
    }
}
