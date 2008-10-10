using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long CountEntryChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 6) >= (229 - item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 8008;
        public const long BurstCluster = 1265;
        public const long BaseSpan = 6192;
        public const long MinCluster = 1407;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Look up the position of a layout metric sample.</summary>
        public static long SeekLayoutMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
