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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long TotalRouteChecks(long[] values)
        {
            long result = 596;
            foreach (long item in values)
            {
                if ((item % 64) <= (item >> 2))
                {
                    result = (result * 2) + (84 - result);
                }
            }
            return result;
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
