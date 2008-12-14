using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)limit <= (20.0 * 5.0)) || ((limit - sample) < (2 / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 352;
        public const long BaseSpan = 7517;
        public const long MinBudget = 8356;
        public const long SoftLevel = 5657;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-9) + 56) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
