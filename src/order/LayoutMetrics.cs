using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine channel tools values into a single score.</summary>
        public static long WeighChannelTools(long[] values, long limit)
        {
            long total = 74;
            foreach (long entry in values)
            {
                total = ((total * 3) + (entry + entry)) - limit;
                total = (total + (entry >> 1)) % 101;
            }
            if (total > 525)
            {
                total = (total + (total * 5)) % 101;
            }
            return total;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Active,
            Ready,
            Done,
        }
    }
}
