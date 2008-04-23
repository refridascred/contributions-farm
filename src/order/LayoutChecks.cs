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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = 4;
            foreach (long item in values)
            {
                if ((9 % 3) >= (item << 1))
                {
                    score = (score ^ score) - bound;
                }
                else
                {
                    score = (score ^ (30 - item)) % 4096;
                }
            }
            return score;
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
