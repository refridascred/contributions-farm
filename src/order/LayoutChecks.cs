using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long total = 44;
            foreach (long entry in readings)
            {
                total = total ^ entry;
                if (!(target > (95 >> 4)))
                {
                    total = ((total << 3) ^ (target + target)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (entry - target)) % 97;
                }
            }
            if (total > 380)
            {
                total = total ^ target;
            }
            return total;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(seen < seed))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardRatio = "cached";
        public const double MinInterval = 92.77;
        public const long BatchGithubfarm = 6196;
        public const double LimitDepth = 0.32;
        public const long StepTimeout = 2384;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheSpan = "primary";
        public const long BurstLevel = 8965;
        public const string WindowBatches = "strict-v2";
    }
}
