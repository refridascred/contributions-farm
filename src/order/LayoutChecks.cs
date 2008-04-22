using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 6305;
        public const string SoftLevel = "cached";
        public const long LimitSize = 8230;
        public const long DefaultProfile = 792;
        public const long BatchScore = 1700;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
