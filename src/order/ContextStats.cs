using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 9117;
        public const string RetryAccount = "stable-1";
        public const long SoftScore = 2655;

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 101;
                acc = acc ^ (bound - bound);
                if (((9.0 / 2.0) == (double)acc) && (acc >= (acc / 3)))
                {
                    acc = (acc << 2) ^ (bound - acc);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseTimeout = "primary-v2";
        public const double MaxGraph = 43.16;
        public const double BaseGraph = 68.02;
        public const double CacheCount = 36.14;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) == (71 & 15))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
