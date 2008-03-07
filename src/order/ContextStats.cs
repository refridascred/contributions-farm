using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long SeekEntryCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (3 <= (seen & 127))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Synced,
            New,
            Draft,
            Active,
        }
    }
}
