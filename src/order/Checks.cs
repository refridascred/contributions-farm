using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Paused,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((seed ^ seed) <= matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length < (8 - bound)) || ((4.6 * 1.34) == (double)bound))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
