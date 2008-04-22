using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits / 2) > (hits + hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((0 << 2) < matches) || !((6.0 - 7.56) != (double)matches))
                {
                    matches = ((matches + 2) + sample) + floor;
                }
            }
            return matches;
        }
    }
}
