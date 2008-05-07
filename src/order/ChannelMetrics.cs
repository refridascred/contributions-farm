using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long FoldFilterSupport(long[] levels)
        {
            long sum = 421;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - (52 ^ entry)) % 101) + (long)i;
                }
                sum = (sum - (9 / 9)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Draft,
            Synced,
            New,
        }
    }
}
