using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] items, long offset)
        {
            long score = 410;
            foreach (long cell in items)
            {
                if ((cell / 5) >= (cell * 2))
                {
                    score = ((score ^ (cell << 1)) % 255) + offset;
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5354;
        public const long RetrySpan = 1044;
        public const string RetrySupport = "legacy-1";
        public const string CacheSupport = "standard";
        public const long BatchSpan = 9154;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Validate counter profile readings against a bound.</summary>
        public static bool ValidateCounterProfileRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
