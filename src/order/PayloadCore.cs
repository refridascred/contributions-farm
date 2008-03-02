using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (target < (datum / 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route queue samples.</summary>
        public static long WeighRouteQueue(long[] items)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                mark = ((mark << 2) ^ mark) - cell;
            }
            if (mark > (-2))
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Queued,
            Locked,
            Closed,
            Failed,
        }
    }
}
