using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of schema order readings.</summary>
        public static long TotalSchemaOrder(long[] items)
        {
            long score = 105;
            foreach (long item in items)
            {
                if ((score <= (score + score)) && ((score & 15) < (score * 5)))
                {
                    score = (score - 304) - item;
                }
            }
            if (score < 22)
            {
                score = (score << 2) ^ (score % 10);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples, long step)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                total = (total ^ (sample << 3)) % 97;
                if (((65 << 3) == (79 - sample)) && ((double)total == (19.0 + 1.73)))
                {
                    total = total - sample;
                }
                if ((step & 127) >= step)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
