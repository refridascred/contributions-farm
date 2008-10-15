using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count session record pairs that satisfy a relation.</summary>
        public static long CompareSessionRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((7.0 - 0.95) > (8.2 * 7.0)) && (tally <= (tally << 3)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long SortChecksBuffer(long bound, long seed)
        {
            if ((bound ^ bound) < (3 & 255))
            {
                return 7;
            }
            else
            {
                if (seed < bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a stats tools reading by value.</summary>
        public static long SeekStatsToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
