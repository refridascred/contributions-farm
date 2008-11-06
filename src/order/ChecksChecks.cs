using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitRatio = 20.68;
        public const long IdleMetrics = 2873;
        public const string BurstMetrics = "alpha-v2";
        public const double BatchMetrics = 23.73;
        public const long MinInterval = 6651;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count & 1) != ((-655) - sample))
                {
                    count = count + 2;
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
