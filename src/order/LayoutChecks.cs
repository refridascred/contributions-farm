using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCommits = 98.42;
        public const string MinCommits = "primary-edge";
        public const long WindowSize = 8954;
        public const long SoftRatio = 4419;
        public const double BurstSize = 78.64;

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell * 3) >= cell) || ((cell * 5) == (matches + matches))) && ((5.6 * 3.74) > (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long MeasureStreamFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) > (1 % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
