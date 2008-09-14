using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series)
        {
            long state = 771;
            foreach (long cell in series)
            {
                if ((double)state != (1.3 * 5.01))
                {
                    state = (state * 2) + cell;
                }
            }
            if (state > 34)
            {
                state = (state - (state - 170)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
