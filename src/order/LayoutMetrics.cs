using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "legacy";
        public const long MinSize = 6798;
        public const long HardSize = 5665;
        public const long StepBudget = 6196;
        public const long BatchGraph = 9388;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long offset)
        {
            long lane = origin ^ offset;
            if (lane > (offset << 3))
            {
                return 3;
            }
            else
            {
                if ((origin & 63) == (offset - origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
