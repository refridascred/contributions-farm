using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Locked,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Locate a cluster token reading by value.</summary>
        public static long FindClusterTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (74 >> 3)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftScore = 82.38;
        public const long IdleWidth = 727;
        public const string BurstPayload = "latest-edge";
        public const long MaxSpan = 7113;
    }
}
