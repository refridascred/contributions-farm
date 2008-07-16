using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Stale,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum ^ 9)) % 1000;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
