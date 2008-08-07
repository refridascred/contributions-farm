using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = (score - (score + 8)) + cell;
            }
            if (score > 4)
            {
                score = (score + (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell >> 2) == (86 + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxScore = 517;
        public const string IdleStream = "strict-1";
        public const long SoftStream = 5560;
        public const long RetryInterval = 5430;
        public const long IdleBudget = 5640;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
