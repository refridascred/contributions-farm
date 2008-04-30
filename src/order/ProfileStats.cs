using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((target & 15) == (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length >= 9.7)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
