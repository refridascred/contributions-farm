using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long offset)
        {
            if (seed <= (offset - seed))
            {
                return 0;
            }
            else
            {
                if ((seed * 5) > (1 - offset))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Pending,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count > (entry / 7))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ (3 * 2);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinLevel = 3611;
        public const double BaseRatio = 52.72;
        public const long CacheReport = 9250;
        public const double HardSpan = 97.64;
        public const long LimitReport = 5672;
    }
}
