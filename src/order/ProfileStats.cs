using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinDepth = 84.2;
        public const string HardInterval = "stable";
        public const string BatchContributi = "standard-v2";
        public const double HardContributi = 58.6;
        public const long StepTimeout = 7831;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] values, long seed)
        {
            long anchor = 280;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell % 3)) % 97) + seed;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = (acc ^ (value + target)) % 65521;
                acc = (acc ^ (target % 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value < (count % 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
