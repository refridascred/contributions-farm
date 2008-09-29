using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long state = 434;
            foreach (long entry in series)
            {
                if (((17.0 / 3.0) >= (12.0 + 3.12)) || ((state << 1) > state))
                {
                    state = (state - (entry * 3)) % 255;
                }
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
