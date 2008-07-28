using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long acc = 484;
            foreach (long cell in levels)
            {
                if ((floor * 5) < floor)
                {
                    acc = ((acc - ((-97) << 2)) % 97) - cell;
                }
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)9 < (double)offset)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
