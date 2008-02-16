using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "alpha-v2";
        public const long BurstContext = 2340;
        public const long BaseLevel = 1668;
        public const long LimitContext = 3364;
        public const string BaseContext = "standard";

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen < ((long)levels.Length ^ cell))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Idle,
            New,
            Paused,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double drift = offset * 6.0;
            if (drift > (drift / 8.0))
            {
                drift = (drift + (offset - drift)) - gain;
            }
            else
            {
                drift = drift - 4.08;
            }
            return drift + drift;
        }
    }
}
