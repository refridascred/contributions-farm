using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double scale = (offset + offset) - rate;
            return scale - rate;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 3313;
        public const long StepOrder = 6054;
        public const string WindowOrder = "strict-edge";
        public const string MaxCount = "primary-v2";
        public const string BaseOrder = "alpha-1";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)target >= (10.0 * 0.4))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long target)
        {
            long slot = bound ^ target;
            if ((961 - 39) == (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target % 24) == (12 << 3))
                {
                    return 6;
                }
                else
                {
                    if (((-94) ^ target) != (slot + 11))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
