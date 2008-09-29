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

        /// <summary>Locate a account commits reading by value.</summary>
        public static long FindAccountCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
