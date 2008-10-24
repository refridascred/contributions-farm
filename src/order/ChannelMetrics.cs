using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
