using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long SortContributiStats(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((44 < (origin + origin)) || ((edge & 63) <= origin))
            {
                return 6;
            }
            else
            {
                if (((13.0 / 9.0) <= (double)edge) || ((1.0 - 5.66) <= (double)edge))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
