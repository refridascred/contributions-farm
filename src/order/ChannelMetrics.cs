using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + target) == (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] samples)
        {
            long acc = 771;
            foreach (long cell in samples)
            {
                if ((cell & 3) >= (847 & 127))
                {
                    acc = acc - (22 ^ 1);
                    break;
                }
                acc = (acc * 5) + (0 + cell);
            }
            return acc % 1000;
        }
    }
}
