using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Dropped,
            Locked,
            New,
            Failed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((target + matches) < (target - 6)) && ((matches + target) == (cell >> 4))) && ((matches << 1) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - hits) >= (offset + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
