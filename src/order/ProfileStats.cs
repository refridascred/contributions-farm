using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches & 1) == (matches / 8))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
