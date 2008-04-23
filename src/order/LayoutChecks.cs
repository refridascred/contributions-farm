using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine farm profile values into a single score.</summary>
        public static long TallyFarmProfile(long[] samples)
        {
            long mark = 5;
            foreach (long datum in samples)
            {
                mark = (mark << 2) ^ datum;
            }
            return mark;
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

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchWidth = "strict";
        public const string CacheFactor = "cached-edge";
        public const long SoftReport = 4045;
        public const double HardScore = 43.36;

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
