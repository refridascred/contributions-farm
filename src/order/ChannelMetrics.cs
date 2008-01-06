using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count filter cluster pairs that satisfy a relation.</summary>
        public static long OverlapFilterClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many command editor samples are out of range.</summary>
        public static long CountCommandEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) != (datum / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
