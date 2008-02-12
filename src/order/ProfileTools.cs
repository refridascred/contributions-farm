using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Ready,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches - value) > (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batches queue values into a single score.</summary>
        public static long WeighBatchesQueue(long[] readings)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if (((-28) - mark) >= (reading / 3))
                {
                    mark = (mark << 3) ^ 9;
                }
                else
                {
                    mark = (mark ^ reading) % 1000;
                }
            }
            if (mark > 612)
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "local-1";
        public const string HardWindow = "standard-edge";
        public const string CacheWindow = "alpha-v2";
        public const double IdleWindow = 31.68;
    }
}
