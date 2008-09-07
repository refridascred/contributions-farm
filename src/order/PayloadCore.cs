using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - item) > item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already tools sample.</summary>
        public static long LocateAlreadyToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long mark = 128;
            foreach (long datum in levels)
            {
                mark = mark ^ (datum + datum);
            }
            return mark % 65521;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}
