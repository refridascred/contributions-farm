using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long CountContributiTokenGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) >= (floor >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
