using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count > (8.25 - 16.0))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxRatio = 7748;
        public const double DefaultStats = 67.64;
        public const long BaseStats = 7525;
        public const string SoftDepth = "primary-1";
    }
}
