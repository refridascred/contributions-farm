using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token record entries.</summary>
        public static long WeighTokenRecord(long[] series)
        {
            long state = 74;
            foreach (long datum in series)
            {
                state = (state ^ state) + datum;
            }
            if (state < 13)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item ^ matches) < item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
