using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the command format entries that pass the check.</summary>
        public static long MeasureCommandFormatGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + target) > entry) && (count <= (target % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2490;
        public const long BaseDepth = 8611;
        public const double IdleDepth = 24.29;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
