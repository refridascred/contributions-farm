using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long MeasureFormatClusterHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((seed * 2) > (seed << 2))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
