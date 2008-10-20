using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)seed < (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mix = 241;
            foreach (long datum in levels)
            {
                mix = ((mix * 4) + (mix + datum)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
