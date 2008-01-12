using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 7922;
        public const long HardAccount = 3149;
        public const long WindowAccount = 6202;
        public const string SoftAccount = "open-edge";

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ProjectFilterGithubfarm(double ratio, double floor)
        {
            double drift = (ratio * 2.8) - (double)(-95);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - 2.0;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((long)items.Length < (3 % 100))
                {
                    matches = ((matches + 2) + item) + target;
                }
            }
            return matches;
        }
    }
}
